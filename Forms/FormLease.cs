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
    public partial class FormLease : Form 
    {
        Lease lease = new Lease();

        public FormLease(Lease lease)
        {
            this.lease = lease;
            InitializeComponent();
        }
        public FormLease(Lease lease, int tenant, int property)
        {
            this.lease = lease;
            this.lease.TenantID = tenant;
            this.lease.PropertyID = property;
            InitializeComponent();
        }

        private void FormLease_Load(object sender, EventArgs e)
        {
            loadLeaseData();
            labelError.Text = "";
        }

        private void loadLeaseData()
        {
            
            if (lease.PropertyID != 0)
            {
                textBoxLPropertyID.Text = lease.PropertyID.ToString();
                textBoxLTenantID.Text = lease.TenantID.ToString();
                textBoxLeaseDescription.Text = lease.Description;
                textBoxMonthlyRate.Text = lease.MonthlyRate.ToString();
                textBoxLeaseNotes.Text = lease.Notes;
                textBoxLeaseID.Text = lease.Id.ToString();
                textBoxLPropertyID.Text = lease.PropertyID.ToString();
                textBoxLTenantID.Text = lease.TenantID.ToString();


                Tenant tenant = new Tenant();
                tenant = SLRStaticDB.getTenantByID(lease.TenantID);

                Property property = new Property();
                property = SLRStaticDB.getPropertyByID(lease.PropertyID);

                textBoxLFirstName.Text = tenant.FirstName;
                textBoxLLastName.Text = tenant.LastName;
                textBoxLEmail.Text = tenant.Email;
                textBoxLPhone.Text = tenant.Phone;

                textBoxLPropertyAddress.Text = property.Address;
                textBoxLPropertyPrice.Text = property.Price.ToString();
                textBoxLPropertyCity.Text = property.City;
                textBoxLPropertyState.Text = property.State;
                textBoxLPropertyZip.Text = property.Zip;
                numericUpDownLBedrooms.Value = property.Bedrooms;
                numericUpDownLBathrooms.Value = property.Bathrooms;
                checkBoxLLaundry.Checked = property.OnsiteLaundry;
                checkBoxLParking.Checked = property.OnsiteParking;


                if (lease.StatusTypeID == 1)
                {
                    checkBoxLeaseActive.Checked = true;
                }
                if (lease.StatusTypeID == 2)
                {
                    checkBoxLeaseActive.Checked = false;
                }

                if (lease.DateAdded != DateTime.MinValue)
                {
                    textBoxDateAdded.Text = lease.DateAdded.ToString();
                }
                else
                {
                    textBoxDateAdded.Text = DateTime.Now.ToString();
                }

                if (lease.DateUpdated != DateTime.MinValue)
                {
                    textBoxDateUpdated.Text = lease.DateUpdated.ToString();
                }
                else
                {
                    textBoxDateUpdated.Text = "Not Updated";
                }

                if (lease.DateLeaseStarts > dateTimePickerLeaseStarts.MinDate)
                {
                    dateTimePickerLeaseStarts.Value = lease.DateLeaseStarts;
                }
                else
                {
                    dateTimePickerLeaseStarts.Value = DateTime.Now;
                }
                // Fix this when you get to lease
                if (lease.DateLeaseEnds > dateTimePickerLeaseEnds.MinDate)
                {
                    dateTimePickerLeaseEnds.Value = lease.DateLeaseStarts;
                }
                else
                {
                    dateTimePickerLeaseEnds.Value = DateTime.Now;
                }
            }

            checkBoxLeaseActive.Checked = lease.StatusTypeID == 1;
        }

        private void buttonLeaseCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLeaseSave_Click(object sender, EventArgs e)
        {
            lease.PropertyID = Convert.ToInt32(textBoxLPropertyID.Text);
            lease.TenantID = Convert.ToInt32(textBoxLTenantID.Text);
            lease.Description = textBoxLeaseDescription.Text;
            lease.DateLeaseEnds = dateTimePickerLeaseEnds.Value;
            lease.DateLeaseStarts = dateTimePickerLeaseStarts.Value;
            lease.MonthlyRate = Convert.ToInt32(textBoxMonthlyRate.Text);
            lease.Notes = textBoxLeaseNotes.Text;

            if (lease.MonthlyRate == 0)
            {
                labelError.Text = "You must enter a Monthly Rate.";
            }
            if (dateTimePickerLeaseStarts.Value >= dateTimePickerLeaseEnds.Value)
            {
                labelError.Text = "Lease start date must come befor lease end date.";
            }
           
            if (lease.MonthlyRate != 0 && dateTimePickerLeaseStarts.Value < dateTimePickerLeaseEnds.Value)
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }
    }
}
