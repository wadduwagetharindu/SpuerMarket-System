namespace SupermarketTuto
{
    partial class SellerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellerPassTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SellerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SellerDeleteBtn = new System.Windows.Forms.Button();
            this.SellerEditBtn = new System.Windows.Forms.Button();
            this.SellerAddBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SellerPhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.SellerAgeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.SellerNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.SellerIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.SellerPassTb);
            this.panel1.Controls.Add(this.SellerDGV);
            this.panel1.Controls.Add(this.SellerDeleteBtn);
            this.panel1.Controls.Add(this.SellerEditBtn);
            this.panel1.Controls.Add(this.SellerAddBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SellerPhoneTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.SellerAgeTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SellerNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SellerIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(130, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 708);
            this.panel1.TabIndex = 1;
            // 
            // SellerPassTb
            // 
            this.SellerPassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerPassTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerPassTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerPassTb.HintForeColor = System.Drawing.Color.Empty;
            this.SellerPassTb.HintText = "";
            this.SellerPassTb.isPassword = false;
            this.SellerPassTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerPassTb.LineIdleColor = System.Drawing.Color.White;
            this.SellerPassTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerPassTb.LineThickness = 3;
            this.SellerPassTb.Location = new System.Drawing.Point(148, 358);
            this.SellerPassTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerPassTb.Name = "SellerPassTb";
            this.SellerPassTb.Size = new System.Drawing.Size(241, 34);
            this.SellerPassTb.TabIndex = 20;
            this.SellerPassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SellerDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.SellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.SellerDGV.ColumnHeadersHeight = 4;
            this.SellerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.SellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.Location = new System.Drawing.Point(444, 163);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.RowHeadersVisible = false;
            this.SellerDGV.RowHeadersWidth = 51;
            this.SellerDGV.RowTemplate.Height = 24;
            this.SellerDGV.Size = new System.Drawing.Size(879, 532);
            this.SellerDGV.TabIndex = 17;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellerDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.SellerDGV.ThemeStyle.ReadOnly = false;
            this.SellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.ThemeStyle.RowsStyle.Height = 24;
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // SellerDeleteBtn
            // 
            this.SellerDeleteBtn.BackColor = System.Drawing.Color.White;
            this.SellerDeleteBtn.FlatAppearance.BorderSize = 0;
            this.SellerDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerDeleteBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerDeleteBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.SellerDeleteBtn.Location = new System.Drawing.Point(275, 461);
            this.SellerDeleteBtn.Name = "SellerDeleteBtn";
            this.SellerDeleteBtn.Size = new System.Drawing.Size(114, 41);
            this.SellerDeleteBtn.TabIndex = 16;
            this.SellerDeleteBtn.Text = "DELETE";
            this.SellerDeleteBtn.UseVisualStyleBackColor = false;
            this.SellerDeleteBtn.Click += new System.EventHandler(this.SellerDeleteBtn_Click);
            // 
            // SellerEditBtn
            // 
            this.SellerEditBtn.BackColor = System.Drawing.Color.White;
            this.SellerEditBtn.FlatAppearance.BorderSize = 0;
            this.SellerEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerEditBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerEditBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.SellerEditBtn.Location = new System.Drawing.Point(148, 461);
            this.SellerEditBtn.Name = "SellerEditBtn";
            this.SellerEditBtn.Size = new System.Drawing.Size(99, 41);
            this.SellerEditBtn.TabIndex = 15;
            this.SellerEditBtn.Text = "EDIT";
            this.SellerEditBtn.UseVisualStyleBackColor = false;
            this.SellerEditBtn.Click += new System.EventHandler(this.SellerEditBtn_Click);
            // 
            // SellerAddBtn
            // 
            this.SellerAddBtn.BackColor = System.Drawing.Color.White;
            this.SellerAddBtn.FlatAppearance.BorderSize = 0;
            this.SellerAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellerAddBtn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerAddBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.SellerAddBtn.Location = new System.Drawing.Point(24, 461);
            this.SellerAddBtn.Name = "SellerAddBtn";
            this.SellerAddBtn.Size = new System.Drawing.Size(99, 41);
            this.SellerAddBtn.TabIndex = 5;
            this.SellerAddBtn.Text = "ADD";
            this.SellerAddBtn.UseVisualStyleBackColor = false;
            this.SellerAddBtn.Click += new System.EventHandler(this.SellerAddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "PASSWORD";
            // 
            // SellerPhoneTb
            // 
            this.SellerPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerPhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerPhoneTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerPhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.SellerPhoneTb.HintText = "";
            this.SellerPhoneTb.isPassword = false;
            this.SellerPhoneTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerPhoneTb.LineIdleColor = System.Drawing.Color.White;
            this.SellerPhoneTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerPhoneTb.LineThickness = 3;
            this.SellerPhoneTb.Location = new System.Drawing.Point(148, 297);
            this.SellerPhoneTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerPhoneTb.Name = "SellerPhoneTb";
            this.SellerPhoneTb.Size = new System.Drawing.Size(241, 34);
            this.SellerPhoneTb.TabIndex = 12;
            this.SellerPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "PHONE";
            // 
            // SellerAgeTb
            // 
            this.SellerAgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerAgeTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerAgeTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerAgeTb.HintForeColor = System.Drawing.Color.Empty;
            this.SellerAgeTb.HintText = "";
            this.SellerAgeTb.isPassword = false;
            this.SellerAgeTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerAgeTb.LineIdleColor = System.Drawing.Color.White;
            this.SellerAgeTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerAgeTb.LineThickness = 3;
            this.SellerAgeTb.Location = new System.Drawing.Point(148, 243);
            this.SellerAgeTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerAgeTb.Name = "SellerAgeTb";
            this.SellerAgeTb.Size = new System.Drawing.Size(241, 34);
            this.SellerAgeTb.TabIndex = 10;
            this.SellerAgeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "AGE";
            // 
            // SellerNameTb
            // 
            this.SellerNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.SellerNameTb.HintText = "";
            this.SellerNameTb.isPassword = false;
            this.SellerNameTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerNameTb.LineIdleColor = System.Drawing.Color.White;
            this.SellerNameTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerNameTb.LineThickness = 3;
            this.SellerNameTb.Location = new System.Drawing.Point(148, 186);
            this.SellerNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerNameTb.Name = "SellerNameTb";
            this.SellerNameTb.Size = new System.Drawing.Size(241, 34);
            this.SellerNameTb.TabIndex = 8;
            this.SellerNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "NAME";
            // 
            // SellerIdTb
            // 
            this.SellerIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.SellerIdTb.HintText = "";
            this.SellerIdTb.isPassword = false;
            this.SellerIdTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerIdTb.LineIdleColor = System.Drawing.Color.White;
            this.SellerIdTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerIdTb.LineThickness = 3;
            this.SellerIdTb.Location = new System.Drawing.Point(148, 128);
            this.SellerIdTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerIdTb.Name = "SellerIdTb";
            this.SellerIdTb.Size = new System.Drawing.Size(241, 34);
            this.SellerIdTb.TabIndex = 6;
            this.SellerIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(579, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAGAGE SELLERS";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(551, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(373, 41);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkOrange;
            this.button5.Location = new System.Drawing.Point(1414, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 46);
            this.button5.TabIndex = 20;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(12, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 41);
            this.button3.TabIndex = 23;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(-1, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "Category";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(-1, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView SellerDGV;
        private System.Windows.Forms.Button SellerDeleteBtn;
        private System.Windows.Forms.Button SellerEditBtn;
        private System.Windows.Forms.Button SellerAddBtn;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerPhoneTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerAgeTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerNameTb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerIdTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerPassTb;
    }
}