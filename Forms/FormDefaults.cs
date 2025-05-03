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
    public partial class FormDefaults : Form
    {
        public FormDefaults()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDefaults_Load(object sender, EventArgs e)
        {
            // Load the default values from the settings

            textBoxCity.Text = Properties.Settings.Default.DefaultCity;
            textBoxState.Text = Properties.Settings.Default.DefaultState;
            textBoxZip.Text = Properties.Settings.Default.DefaultZip;
            textBoxApiKey.Text = Properties.Settings.Default.DefaultAPIKey;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Sets the defaults from the text boxes
            Properties.Settings.Default.DefaultCity = textBoxCity.Text;
            Properties.Settings.Default.DefaultState = textBoxState.Text;
            Properties.Settings.Default.DefaultZip = textBoxZip.Text;
            Properties.Settings.Default.DefaultAPIKey = textBoxApiKey.Text;

            // Saves the changes made to defaults
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
        }
    }
}
