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
    public partial class FormTenant : Form
    {
        // Instance of Tenant object needed due to Tenant scope
        // Tenant object is member variable
        private Tenant tenant = new Tenant();

        public FormTenant()
        {
            InitializeComponent();
        }

        // Constructor used to pass tenant from FormTenant / FormMain
        public FormTenant(Tenant tenant)
        {
            this.tenant = tenant;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTenant_Load(object sender, EventArgs e)
        {
            loadTenantData();
            labelError.Text = "";
        }

        private void loadTenantData()
        {
            textBoxFirstName.Text = tenant.FirstName;
            textBoxLastName.Text = tenant.LastName;
            textBoxID.Text = tenant.Id.ToString();
            textBoxCity.Text = tenant.City;
            textBoxState.Text = tenant.State;
            textBoxZip.Text = tenant.Zip;
            textBoxEmail.Text = tenant.Email;
            textBoxPhone.Text = tenant.Phone;
            textBoxDateAdded.Text = tenant.DateAdded.ToString();

            if (tenant.DateUpdated != DateTime.MinValue)
            {
                textBoxDateUpdated.Text = tenant.DateUpdated.ToString();
            }
            else
            {
                textBoxDateUpdated.Text = "Not Updated";
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Update the tenant object with the data from the textBoxes
            tenant.FirstName = textBoxFirstName.Text;
            tenant.LastName = textBoxLastName.Text;
            tenant.City = textBoxCity.Text;
            tenant.State = textBoxState.Text;
            tenant.Zip = textBoxZip.Text;
            tenant.Email = textBoxEmail.Text;
            tenant.Phone = textBoxPhone.Text;
            tenant.DateUpdated = DateTime.Now;

            if (tenant.FirstName == "" || tenant.LastName == "" )
            {
                labelError.Text = "You must enter a First and Last name.";
            }
            if (tenant.City == "" || tenant.State == "" || tenant.Zip == "")
            {
                labelError.Text = "You must enter a City, State, and Zip.";
            }
            if (tenant.FirstName != "" && tenant.LastName != "" && tenant.City != ""
                && tenant.State != "" && tenant.Zip != "")
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }

        }
    }
}
