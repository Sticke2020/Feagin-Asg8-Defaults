using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Runtime.Remoting.Lifetime;

namespace Feagin_Asg10_SQL
{
    public partial class FormProperty : Form
    {
        Property property = new Property();

        public FormProperty(Property property)
        {
            this.property = property;
            InitializeComponent();
        }

        private void FormProperty_Load(object sender, EventArgs e)
        {
            loadPropertyData();
            labelError.Text = "";
        }

        private void loadPropertyData()
        {
            textBoxPropertyAddress.Text = property.Address;
            textBoxPropertyPrice.Text = property.Price.ToString();
            textBoxPropertyCity.Text = property.City;
            textBoxPropertyID.Text = property.Id.ToString();
            textBoxPropertyState.Text = property.State;
            textBoxPropertyZip.Text = property.Zip;
            textBoxBriefDescription.Text = property.DescriptionBrief;
            textBoxFullDescription.Text = property.DescriptionFull;
            numericUpDownBathrooms.Value = property.Bathrooms;
            numericUpDownBedrooms.Value = property.Bedrooms;
            checkBoxLaundry.Checked = property.OnsiteLaundry;
            checkBoxParking.Checked = property.OnsiteParking;
            

            if (property.StatusTypeID == 1)
            {
                checkBoxActive.Checked = true;
            }
            if (property.StatusTypeID == 2)
            {
                checkBoxActive.Checked = false;
            }

            if (property.AvailableOn > dateTimePickerAvailableOn.MinDate)
            {
                dateTimePickerAvailableOn.Value = property.AvailableOn;
            }
            else
            {
                dateTimePickerAvailableOn.Value = DateTime.Now;
            }

            if (property.DateUpdated != DateTime.MinValue)
            {
                textBoxDateUpdated.Text = property.DateUpdated.ToString();
            }
            else
            {
                textBoxDateUpdated.Text = "Not Updated";
            }

            if (property.DateAdded != DateTime.MinValue)
            {
                textBoxDateAdded.Text = property.DateAdded.ToString();
            }
            else
            {
                textBoxDateAdded.Text = DateTime.Now.ToString();
            }
        }

        private void buttonPropertyCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPropertySave_Click(object sender, EventArgs e)
        {
            property.Address = textBoxPropertyAddress.Text;
            property.City = textBoxPropertyCity.Text;
            property.State = textBoxPropertyState.Text;
            property.Zip = textBoxPropertyZip.Text;
            property.Price = Convert.ToDecimal(textBoxPropertyPrice.Text);
            property.DescriptionBrief = textBoxBriefDescription.Text;
            property.DescriptionFull = textBoxFullDescription.Text;
            property.Bedrooms = Convert.ToInt32(numericUpDownBedrooms.Text);
            property.Bathrooms = Convert.ToInt32(numericUpDownBathrooms.Text);
            property.OnsiteParking = checkBoxParking.Checked;
            property.OnsiteLaundry = checkBoxLaundry.Checked;
            property.AvailableOn = dateTimePickerAvailableOn.Value;

            if (property.Address == "")
            {
                labelError.Text = "You must enter an Address.";
            }
            if (property.City == "" || property.State == "" || property.Zip == "")
            {
                labelError.Text = "You must enter a City, State, and Zip.";
            }
            if (property.Price == 0)
            {
                labelError.Text = "You must enter a Price.";
            }
            if (property.Bedrooms <= 0 || property.Bathrooms <= 0)
            {
                labelError.Text = "You must enter number of bedrooms and bathrooms.";
            }
            if (property.Address != "" && property.City != "" && property.State != ""
                && property.Zip != "" && property.Price != 0 && property.Bedrooms != 0
                && property.Bathrooms != 0)
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }

        }
    }
}
