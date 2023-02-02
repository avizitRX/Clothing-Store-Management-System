namespace ClothingStoreManagementSystem
{
    partial class FormShopkeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShopkeeper));
            this.panelManagerNav = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnManagerSettings = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblShopkeeperNavRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblShopkeeperNavUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.uC_PlaceOrder1 = new ClothingStoreManagementSystem.AllUserControls.UC_PlaceOrder();
            this.uC_Settings1 = new ClothingStoreManagementSystem.AllUserControls.UC_Settings();
            this.panelManagerNav.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManagerNav
            // 
            this.panelManagerNav.BackColor = System.Drawing.SystemColors.Control;
            this.panelManagerNav.Controls.Add(this.guna2Button3);
            this.panelManagerNav.Controls.Add(this.btnLogout);
            this.panelManagerNav.Controls.Add(this.btnManagerSettings);
            this.panelManagerNav.Controls.Add(this.guna2Panel1);
            this.panelManagerNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelManagerNav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelManagerNav.Location = new System.Drawing.Point(0, 0);
            this.panelManagerNav.Name = "panelManagerNav";
            this.panelManagerNav.Size = new System.Drawing.Size(240, 611);
            this.panelManagerNav.TabIndex = 2;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.Checked = true;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(0, 170);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(240, 52);
            this.guna2Button3.TabIndex = 8;
            this.guna2Button3.Text = "Place Order";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 20;
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::ClothingStoreManagementSystem.Properties.Resources.icons8_logout_rounded_left_96;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(0, 282);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(240, 52);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManagerSettings
            // 
            this.btnManagerSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnManagerSettings.BorderRadius = 20;
            this.btnManagerSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManagerSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.btnManagerSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManagerSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManagerSettings.DisabledState.FillColor = System.Drawing.Color.DarkGray;
            this.btnManagerSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManagerSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnManagerSettings.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerSettings.ForeColor = System.Drawing.Color.White;
            this.btnManagerSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnManagerSettings.Image")));
            this.btnManagerSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManagerSettings.ImageSize = new System.Drawing.Size(40, 40);
            this.btnManagerSettings.Location = new System.Drawing.Point(0, 226);
            this.btnManagerSettings.Name = "btnManagerSettings";
            this.btnManagerSettings.Size = new System.Drawing.Size(240, 52);
            this.btnManagerSettings.TabIndex = 4;
            this.btnManagerSettings.Text = "Settings";
            this.btnManagerSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManagerSettings.Click += new System.EventHandler(this.btnManagerSettings_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(240, 168);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.lblShopkeeperNavRole);
            this.guna2Panel3.Controls.Add(this.lblShopkeeperNavUsername);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 104);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(240, 64);
            this.guna2Panel3.TabIndex = 5;
            // 
            // lblShopkeeperNavRole
            // 
            this.lblShopkeeperNavRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShopkeeperNavRole.BackColor = System.Drawing.Color.Transparent;
            this.lblShopkeeperNavRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopkeeperNavRole.ForeColor = System.Drawing.Color.White;
            this.lblShopkeeperNavRole.Location = new System.Drawing.Point(70, 32);
            this.lblShopkeeperNavRole.Name = "lblShopkeeperNavRole";
            this.lblShopkeeperNavRole.Size = new System.Drawing.Size(96, 23);
            this.lblShopkeeperNavRole.TabIndex = 4;
            this.lblShopkeeperNavRole.Text = "Shopkeeper";
            this.lblShopkeeperNavRole.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShopkeeperNavUsername
            // 
            this.lblShopkeeperNavUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShopkeeperNavUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblShopkeeperNavUsername.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopkeeperNavUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(112)))), ((int)(((byte)(200)))));
            this.lblShopkeeperNavUsername.Location = new System.Drawing.Point(73, 2);
            this.lblShopkeeperNavUsername.Name = "lblShopkeeperNavUsername";
            this.lblShopkeeperNavUsername.Size = new System.Drawing.Size(3, 2);
            this.lblShopkeeperNavUsername.TabIndex = 3;
            this.lblShopkeeperNavUsername.Text = null;
            this.lblShopkeeperNavUsername.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(240, 104);
            this.guna2Panel2.TabIndex = 3;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(75, 7);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(90, 90);
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(240, -1);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(944, 612);
            this.uC_PlaceOrder1.TabIndex = 3;
            // 
            // uC_Settings1
            // 
            this.uC_Settings1.Location = new System.Drawing.Point(240, 0);
            this.uC_Settings1.Name = "uC_Settings1";
            this.uC_Settings1.Size = new System.Drawing.Size(944, 611);
            this.uC_Settings1.TabIndex = 4;
            // 
            // FormShopkeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.uC_PlaceOrder1);
            this.Controls.Add(this.panelManagerNav);
            this.Controls.Add(this.uC_Settings1);
            this.MaximizeBox = false;
            this.Name = "FormShopkeeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopkeeper Control Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormShopkeeperClosed);
            this.Load += new System.EventHandler(this.FormShopkeeper_Load);
            this.panelManagerNav.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelManagerNav;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnManagerSettings;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShopkeeperNavRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShopkeeperNavUsername;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private AllUserControls.UC_Settings uC_Settings1;
    }
}