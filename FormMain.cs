using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feagin_Asg9_SLR
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

        private void loadPropertyListBox()
        {
            listBoxProperty.Items.Clear();

            List<Property> listProperty = SLRStaticDB.getProperties();

            foreach (Property property in listProperty)
            {
                listBoxProperty.Items.Add(property);
            }
        }

        private void loadLeaseListBox()
        {
            listBoxLease.Items.Clear();

            List<Lease> listLease = SLRStaticDB.getLease();

            foreach (Lease lease in listLease)
            {
                listBoxLease.Items.Add(lease);
            }
        }

        private void buttonDefaults_Click(object sender, EventArgs e)
        {
            FormDefaults formDefaults = new FormDefaults();
            formDefaults.ShowDialog();
        }

       

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadTenantListBox();
            loadPropertyListBox();
            loadLeaseListBox();
        }

        

        private void listBoxTenant_DoubleClick(object sender, EventArgs e)
        {
            tenantEdit();
        }

        private void tenantEdit()
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

        private void buttonAddTenant_Click(object sender, EventArgs e)
        {
            // Create new Tenant object
            Tenant tenant = new Tenant();

            // Defaults for new Tenant object
            tenant.Id = 0;
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

        private void buttonEditTenant_Click(object sender, EventArgs e)
        {
            tenantEdit();
        }

        private void buttonAddProperty_Click(object sender, EventArgs e)
        {
            // Create new property object
            Property property = new Property();

            FormProperty formProperty = new FormProperty(property);
            formProperty.ShowDialog();

            if (formProperty.DialogResult == DialogResult.OK)
            {
                // Update the static database class
                SLRStaticDB.addProperty(property);

                // reload the listBox
                loadPropertyListBox();
            }
        }

        private void defaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDefaults formDefaults = new FormDefaults();
            formDefaults.ShowDialog();
        }

        private void propertyEdit()
        {
            if (listBoxProperty.SelectedIndex != -1)
            {
                // Casting data from listBox to Property object
                Property property = (Property)listBoxProperty.SelectedItem;

                FormProperty formProperty = new FormProperty(property);
                formProperty.ShowDialog();

                if (formProperty.DialogResult == DialogResult.OK)
                {
                    SLRStaticDB.updateProperty(property);
                }

                loadPropertyListBox();

            }
            else
            {
                MessageBox.Show("Please select a Property to edit.");
            }
        }

        private void buttonEditProperty_Click(object sender, EventArgs e)
        {
            propertyEdit();
        }

        private void buttonAddLease_Click(object sender, EventArgs e)
        {
            if (listBoxTenant.SelectedIndex != -1 && listBoxProperty.SelectedIndex != -1)
            {
                // Create new Lease object
                Lease lease = new Lease();
                Tenant tenant = (Tenant)listBoxTenant.SelectedItem;
                Property property = (Property)listBoxProperty.SelectedItem;

                FormLease formLease = new FormLease(lease, tenant.Id, property.Id);
                formLease.ShowDialog();

                if (formLease.DialogResult == DialogResult.OK)
                {
                    // Update the static database class
                    SLRStaticDB.addLease(lease);

                    // reload the listBox
                    loadLeaseListBox();
                }
            }
            else
            {
                MessageBox.Show("Please select a Tenant Record and a Property Record.");
            }
        }

        private void leaseEdit()
        {
            if (listBoxLease.SelectedIndex != -1)
            {
                // Casting data from listBox to Lease object
                Lease lease = (Lease)listBoxLease.SelectedItem;

                FormLease formLease = new FormLease(lease);
                formLease.ShowDialog();

                if (formLease.DialogResult == DialogResult.OK)
                {
                    SLRStaticDB.updateLease(lease);
                }

                loadLeaseListBox();

            }
            else
            {
                MessageBox.Show("Please select a Lease to edit.");
            }
        }

        private void buttonEditLease_Click(object sender, EventArgs e)
        {
            leaseEdit();
        }

        private void listBoxProperty_DoubleClick(object sender, EventArgs e)
        {
            propertyEdit();
        }

        private void listBoxLease_DoubleClick(object sender, EventArgs e)
        {
            leaseEdit();
        }
    }
}
