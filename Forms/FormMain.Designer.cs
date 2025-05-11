namespace Feagin_Asg10_SQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonAddTenant = new System.Windows.Forms.Button();
            this.buttonEditTenant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonTenantBoth = new System.Windows.Forms.RadioButton();
            this.radioButtonTenantDeleted = new System.Windows.Forms.RadioButton();
            this.radioButtonTenantActive = new System.Windows.Forms.RadioButton();
            this.listBoxTenant = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonPropertyBoth = new System.Windows.Forms.RadioButton();
            this.radioButtonPropertyDeleted = new System.Windows.Forms.RadioButton();
            this.radioButtonPropertyActive = new System.Windows.Forms.RadioButton();
            this.listBoxProperty = new System.Windows.Forms.ListBox();
            this.buttonEditProperty = new System.Windows.Forms.Button();
            this.buttonAddProperty = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonLeaseBoth = new System.Windows.Forms.RadioButton();
            this.radioButtonLeaseDeleted = new System.Windows.Forms.RadioButton();
            this.radioButtonLeaseActive = new System.Windows.Forms.RadioButton();
            this.listBoxLease = new System.Windows.Forms.ListBox();
            this.buttonEditLease = new System.Windows.Forms.Button();
            this.buttonAddLease = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddTenant
            // 
            this.buttonAddTenant.Location = new System.Drawing.Point(142, 367);
            this.buttonAddTenant.Name = "buttonAddTenant";
            this.buttonAddTenant.Size = new System.Drawing.Size(122, 44);
            this.buttonAddTenant.TabIndex = 1;
            this.buttonAddTenant.Text = "Add Tenant";
            this.buttonAddTenant.UseVisualStyleBackColor = true;
            this.buttonAddTenant.Click += new System.EventHandler(this.buttonAddTenant_Click);
            // 
            // buttonEditTenant
            // 
            this.buttonEditTenant.Location = new System.Drawing.Point(279, 367);
            this.buttonEditTenant.Name = "buttonEditTenant";
            this.buttonEditTenant.Size = new System.Drawing.Size(122, 44);
            this.buttonEditTenant.TabIndex = 2;
            this.buttonEditTenant.Text = "Edit Tenant";
            this.buttonEditTenant.UseVisualStyleBackColor = true;
            this.buttonEditTenant.Click += new System.EventHandler(this.buttonEditTenant_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTenantBoth);
            this.groupBox1.Controls.Add(this.radioButtonTenantDeleted);
            this.groupBox1.Controls.Add(this.radioButtonTenantActive);
            this.groupBox1.Controls.Add(this.listBoxTenant);
            this.groupBox1.Controls.Add(this.buttonEditTenant);
            this.groupBox1.Controls.Add(this.buttonAddTenant);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tenant";
            // 
            // radioButtonTenantBoth
            // 
            this.radioButtonTenantBoth.AutoSize = true;
            this.radioButtonTenantBoth.Location = new System.Drawing.Point(311, 34);
            this.radioButtonTenantBoth.Name = "radioButtonTenantBoth";
            this.radioButtonTenantBoth.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTenantBoth.TabIndex = 6;
            this.radioButtonTenantBoth.TabStop = true;
            this.radioButtonTenantBoth.Text = "Both";
            this.radioButtonTenantBoth.UseVisualStyleBackColor = true;
            this.radioButtonTenantBoth.Click += new System.EventHandler(this.radioButtonTenantBoth_Click);
            // 
            // radioButtonTenantDeleted
            // 
            this.radioButtonTenantDeleted.AutoSize = true;
            this.radioButtonTenantDeleted.Location = new System.Drawing.Point(217, 34);
            this.radioButtonTenantDeleted.Name = "radioButtonTenantDeleted";
            this.radioButtonTenantDeleted.Size = new System.Drawing.Size(62, 17);
            this.radioButtonTenantDeleted.TabIndex = 5;
            this.radioButtonTenantDeleted.TabStop = true;
            this.radioButtonTenantDeleted.Text = "Deleted";
            this.radioButtonTenantDeleted.UseVisualStyleBackColor = true;
            this.radioButtonTenantDeleted.Click += new System.EventHandler(this.radioButtonTenantDeleted_Click);
            // 
            // radioButtonTenantActive
            // 
            this.radioButtonTenantActive.AutoSize = true;
            this.radioButtonTenantActive.Location = new System.Drawing.Point(131, 34);
            this.radioButtonTenantActive.Name = "radioButtonTenantActive";
            this.radioButtonTenantActive.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTenantActive.TabIndex = 4;
            this.radioButtonTenantActive.TabStop = true;
            this.radioButtonTenantActive.Text = "Active";
            this.radioButtonTenantActive.UseVisualStyleBackColor = true;
            this.radioButtonTenantActive.Click += new System.EventHandler(this.radioButtonTenantActive_Click);
            // 
            // listBoxTenant
            // 
            this.listBoxTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTenant.FormattingEnabled = true;
            this.listBoxTenant.ItemHeight = 16;
            this.listBoxTenant.Location = new System.Drawing.Point(6, 83);
            this.listBoxTenant.Name = "listBoxTenant";
            this.listBoxTenant.Size = new System.Drawing.Size(549, 276);
            this.listBoxTenant.TabIndex = 3;
            this.listBoxTenant.DoubleClick += new System.EventHandler(this.listBoxTenant_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPropertyBoth);
            this.groupBox2.Controls.Add(this.radioButtonPropertyDeleted);
            this.groupBox2.Controls.Add(this.radioButtonPropertyActive);
            this.groupBox2.Controls.Add(this.listBoxProperty);
            this.groupBox2.Controls.Add(this.buttonEditProperty);
            this.groupBox2.Controls.Add(this.buttonAddProperty);
            this.groupBox2.Location = new System.Drawing.Point(579, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 426);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property";
            // 
            // radioButtonPropertyBoth
            // 
            this.radioButtonPropertyBoth.AutoSize = true;
            this.radioButtonPropertyBoth.Location = new System.Drawing.Point(292, 34);
            this.radioButtonPropertyBoth.Name = "radioButtonPropertyBoth";
            this.radioButtonPropertyBoth.Size = new System.Drawing.Size(47, 17);
            this.radioButtonPropertyBoth.TabIndex = 9;
            this.radioButtonPropertyBoth.TabStop = true;
            this.radioButtonPropertyBoth.Text = "Both";
            this.radioButtonPropertyBoth.UseVisualStyleBackColor = true;
            this.radioButtonPropertyBoth.Click += new System.EventHandler(this.radioButtonPropertyBoth_Click);
            // 
            // radioButtonPropertyDeleted
            // 
            this.radioButtonPropertyDeleted.AutoSize = true;
            this.radioButtonPropertyDeleted.Location = new System.Drawing.Point(198, 34);
            this.radioButtonPropertyDeleted.Name = "radioButtonPropertyDeleted";
            this.radioButtonPropertyDeleted.Size = new System.Drawing.Size(62, 17);
            this.radioButtonPropertyDeleted.TabIndex = 8;
            this.radioButtonPropertyDeleted.TabStop = true;
            this.radioButtonPropertyDeleted.Text = "Deleted";
            this.radioButtonPropertyDeleted.UseVisualStyleBackColor = true;
            this.radioButtonPropertyDeleted.Click += new System.EventHandler(this.radioButtonPropertyDeleted_Click);
            // 
            // radioButtonPropertyActive
            // 
            this.radioButtonPropertyActive.AutoSize = true;
            this.radioButtonPropertyActive.Location = new System.Drawing.Point(112, 34);
            this.radioButtonPropertyActive.Name = "radioButtonPropertyActive";
            this.radioButtonPropertyActive.Size = new System.Drawing.Size(55, 17);
            this.radioButtonPropertyActive.TabIndex = 7;
            this.radioButtonPropertyActive.TabStop = true;
            this.radioButtonPropertyActive.Text = "Active";
            this.radioButtonPropertyActive.UseVisualStyleBackColor = true;
            this.radioButtonPropertyActive.Click += new System.EventHandler(this.radioButtonPropertyActive_Click);
            // 
            // listBoxProperty
            // 
            this.listBoxProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProperty.FormattingEnabled = true;
            this.listBoxProperty.ItemHeight = 16;
            this.listBoxProperty.Location = new System.Drawing.Point(6, 83);
            this.listBoxProperty.Name = "listBoxProperty";
            this.listBoxProperty.Size = new System.Drawing.Size(467, 276);
            this.listBoxProperty.TabIndex = 3;
            this.listBoxProperty.DoubleClick += new System.EventHandler(this.listBoxProperty_DoubleClick);
            // 
            // buttonEditProperty
            // 
            this.buttonEditProperty.Location = new System.Drawing.Point(249, 367);
            this.buttonEditProperty.Name = "buttonEditProperty";
            this.buttonEditProperty.Size = new System.Drawing.Size(122, 44);
            this.buttonEditProperty.TabIndex = 2;
            this.buttonEditProperty.Text = "Edit Property";
            this.buttonEditProperty.UseVisualStyleBackColor = true;
            this.buttonEditProperty.Click += new System.EventHandler(this.buttonEditProperty_Click);
            // 
            // buttonAddProperty
            // 
            this.buttonAddProperty.Location = new System.Drawing.Point(112, 367);
            this.buttonAddProperty.Name = "buttonAddProperty";
            this.buttonAddProperty.Size = new System.Drawing.Size(122, 44);
            this.buttonAddProperty.TabIndex = 1;
            this.buttonAddProperty.Text = "Add Property";
            this.buttonAddProperty.UseVisualStyleBackColor = true;
            this.buttonAddProperty.Click += new System.EventHandler(this.buttonAddProperty_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonLeaseBoth);
            this.groupBox3.Controls.Add(this.radioButtonLeaseDeleted);
            this.groupBox3.Controls.Add(this.radioButtonLeaseActive);
            this.groupBox3.Controls.Add(this.listBoxLease);
            this.groupBox3.Controls.Add(this.buttonEditLease);
            this.groupBox3.Controls.Add(this.buttonAddLease);
            this.groupBox3.Location = new System.Drawing.Point(1064, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 426);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lease";
            // 
            // radioButtonLeaseBoth
            // 
            this.radioButtonLeaseBoth.AutoSize = true;
            this.radioButtonLeaseBoth.Location = new System.Drawing.Point(289, 34);
            this.radioButtonLeaseBoth.Name = "radioButtonLeaseBoth";
            this.radioButtonLeaseBoth.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLeaseBoth.TabIndex = 9;
            this.radioButtonLeaseBoth.TabStop = true;
            this.radioButtonLeaseBoth.Text = "Both";
            this.radioButtonLeaseBoth.UseVisualStyleBackColor = true;
            this.radioButtonLeaseBoth.Click += new System.EventHandler(this.radioButtonLeaseBoth_Click);
            // 
            // radioButtonLeaseDeleted
            // 
            this.radioButtonLeaseDeleted.AutoSize = true;
            this.radioButtonLeaseDeleted.Location = new System.Drawing.Point(195, 34);
            this.radioButtonLeaseDeleted.Name = "radioButtonLeaseDeleted";
            this.radioButtonLeaseDeleted.Size = new System.Drawing.Size(62, 17);
            this.radioButtonLeaseDeleted.TabIndex = 8;
            this.radioButtonLeaseDeleted.TabStop = true;
            this.radioButtonLeaseDeleted.Text = "Deleted";
            this.radioButtonLeaseDeleted.UseVisualStyleBackColor = true;
            this.radioButtonLeaseDeleted.Click += new System.EventHandler(this.radioButtonLeaseDeleted_Click);
            // 
            // radioButtonLeaseActive
            // 
            this.radioButtonLeaseActive.AutoSize = true;
            this.radioButtonLeaseActive.Location = new System.Drawing.Point(109, 34);
            this.radioButtonLeaseActive.Name = "radioButtonLeaseActive";
            this.radioButtonLeaseActive.Size = new System.Drawing.Size(55, 17);
            this.radioButtonLeaseActive.TabIndex = 7;
            this.radioButtonLeaseActive.TabStop = true;
            this.radioButtonLeaseActive.Text = "Active";
            this.radioButtonLeaseActive.UseVisualStyleBackColor = true;
            this.radioButtonLeaseActive.Click += new System.EventHandler(this.radioButtonLeaseActive_Click);
            // 
            // listBoxLease
            // 
            this.listBoxLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLease.FormattingEnabled = true;
            this.listBoxLease.ItemHeight = 16;
            this.listBoxLease.Location = new System.Drawing.Point(6, 83);
            this.listBoxLease.Name = "listBoxLease";
            this.listBoxLease.Size = new System.Drawing.Size(434, 276);
            this.listBoxLease.TabIndex = 3;
            this.listBoxLease.DoubleClick += new System.EventHandler(this.listBoxLease_DoubleClick);
            // 
            // buttonEditLease
            // 
            this.buttonEditLease.Location = new System.Drawing.Point(243, 367);
            this.buttonEditLease.Name = "buttonEditLease";
            this.buttonEditLease.Size = new System.Drawing.Size(122, 44);
            this.buttonEditLease.TabIndex = 2;
            this.buttonEditLease.Text = "Edit Lease";
            this.buttonEditLease.UseVisualStyleBackColor = true;
            this.buttonEditLease.Click += new System.EventHandler(this.buttonEditLease_Click);
            // 
            // buttonAddLease
            // 
            this.buttonAddLease.Location = new System.Drawing.Point(106, 367);
            this.buttonAddLease.Name = "buttonAddLease";
            this.buttonAddLease.Size = new System.Drawing.Size(122, 44);
            this.buttonAddLease.TabIndex = 1;
            this.buttonAddLease.Text = "Add Lease";
            this.buttonAddLease.UseVisualStyleBackColor = true;
            this.buttonAddLease.Click += new System.EventHandler(this.buttonAddLease_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1522, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.defaultsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // defaultsToolStripMenuItem
            // 
            this.defaultsToolStripMenuItem.Name = "defaultsToolStripMenuItem";
            this.defaultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultsToolStripMenuItem.Text = "Defaults";
            this.defaultsToolStripMenuItem.Click += new System.EventHandler(this.defaultsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feagin Asg11 SLR";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddTenant;
        private System.Windows.Forms.Button buttonEditTenant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxTenant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxProperty;
        private System.Windows.Forms.Button buttonEditProperty;
        private System.Windows.Forms.Button buttonAddProperty;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxLease;
        private System.Windows.Forms.Button buttonEditLease;
        private System.Windows.Forms.Button buttonAddLease;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonTenantBoth;
        private System.Windows.Forms.RadioButton radioButtonTenantDeleted;
        private System.Windows.Forms.RadioButton radioButtonTenantActive;
        private System.Windows.Forms.RadioButton radioButtonPropertyBoth;
        private System.Windows.Forms.RadioButton radioButtonPropertyDeleted;
        private System.Windows.Forms.RadioButton radioButtonPropertyActive;
        private System.Windows.Forms.RadioButton radioButtonLeaseBoth;
        private System.Windows.Forms.RadioButton radioButtonLeaseDeleted;
        private System.Windows.Forms.RadioButton radioButtonLeaseActive;
    }
}

