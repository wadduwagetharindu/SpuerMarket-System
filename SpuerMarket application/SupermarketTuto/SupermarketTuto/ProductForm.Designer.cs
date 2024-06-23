namespace SupermarketTuto
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ProductDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.ProductEdit = new System.Windows.Forms.Button();
            this.ProductSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProPriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProQuaTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.ProductDGV);
            this.panel1.Controls.Add(this.ProductDelete);
            this.panel1.Controls.Add(this.ProductEdit);
            this.panel1.Controls.Add(this.ProductSave);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProPriceTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProQuaTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(130, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 708);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.DarkOrange;
            this.button9.Location = new System.Drawing.Point(999, 124);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 33);
            this.button9.TabIndex = 19;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.RefreshTb);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox2.Location = new System.Drawing.Point(752, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(241, 33);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Select Category";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // ProductDGV
            // 
            this.ProductDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductDGV.ColumnHeadersHeight = 4;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.Location = new System.Drawing.Point(444, 163);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersVisible = false;
            this.ProductDGV.RowHeadersWidth = 51;
            this.ProductDGV.RowTemplate.Height = 24;
            this.ProductDGV.Size = new System.Drawing.Size(879, 532);
            this.ProductDGV.TabIndex = 17;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ProductDGV.ThemeStyle.ReadOnly = false;
            this.ProductDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ProductDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDGV_CellContentClick);
            // 
            // ProductDelete
            // 
            this.ProductDelete.BackColor = System.Drawing.Color.White;
            this.ProductDelete.FlatAppearance.BorderSize = 0;
            this.ProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.ProductDelete.Location = new System.Drawing.Point(275, 461);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(134, 41);
            this.ProductDelete.TabIndex = 16;
            this.ProductDelete.Text = "DELETE";
            this.ProductDelete.UseVisualStyleBackColor = false;
            this.ProductDelete.Click += new System.EventHandler(this.ProductDelete_Click);
            // 
            // ProductEdit
            // 
            this.ProductEdit.BackColor = System.Drawing.Color.White;
            this.ProductEdit.FlatAppearance.BorderSize = 0;
            this.ProductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductEdit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductEdit.ForeColor = System.Drawing.Color.DarkOrange;
            this.ProductEdit.Location = new System.Drawing.Point(148, 461);
            this.ProductEdit.Name = "ProductEdit";
            this.ProductEdit.Size = new System.Drawing.Size(99, 41);
            this.ProductEdit.TabIndex = 15;
            this.ProductEdit.Text = "EDIT";
            this.ProductEdit.UseVisualStyleBackColor = false;
            this.ProductEdit.Click += new System.EventHandler(this.ProductEdit_Click);
            // 
            // ProductSave
            // 
            this.ProductSave.BackColor = System.Drawing.Color.White;
            this.ProductSave.FlatAppearance.BorderSize = 0;
            this.ProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductSave.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSave.ForeColor = System.Drawing.Color.DarkOrange;
            this.ProductSave.Location = new System.Drawing.Point(24, 461);
            this.ProductSave.Name = "ProductSave";
            this.ProductSave.Size = new System.Drawing.Size(99, 41);
            this.ProductSave.TabIndex = 5;
            this.ProductSave.Text = "ADD";
            this.ProductSave.UseVisualStyleBackColor = false;
            this.ProductSave.Click += new System.EventHandler(this.ProductSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox1.Location = new System.Drawing.Point(148, 358);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 33);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "CATEGORY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProPriceTb
            // 
            this.ProPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProPriceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPriceTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProPriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProPriceTb.HintText = "";
            this.ProPriceTb.isPassword = false;
            this.ProPriceTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProPriceTb.LineIdleColor = System.Drawing.Color.White;
            this.ProPriceTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProPriceTb.LineThickness = 3;
            this.ProPriceTb.Location = new System.Drawing.Point(148, 297);
            this.ProPriceTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProPriceTb.Name = "ProPriceTb";
            this.ProPriceTb.Size = new System.Drawing.Size(241, 34);
            this.ProPriceTb.TabIndex = 12;
            this.ProPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProPriceTb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRICE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProQuaTb
            // 
            this.ProQuaTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProQuaTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProQuaTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProQuaTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProQuaTb.HintText = "";
            this.ProQuaTb.isPassword = false;
            this.ProQuaTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProQuaTb.LineIdleColor = System.Drawing.Color.White;
            this.ProQuaTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProQuaTb.LineThickness = 3;
            this.ProQuaTb.Location = new System.Drawing.Point(148, 243);
            this.ProQuaTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProQuaTb.Name = "ProQuaTb";
            this.ProQuaTb.Size = new System.Drawing.Size(241, 34);
            this.ProQuaTb.TabIndex = 10;
            this.ProQuaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUANTITY";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProNameTb
            // 
            this.ProNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProNameTb.HintText = "";
            this.ProNameTb.isPassword = false;
            this.ProNameTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProNameTb.LineIdleColor = System.Drawing.Color.White;
            this.ProNameTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProNameTb.LineThickness = 3;
            this.ProNameTb.Location = new System.Drawing.Point(148, 186);
            this.ProNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProNameTb.Name = "ProNameTb";
            this.ProNameTb.Size = new System.Drawing.Size(241, 34);
            this.ProNameTb.TabIndex = 8;
            this.ProNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProNameTb.OnValueChanged += new System.EventHandler(this.ProName_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ProIdTb
            // 
            this.ProIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProIdTb.HintText = "";
            this.ProIdTb.isPassword = false;
            this.ProIdTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProIdTb.LineIdleColor = System.Drawing.Color.White;
            this.ProIdTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProIdTb.LineThickness = 3;
            this.ProIdTb.Location = new System.Drawing.Point(148, 128);
            this.ProIdTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProIdTb.Name = "ProIdTb";
            this.ProIdTb.Size = new System.Drawing.Size(241, 34);
            this.ProIdTb.TabIndex = 6;
            this.ProIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(579, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAGAGE PRODUCTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(3, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(-6, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Category";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(3, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Selling";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button5.TabIndex = 4;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProIdTb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProPriceTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProQuaTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProductDelete;
        private System.Windows.Forms.Button ProductEdit;
        private System.Windows.Forms.Button ProductSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDGV;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}