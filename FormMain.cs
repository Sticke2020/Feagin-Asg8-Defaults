using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feagin_Asg8_Defaults
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void loadTenantListBox()
        {
            // Load the Tenant ListBox
            // Clear the listBox
            listBoxTenant.Items.Clear();

            // Make a list and populate it from SLRStaticDB
            List<Tenant> listTenant = SLRStaticDB.getTenants();

            // Display the list in the listBox
            foreach (Tenant tenant in listTenant)
            {
                listBoxTenant.Items.Add(tenant);
            }
        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            FormDefaults formDefaults = new FormDefaults();
            formDefaults.ShowDialog();
        }

        private void buttonTenant_Click(object sender, EventArgs e)
        {
            // Create new Tenant object
            Tenant tenant = new Tenant();

            // Defaults for new Tenant object
            tenant.ID = 0;
            tenant.FirstName = Properties.Settings.Default.DefaultFirstName;
            tenant.LastName = Properties.Settings.Default.DefaultLastName;
            tenant.City = Properties.Settings.Default.DefaultCity;
            tenant.Zip = Properties.Settings.Default.DefaultZip;
            tenant.State = Properties.Settings.Default.DefaultState;
            tenant.DateAdded = DateTime.Now;



            FormTenant formTenant = new FormTenant(tenant);
            formTenant.ShowDialog();

            // Do we need to add a record?
            if (formTenant.DialogResult == DialogResult.OK)
            {
                // Update the static database class
                SLRStaticDB.addTenant(tenant);

                // reload the listBox
                loadTenantListBox();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadTenantListBox();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Get tenant from listBox
            if (listBoxTenant.SelectedIndex != -1)
            {
                // Casting data from listBox to Tenant object
                Tenant tenant = (Tenant)listBoxTenant.SelectedItem;

                FormTenant formTenant = new FormTenant(tenant);
                formTenant.ShowDialog();

                if (formTenant.DialogResult == DialogResult.OK)
                {
                    SLRStaticDB.updateTenant(tenant);
                }

                loadTenantListBox();

            }
            else
            {
                MessageBox.Show("Please select a tenant to edit.");
            }

        }
    }
}
