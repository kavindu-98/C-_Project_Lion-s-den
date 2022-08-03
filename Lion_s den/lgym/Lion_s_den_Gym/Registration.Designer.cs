
namespace gym
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.select_combox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mem_reg1 = new Lion_s_den_Gym.mem_reg();
            this.co_reg1 = new Lion_s_den_Gym.co_reg();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(947, 452);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(705, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // select_combox
            // 
            this.select_combox.AutoCompleteCustomSource.AddRange(new string[] {
            "Member"});
            this.select_combox.AutoRoundedCorners = true;
            this.select_combox.BackColor = System.Drawing.Color.Transparent;
            this.select_combox.BorderRadius = 17;
            this.select_combox.BorderThickness = 0;
            this.select_combox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_combox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.select_combox.DropDownHeight = 70;
            this.select_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_combox.FillColor = System.Drawing.Color.Silver;
            this.select_combox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.select_combox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.select_combox.FocusedState.Parent = this.select_combox;
            this.select_combox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.select_combox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.select_combox.HoverState.BorderColor = System.Drawing.Color.Black;
            this.select_combox.HoverState.Parent = this.select_combox;
            this.select_combox.IntegralHeight = false;
            this.select_combox.ItemHeight = 30;
            this.select_combox.Items.AddRange(new object[] {
            "Member",
            "Coach"});
            this.select_combox.ItemsAppearance.Parent = this.select_combox;
            this.select_combox.Location = new System.Drawing.Point(316, 19);
            this.select_combox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.select_combox.MaxDropDownItems = 5;
            this.select_combox.Name = "select_combox";
            this.select_combox.ShadowDecoration.Parent = this.select_combox;
            this.select_combox.Size = new System.Drawing.Size(208, 36);
            this.select_combox.StartIndex = 0;
            this.select_combox.TabIndex = 0;
            this.select_combox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.select_combox.SelectedIndexChanged += new System.EventHandler(this.select_combox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(1140, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 53);
            this.label2.TabIndex = 21;
            this.label2.Text = "Registration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(576, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = ".";
            // 
            // mem_reg1
            // 
            this.mem_reg1.BackColor = System.Drawing.Color.White;
            this.mem_reg1.Location = new System.Drawing.Point(0, 100);
            this.mem_reg1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mem_reg1.Name = "mem_reg1";
            this.mem_reg1.Size = new System.Drawing.Size(994, 775);
            this.mem_reg1.TabIndex = 2;
            this.mem_reg1.Load += new System.EventHandler(this.mem_reg1_Load);
            // 
            // co_reg1
            // 
            this.co_reg1.Location = new System.Drawing.Point(0, 100);
            this.co_reg1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.co_reg1.Name = "co_reg1";
            this.co_reg1.Size = new System.Drawing.Size(994, 775);
            this.co_reg1.TabIndex = 1;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mem_reg1);
            this.Controls.Add(this.co_reg1);
            this.Controls.Add(this.select_combox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registration";
            this.Size = new System.Drawing.Size(1598, 879);
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox select_combox;
        private Lion_s_den_Gym.co_reg co_reg1;
        private Lion_s_den_Gym.mem_reg mem_reg1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
