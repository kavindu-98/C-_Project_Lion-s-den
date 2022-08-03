
namespace gym
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            this.select_combox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bill_payments1 = new Lion_s_den_Gym.Bill_payments();
            this.sup_payments1 = new Lion_s_den_Gym.Sup_payments();
            this.mem_fee1 = new Lion_s_den_Gym.Mem_fee();
            this.coach_payments1 = new Lion_s_den_Gym.Coach_payments();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // select_combox
            // 
            this.select_combox.AutoCompleteCustomSource.AddRange(new string[] {
            "Member"});
            this.select_combox.AutoRoundedCorners = true;
            this.select_combox.BackColor = System.Drawing.Color.Transparent;
            this.select_combox.BorderColor = System.Drawing.Color.Black;
            this.select_combox.BorderRadius = 17;
            this.select_combox.BorderThickness = 0;
            this.select_combox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_combox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.select_combox.DropDownHeight = 140;
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
            "Member Fee",
            "Bills",
            "Coaches Fee",
            "Supplyment Payments"});
            this.select_combox.ItemsAppearance.Parent = this.select_combox;
            this.select_combox.Location = new System.Drawing.Point(148, 26);
            this.select_combox.Margin = new System.Windows.Forms.Padding(4);
            this.select_combox.MaxDropDownItems = 5;
            this.select_combox.Name = "select_combox";
            this.select_combox.ShadowDecoration.Parent = this.select_combox;
            this.select_combox.Size = new System.Drawing.Size(271, 36);
            this.select_combox.StartIndex = 0;
            this.select_combox.TabIndex = 0;
            this.select_combox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.select_combox.SelectedIndexChanged += new System.EventHandler(this.select_combox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(583, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Payments";
            // 
            // bill_payments1
            // 
            this.bill_payments1.BackColor = System.Drawing.Color.White;
            this.bill_payments1.Location = new System.Drawing.Point(3, 86);
            this.bill_payments1.Name = "bill_payments1";
            this.bill_payments1.Size = new System.Drawing.Size(1414, 617);
            this.bill_payments1.TabIndex = 23;
            // 
            // sup_payments1
            // 
            this.sup_payments1.BackColor = System.Drawing.Color.White;
            this.sup_payments1.Location = new System.Drawing.Point(3, 86);
            this.sup_payments1.Name = "sup_payments1";
            this.sup_payments1.Size = new System.Drawing.Size(1414, 617);
            this.sup_payments1.TabIndex = 22;
            // 
            // mem_fee1
            // 
            this.mem_fee1.BackColor = System.Drawing.Color.White;
            this.mem_fee1.Location = new System.Drawing.Point(6, 86);
            this.mem_fee1.Name = "mem_fee1";
            this.mem_fee1.Size = new System.Drawing.Size(1414, 617);
            this.mem_fee1.TabIndex = 2;
            // 
            // coach_payments1
            // 
            this.coach_payments1.BackColor = System.Drawing.Color.White;
            this.coach_payments1.Location = new System.Drawing.Point(3, 86);
            this.coach_payments1.Name = "coach_payments1";
            this.coach_payments1.Size = new System.Drawing.Size(1414, 617);
            this.coach_payments1.TabIndex = 24;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.coach_payments1);
            this.Controls.Add(this.bill_payments1);
            this.Controls.Add(this.sup_payments1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mem_fee1);
            this.Controls.Add(this.select_combox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1420, 703);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox select_combox;
        private Lion_s_den_Gym.Mem_fee mem_fee1;
        private System.Windows.Forms.Label label2;
        private Lion_s_den_Gym.Sup_payments sup_payments1;
        private Lion_s_den_Gym.Bill_payments bill_payments1;
        private Lion_s_den_Gym.Coach_payments coach_payments1;
        private System.Windows.Forms.Timer timer1;
    }
}
