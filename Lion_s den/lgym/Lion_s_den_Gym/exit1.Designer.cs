
namespace Lion_s_den_Gym
{
    partial class exit1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exit1));
            this.exit_no = new Guna.UI2.WinForms.Guna2Button();
            this.exit_yes = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_no
            // 
            this.exit_no.BackColor = System.Drawing.Color.Transparent;
            this.exit_no.BorderColor = System.Drawing.Color.Transparent;
            this.exit_no.BorderRadius = 15;
            this.exit_no.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.exit_no.CheckedState.Parent = this.exit_no;
            this.exit_no.CustomImages.Parent = this.exit_no;
            this.exit_no.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.exit_no.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_no.ForeColor = System.Drawing.Color.White;
            this.exit_no.HoverState.FillColor = System.Drawing.Color.DarkTurquoise;
            this.exit_no.HoverState.Parent = this.exit_no;
            this.exit_no.Location = new System.Drawing.Point(279, 85);
            this.exit_no.Name = "exit_no";
            this.exit_no.ShadowDecoration.Parent = this.exit_no;
            this.exit_no.Size = new System.Drawing.Size(151, 45);
            this.exit_no.TabIndex = 4;
            this.exit_no.Text = "NO";
            this.exit_no.UseTransparentBackground = true;
            this.exit_no.Click += new System.EventHandler(this.exit_no_Click);
            // 
            // exit_yes
            // 
            this.exit_yes.BackColor = System.Drawing.Color.Transparent;
            this.exit_yes.BorderColor = System.Drawing.Color.Transparent;
            this.exit_yes.BorderRadius = 15;
            this.exit_yes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.exit_yes.CheckedState.Parent = this.exit_yes;
            this.exit_yes.CustomImages.Parent = this.exit_yes;
            this.exit_yes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.exit_yes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.exit_yes.ForeColor = System.Drawing.Color.White;
            this.exit_yes.HoverState.FillColor = System.Drawing.Color.Salmon;
            this.exit_yes.HoverState.Parent = this.exit_yes;
            this.exit_yes.Location = new System.Drawing.Point(26, 85);
            this.exit_yes.Name = "exit_yes";
            this.exit_yes.ShadowDecoration.Parent = this.exit_yes;
            this.exit_yes.Size = new System.Drawing.Size(151, 45);
            this.exit_yes.TabIndex = 3;
            this.exit_yes.Text = "YES";
            this.exit_yes.UseTransparentBackground = true;
            this.exit_yes.Click += new System.EventHandler(this.exit_yes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Do you want to exit ?";
            // 
            // exit1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(466, 168);
            this.Controls.Add(this.exit_no);
            this.Controls.Add(this.exit_yes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "exit1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exit1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button exit_no;
        private Guna.UI2.WinForms.Guna2Button exit_yes;
        private System.Windows.Forms.Label label1;
    }
}