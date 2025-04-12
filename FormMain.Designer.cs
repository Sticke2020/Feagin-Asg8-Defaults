namespace Feagin_Asg8_Defaults
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDefaults = new System.Windows.Forms.Button();
            this.buttonTenant = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxTenant = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDefaults
            // 
            this.buttonDefaults.Location = new System.Drawing.Point(15, 33);
            this.buttonDefaults.Name = "buttonDefaults";
            this.buttonDefaults.Size = new System.Drawing.Size(122, 82);
            this.buttonDefaults.TabIndex = 0;
            this.buttonDefaults.Text = "Defaults";
            this.buttonDefaults.UseVisualStyleBackColor = true;
            this.buttonDefaults.Click += new System.EventHandler(this.buttonDefaults_Click);
            // 
            // buttonTenant
            // 
            this.buttonTenant.Location = new System.Drawing.Point(15, 130);
            this.buttonTenant.Name = "buttonTenant";
            this.buttonTenant.Size = new System.Drawing.Size(122, 82);
            this.buttonTenant.TabIndex = 1;
            this.buttonTenant.Text = "Add Tenant";
            this.buttonTenant.UseVisualStyleBackColor = true;
            this.buttonTenant.Click += new System.EventHandler(this.buttonTenant_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(15, 231);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 82);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxTenant);
            this.groupBox1.Controls.Add(this.buttonDefaults);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.buttonTenant);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 351);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tenant";
            // 
            // listBoxTenant
            // 
            this.listBoxTenant.FormattingEnabled = true;
            this.listBoxTenant.Location = new System.Drawing.Point(172, 36);
            this.listBoxTenant.Name = "listBoxTenant";
            this.listBoxTenant.Size = new System.Drawing.Size(371, 277);
            this.listBoxTenant.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Feagin Asg8 Defaults";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDefaults;
        private System.Windows.Forms.Button buttonTenant;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxTenant;
    }
}

