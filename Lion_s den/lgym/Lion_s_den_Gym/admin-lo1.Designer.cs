
namespace Lion_s_den_Gym
{
    partial class admin_lo1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_lo1));
            this.forgot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ad_log_btn = new Guna.UI2.WinForms.Guna2Button();
            this.ad_log_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.ad_log_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forgot
            // 
            this.forgot.BackColor = System.Drawing.Color.Transparent;
            this.forgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot.FlatAppearance.BorderSize = 0;
            this.forgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgot.ForeColor = System.Drawing.Color.RoyalBlue;
            this.forgot.Location = new System.Drawing.Point(134, 262);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(158, 32);
            this.forgot.TabIndex = 3;
            this.forgot.Text = "Forgot Password?";
            this.forgot.UseVisualStyleBackColor = false;
            this.forgot.Click += new System.EventHandler(this.forgot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(129, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Admin Login";
            // 
            // ad_log_btn
            // 
            this.ad_log_btn.BorderRadius = 20;
            this.ad_log_btn.CheckedState.Parent = this.ad_log_btn;
            this.ad_log_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ad_log_btn.CustomImages.Parent = this.ad_log_btn;
            this.ad_log_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ad_log_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_log_btn.ForeColor = System.Drawing.Color.White;
            this.ad_log_btn.HoverState.Parent = this.ad_log_btn;
            this.ad_log_btn.Location = new System.Drawing.Point(107, 324);
            this.ad_log_btn.Name = "ad_log_btn";
            this.ad_log_btn.ShadowDecoration.Parent = this.ad_log_btn;
            this.ad_log_btn.Size = new System.Drawing.Size(202, 46);
            this.ad_log_btn.TabIndex = 4;
            this.ad_log_btn.Text = "Login";
            this.ad_log_btn.Click += new System.EventHandler(this.ad_log_btn_Click);
            // 
            // ad_log_password
            // 
            this.ad_log_password.BorderRadius = 20;
            this.ad_log_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ad_log_password.DefaultText = "";
            this.ad_log_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ad_log_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ad_log_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ad_log_password.DisabledState.Parent = this.ad_log_password;
            this.ad_log_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ad_log_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ad_log_password.FocusedState.Parent = this.ad_log_password;
            this.ad_log_password.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_log_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ad_log_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ad_log_password.HoverState.Parent = this.ad_log_password;
            this.ad_log_password.IconRight = ((System.Drawing.Image)(resources.GetObject("ad_log_password.IconRight")));
            this.ad_log_password.IconRightOffset = new System.Drawing.Point(10, 0);
            this.ad_log_password.Location = new System.Drawing.Point(84, 177);
            this.ad_log_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ad_log_password.Name = "ad_log_password";
            this.ad_log_password.PasswordChar = '*';
            this.ad_log_password.PlaceholderText = "Password";
            this.ad_log_password.SelectedText = "";
            this.ad_log_password.ShadowDecoration.Parent = this.ad_log_password;
            this.ad_log_password.Size = new System.Drawing.Size(249, 48);
            this.ad_log_password.TabIndex = 1;
            this.ad_log_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ad_log_password.TextChanged += new System.EventHandler(this.ad_log_password_TextChanged);
            // 
            // ad_log_username
            // 
            this.ad_log_username.BorderRadius = 20;
            this.ad_log_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ad_log_username.DefaultText = "";
            this.ad_log_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ad_log_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ad_log_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ad_log_username.DisabledState.Parent = this.ad_log_username;
            this.ad_log_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ad_log_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ad_log_username.FocusedState.Parent = this.ad_log_username;
            this.ad_log_username.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ad_log_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ad_log_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.ad_log_username.HoverState.Parent = this.ad_log_username;
            this.ad_log_username.IconRight = ((System.Drawing.Image)(resources.GetObject("ad_log_username.IconRight")));
            this.ad_log_username.IconRightOffset = new System.Drawing.Point(10, 0);
            this.ad_log_username.Location = new System.Drawing.Point(84, 88);
            this.ad_log_username.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ad_log_username.Name = "ad_log_username";
            this.ad_log_username.PasswordChar = '\0';
            this.ad_log_username.PlaceholderText = "User Name";
            this.ad_log_username.SelectedText = "";
            this.ad_log_username.ShadowDecoration.Parent = this.ad_log_username;
            this.ad_log_username.Size = new System.Drawing.Size(249, 48);
            this.ad_log_username.TabIndex = 0;
            this.ad_log_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ad_log_username.TextChanged += new System.EventHandler(this.ad_log_username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(104, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = ".";
            // 
            // admin_lo1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ad_log_btn);
            this.Controls.Add(this.ad_log_password);
            this.Controls.Add(this.ad_log_username);
            this.Name = "admin_lo1";
            this.Size = new System.Drawing.Size(437, 490);
            this.Load += new System.EventHandler(this.admin_lo1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button forgot;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button ad_log_btn;
        private Guna.UI2.WinForms.Guna2TextBox ad_log_password;
        private Guna.UI2.WinForms.Guna2TextBox ad_log_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
