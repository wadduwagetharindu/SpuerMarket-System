namespace SupermarketTuto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.UNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UPasswordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LSelect = new System.Windows.Forms.ComboBox();
            this.Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Clear = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-117, -23);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(383, 500);
            this.guna2CircleButton1.TabIndex = 0;
            // 
            // UNameTb
            // 
            this.UNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.UNameTb.HintText = "";
            this.UNameTb.isPassword = false;
            this.UNameTb.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.UNameTb.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.UNameTb.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.UNameTb.LineThickness = 3;
            this.UNameTb.Location = new System.Drawing.Point(433, 195);
            this.UNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.Size = new System.Drawing.Size(277, 43);
            this.UNameTb.TabIndex = 1;
            this.UNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UNameTb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // UPasswordTb
            // 
            this.UPasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UPasswordTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UPasswordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UPasswordTb.HintForeColor = System.Drawing.Color.Empty;
            this.UPasswordTb.HintText = "";
            this.UPasswordTb.isPassword = false;
            this.UPasswordTb.LineFocusedColor = System.Drawing.Color.OrangeRed;
            this.UPasswordTb.LineIdleColor = System.Drawing.Color.DarkOrange;
            this.UPasswordTb.LineMouseHoverColor = System.Drawing.Color.OrangeRed;
            this.UPasswordTb.LineThickness = 3;
            this.UPasswordTb.Location = new System.Drawing.Point(433, 274);
            this.UPasswordTb.Margin = new System.Windows.Forms.Padding(4);
            this.UPasswordTb.Name = "UPasswordTb";
            this.UPasswordTb.Size = new System.Drawing.Size(277, 43);
            this.UPasswordTb.TabIndex = 2;
            this.UPasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(504, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(272, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "USERNAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(272, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD";
            // 
            // LSelect
            // 
            this.LSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSelect.ForeColor = System.Drawing.Color.DarkOrange;
            this.LSelect.FormattingEnabled = true;
            this.LSelect.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.LSelect.Location = new System.Drawing.Point(433, 136);
            this.LSelect.Name = "LSelect";
            this.LSelect.Size = new System.Drawing.Size(241, 33);
            this.LSelect.TabIndex = 6;
            this.LSelect.Text = "Select Role";
            this.LSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Login
            // 
            this.Login.ActiveBorderThickness = 1;
            this.Login.ActiveCornerRadius = 20;
            this.Login.ActiveFillColor = System.Drawing.Color.OrangeRed;
            this.Login.ActiveForecolor = System.Drawing.Color.White;
            this.Login.ActiveLineColor = System.Drawing.Color.OrangeRed;
            this.Login.BackColor = System.Drawing.SystemColors.Control;
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.ButtonText = "LOGIN";
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.DarkOrange;
            this.Login.IdleBorderThickness = 1;
            this.Login.IdleCornerRadius = 20;
            this.Login.IdleFillColor = System.Drawing.Color.DarkOrange;
            this.Login.IdleForecolor = System.Drawing.Color.White;
            this.Login.IdleLineColor = System.Drawing.Color.SeaShell;
            this.Login.Location = new System.Drawing.Point(433, 340);
            this.Login.Margin = new System.Windows.Forms.Padding(5);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(235, 51);
            this.Login.TabIndex = 7;
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.DarkOrange;
            this.Clear.Location = new System.Drawing.Point(506, 410);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(63, 23);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "WELCOME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrange;
            this.label6.Font = new System.Drawing.Font("Arial", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "SUPERMARKET";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "APPLICATION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(675, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 35);
            this.label8.TabIndex = 12;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 454);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LSelect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UPasswordTb);
            this.Controls.Add(this.UNameTb);
            this.Controls.Add(this.guna2CircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UPasswordTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LSelect;
        private Bunifu.Framework.UI.BunifuThinButton2 Login;
        private System.Windows.Forms.Label Clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

