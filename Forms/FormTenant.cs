using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feagin_Asg10_SQL
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
            textBoxAddress.Text = tenant.Address;
            textBoxAddedByID.Text = tenant.AddedByID.ToString();
            
            
            if (tenant.StatusTypeID == 1)
            {
                checkBoxActive.Checked = true;
            }
            if (tenant.StatusTypeID == 2)
            {
                checkBoxActive.Checked = false;
            }

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
            tenant.Address = textBoxAddress.Text;

            if (checkBoxActive.Checked)
            {
                tenant.StatusTypeID = 1;
            }
            else
            {
                tenant.StatusTypeID = 2;
            }
            

            if (tenant.FirstName == "" || tenant.LastName == "" )
            {
                labelError.Text = "You must enter a First and Last name.";
            }
            if (tenant.City == "" || tenant.State == "" || tenant.Zip == "")
            {
                labelError.Text = "You must enter a City, State, and Zip.";
            }
            if (!tenant.Email.Contains("@") || !tenant.Email.Contains("."))
            {
                labelError.Text = "You must enter a valid Email Address.";
            }
            if (tenant.Phone.Any(char.IsLetter))
            {
                labelError.Text = "Phone number must not contain letters";
            }
            if (tenant.Zip.Any(char.IsLetter))
            {
                labelError.Text = "Zip must not contain letters";
            }
            if (tenant.State.Any(char.IsNumber))
            {
                labelError.Text = "State must not contain numbers";
            }

            if (tenant.FirstName != "" && tenant.LastName != "" && tenant.City != ""
                && tenant.State != "" && tenant.Zip != "" && tenant.Email.Contains(".") && tenant.Email.Contains("@") && !tenant.Phone.Any(char.IsLetter) && !tenant.Zip.Any(char.IsLetter) && !tenant.State.Any(char.IsNumber))
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }

        }
    }
}
