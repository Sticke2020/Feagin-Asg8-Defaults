using Feagin_Asg10_SQL.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Feagin_Asg10_SQL
{
    public partial class FormMain : Form
    {
        List<Tenant> listTenant = new List<Tenant>();
        List<Property> listProperty = new List<Property>();
        List<Lease> listLease = new List<Lease>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void loadTenantListBox()
        {


            // Clear the listBox
            listBoxTenant.Items.Clear();

            // Add active records to listbox

            if (radioButtonTenantActive.Checked)
            {
                foreach (Tenant tenant in TenantDB.getTenants(1))
                {
                    listBoxTenant.Items.Add(tenant);
                }
            }
            else if (radioButtonTenantDeleted.Checked)
            {
                // Add inactive records to listbox
                foreach (Tenant tenant in TenantDB.getTenants(2))
                {
                    listBoxTenant.Items.Add(tenant);
                }
            }
            else
            {
                foreach (Tenant tenant in TenantDB.getTenants(1))
                {
                    listBoxTenant.Items.Add(tenant);
                }
                foreach (Tenant tenant in TenantDB.getTenants(2))
                {
                    listBoxTenant.Items.Add(tenant);
                }
            }
        }

        private void loadPropertyListBox()
        {
            listBoxProperty.Items.Clear();


            if (radioButtonPropertyActive.Checked)
            {
                foreach (Property property in PropertyDB.getProperties(1))
                {
                    listBoxProperty.Items.Add(property);
                }
            }
            else if (radioButtonPropertyDeleted.Checked)
            {
                foreach (Property property in PropertyDB.getProperties(2))
                {
                    listBoxProperty.Items.Add(property);
                }
            }
            else
            {
                foreach (Property property in PropertyDB.getProperties(1))
                {
                    listBoxProperty.Items.Add(property);
                }
                foreach (Property property in PropertyDB.getProperties(2))
                {
                    listBoxProperty.Items.Add(property);
                }
            }

        }

        private void loadLeaseListBox()
        {
            listBoxLease.Items.Clear();

            if (radioButtonLeaseActive.Checked)
            {
                foreach (Lease lease in LeaseDB.getLeases(1))
                {
                    listBoxLease.Items.Add(lease);
                }
            }
            else if (radioButtonLeaseDeleted.Checked)
            {
                foreach (Lease lease in LeaseDB.getLeases(2))
                {
                    listBoxLease.Items.Add(lease);
                }
            }
            else
            {
                foreach (Lease lease in LeaseDB.getLeases(1))
                {
                    listBoxLease.Items.Add(lease);
                }
                foreach (Lease lease in LeaseDB.getLeases(2))
                {
                    listBoxLease.Items.Add(lease);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DatabaseSettings.ApiKey = Properties.Settings.Default.DefaultAPIKey;
            loadAllListBoxes();
        }

        private void loadAllListBoxes()
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

                // Get most up to date version of tenant object
                tenant = TenantDB.getTenantByID(tenant.Id);

                FormTenant formTenant = new FormTenant(tenant);
                formTenant.ShowDialog();

                if (formTenant.DialogResult == DialogResult.OK)
                {
                    TenantDB.updateTenant(tenant);
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
                // Update the database
                TenantDB.insertTenant(tenant);

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

            property.City = Properties.Settings.Default.DefaultCity;
            property.State = Properties.Settings.Default.DefaultState;
            property.Zip = Properties.Settings.Default.DefaultZip;

            FormProperty formProperty = new FormProperty(property);
            formProperty.ShowDialog();

            if (formProperty.DialogResult == DialogResult.OK)
            {
                // Update the database
                PropertyDB.insertProperty(property);

                // reload the listBox
                loadPropertyListBox();
            }
        }

        private void defaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDefaults formDefaults = new FormDefaults();
            formDefaults.ShowDialog();

            //Set the API KEY
            if (formDefaults.DialogResult == DialogResult.OK)
            {
                DatabaseSettings.ApiKey = Properties.Settings.Default.DefaultAPIKey;
                loadAllListBoxes();
            }

        }
            

        private void propertyEdit()
        {
            if (listBoxProperty.SelectedIndex != -1)
            {
                // Casting data from listBox to Property object
                Property property = (Property)listBoxProperty.SelectedItem;

                // Get most up to date version of Property object
                property = PropertyDB.getPropertyByID(property.Id);

                FormProperty formProperty = new FormProperty(property);
                formProperty.ShowDialog();

                if (formProperty.DialogResult == DialogResult.OK)
                {
                    PropertyDB.updateProperty(property);
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
                    LeaseDB.insertLease(lease);

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

                // Get most up to date version of Lease object
                lease = LeaseDB.getLeaseByID(lease.Id);

                FormLease formLease = new FormLease(lease);
                formLease.ShowDialog();

                if (formLease.DialogResult == DialogResult.OK)
                {
                    LeaseDB.updateLease(lease);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButtonTenantActive_Click(object sender, EventArgs e)
        {
            loadTenantListBox();
        }

        private void radioButtonTenantDeleted_Click(object sender, EventArgs e)
        {
            loadTenantListBox();
        }

        private void radioButtonTenantBoth_Click(object sender, EventArgs e)
        {
            loadTenantListBox();
        }

        private void radioButtonPropertyActive_Click(object sender, EventArgs e)
        {
            loadPropertyListBox();
        }

        private void radioButtonPropertyDeleted_Click(object sender, EventArgs e)
        {
            loadPropertyListBox();
        }

        private void radioButtonPropertyBoth_Click(object sender, EventArgs e)
        {
            loadPropertyListBox();
        }

        private void radioButtonLeaseActive_Click(object sender, EventArgs e)
        {
            loadLeaseListBox();
        }

        private void radioButtonLeaseDeleted_Click(object sender, EventArgs e)
        {
            loadLeaseListBox();
        }

        private void radioButtonLeaseBoth_Click(object sender, EventArgs e)
        {
            loadLeaseListBox();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
