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
            this.buttonAddTenant = new System.Windows.Forms.Button();
            this.buttonEditTenant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxTenant = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxProperty = new System.Windows.Forms.ListBox();
            this.buttonEditProperty = new System.Windows.Forms.Button();
            this.buttonAddProperty = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.buttonAddTenant.Location = new System.Drawing.Point(6, 319);
            this.buttonAddTenant.Name = "buttonAddTenant";
            this.buttonAddTenant.Size = new System.Drawing.Size(122, 44);
            this.buttonAddTenant.TabIndex = 1;
            this.buttonAddTenant.Text = "Add Tenant";
            this.buttonAddTenant.UseVisualStyleBackColor = true;
            this.buttonAddTenant.Click += new System.EventHandler(this.buttonAddTenant_Click);
            // 
            // buttonEditTenant
            // 
            this.buttonEditTenant.Location = new System.Drawing.Point(143, 319);
            this.buttonEditTenant.Name = "buttonEditTenant";
            this.buttonEditTenant.Size = new System.Drawing.Size(122, 44);
            this.buttonEditTenant.TabIndex = 2;
            this.buttonEditTenant.Text = "Edit Tenant";
            this.buttonEditTenant.UseVisualStyleBackColor = true;
            this.buttonEditTenant.Click += new System.EventHandler(this.buttonEditTenant_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxTenant);
            this.groupBox1.Controls.Add(this.buttonEditTenant);
            this.groupBox1.Controls.Add(this.buttonAddTenant);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 371);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tenant";
            // 
            // listBoxTenant
            // 
            this.listBoxTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTenant.FormattingEnabled = true;
            this.listBoxTenant.ItemHeight = 16;
            this.listBoxTenant.Location = new System.Drawing.Point(6, 19);
            this.listBoxTenant.Name = "listBoxTenant";
            this.listBoxTenant.Size = new System.Drawing.Size(353, 276);
            this.listBoxTenant.TabIndex = 3;
            this.listBoxTenant.DoubleClick += new System.EventHandler(this.listBoxTenant_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxProperty);
            this.groupBox2.Controls.Add(this.buttonEditProperty);
            this.groupBox2.Controls.Add(this.buttonAddProperty);
            this.groupBox2.Location = new System.Drawing.Point(387, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 371);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Property";
            // 
            // listBoxProperty
            // 
            this.listBoxProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProperty.FormattingEnabled = true;
            this.listBoxProperty.ItemHeight = 16;
            this.listBoxProperty.Location = new System.Drawing.Point(6, 19);
            this.listBoxProperty.Name = "listBoxProperty";
            this.listBoxProperty.Size = new System.Drawing.Size(353, 276);
            this.listBoxProperty.TabIndex = 3;
            this.listBoxProperty.DoubleClick += new System.EventHandler(this.listBoxProperty_DoubleClick);
            // 
            // buttonEditProperty
            // 
            this.buttonEditProperty.Location = new System.Drawing.Point(143, 319);
            this.buttonEditProperty.Name = "buttonEditProperty";
            this.buttonEditProperty.Size = new System.Drawing.Size(122, 44);
            this.buttonEditProperty.TabIndex = 2;
            this.buttonEditProperty.Text = "Edit Property";
            this.buttonEditProperty.UseVisualStyleBackColor = true;
            this.buttonEditProperty.Click += new System.EventHandler(this.buttonEditProperty_Click);
            // 
            // buttonAddProperty
            // 
            this.buttonAddProperty.Location = new System.Drawing.Point(6, 319);
            this.buttonAddProperty.Name = "buttonAddProperty";
            this.buttonAddProperty.Size = new System.Drawing.Size(122, 44);
            this.buttonAddProperty.TabIndex = 1;
            this.buttonAddProperty.Text = "Add Property";
            this.buttonAddProperty.UseVisualStyleBackColor = true;
            this.buttonAddProperty.Click += new System.EventHandler(this.buttonAddProperty_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxLease);
            this.groupBox3.Controls.Add(this.buttonEditLease);
            this.groupBox3.Controls.Add(this.buttonAddLease);
            this.groupBox3.Location = new System.Drawing.Point(762, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 371);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lease";
            // 
            // listBoxLease
            // 
            this.listBoxLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLease.FormattingEnabled = true;
            this.listBoxLease.ItemHeight = 16;
            this.listBoxLease.Location = new System.Drawing.Point(6, 19);
            this.listBoxLease.Name = "listBoxLease";
            this.listBoxLease.Size = new System.Drawing.Size(353, 276);
            this.listBoxLease.TabIndex = 3;
            this.listBoxLease.DoubleClick += new System.EventHandler(this.listBoxLease_DoubleClick);
            // 
            // buttonEditLease
            // 
            this.buttonEditLease.Location = new System.Drawing.Point(143, 319);
            this.buttonEditLease.Name = "buttonEditLease";
            this.buttonEditLease.Size = new System.Drawing.Size(122, 44);
            this.buttonEditLease.TabIndex = 2;
            this.buttonEditLease.Text = "Edit Lease";
            this.buttonEditLease.UseVisualStyleBackColor = true;
            this.buttonEditLease.Click += new System.EventHandler(this.buttonEditLease_Click);
            // 
            // buttonAddLease
            // 
            this.buttonAddLease.Location = new System.Drawing.Point(6, 319);
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
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // defaultsToolStripMenuItem
            // 
            this.defaultsToolStripMenuItem.Name = "defaultsToolStripMenuItem";
            this.defaultsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.defaultsToolStripMenuItem.Text = "Defaults";
            this.defaultsToolStripMenuItem.Click += new System.EventHandler(this.defaultsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feagin Asg9 SLR";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
    }
}

