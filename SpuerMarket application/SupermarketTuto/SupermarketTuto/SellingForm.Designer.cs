namespace SupermarketTuto
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AmtLb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SellerNameLb = new System.Windows.Forms.Label();
            this.ProSellingDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SellingDate = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ProductDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.ProductEdit = new System.Windows.Forms.Button();
            this.ProductSave = new System.Windows.Forms.Button();
            this.ProPriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProQuaTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSellingDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.AmtLb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SellerNameLb);
            this.panel1.Controls.Add(this.ProSellingDGV);
            this.panel1.Controls.Add(this.SellingDate);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.ProductDGV);
            this.panel1.Controls.Add(this.ProductDelete);
            this.panel1.Controls.Add(this.ProductEdit);
            this.panel1.Controls.Add(this.ProductSave);
            this.panel1.Controls.Add(this.ProPriceTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProQuaTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BillIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(130, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 732);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(609, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 33);
            this.label6.TabIndex = 27;
            this.label6.Text = "SELEES LIST";
            // 
            // OrderDGV
            // 
            this.OrderDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.OrderDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDGV.ColumnHeadersHeight = 4;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.Location = new System.Drawing.Point(455, 96);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersVisible = false;
            this.OrderDGV.RowHeadersWidth = 51;
            this.OrderDGV.RowTemplate.Height = 24;
            this.OrderDGV.Size = new System.Drawing.Size(847, 167);
            this.OrderDGV.TabIndex = 26;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.OrderDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.OrderDGV.ThemeStyle.ReadOnly = false;
            this.OrderDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OrderDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderDGV.ThemeStyle.RowsStyle.Height = 24;
            this.OrderDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OrderDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.OrderDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDGV_CellContentClick);
            // 
            // AmtLb
            // 
            this.AmtLb.AutoSize = true;
            this.AmtLb.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmtLb.ForeColor = System.Drawing.Color.White;
            this.AmtLb.Location = new System.Drawing.Point(865, 281);
            this.AmtLb.Name = "AmtLb";
            this.AmtLb.Size = new System.Drawing.Size(60, 33);
            this.AmtLb.TabIndex = 25;
            this.AmtLb.Text = "Rs:";
            this.AmtLb.Click += new System.EventHandler(this.AmtLb_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(725, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 33);
            this.label7.TabIndex = 24;
            this.label7.Text = "Amount";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(93, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "ADD PRODUCT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SellerNameLb
            // 
            this.SellerNameLb.AutoSize = true;
            this.SellerNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerNameLb.ForeColor = System.Drawing.Color.White;
            this.SellerNameLb.Location = new System.Drawing.Point(36, 32);
            this.SellerNameLb.Name = "SellerNameLb";
            this.SellerNameLb.Size = new System.Drawing.Size(62, 22);
            this.SellerNameLb.TabIndex = 22;
            this.SellerNameLb.Text = "Seller";
            this.SellerNameLb.Click += new System.EventHandler(this.label7_Click);
            // 
            // ProSellingDGV
            // 
            this.ProSellingDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ProSellingDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProSellingDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ProSellingDGV.ColumnHeadersHeight = 4;
            this.ProSellingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProSellingDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProSellingDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProSellingDGV.Location = new System.Drawing.Point(24, 361);
            this.ProSellingDGV.Name = "ProSellingDGV";
            this.ProSellingDGV.RowHeadersVisible = false;
            this.ProSellingDGV.RowHeadersWidth = 51;
            this.ProSellingDGV.RowTemplate.Height = 24;
            this.ProSellingDGV.Size = new System.Drawing.Size(365, 357);
            this.ProSellingDGV.TabIndex = 21;
            this.ProSellingDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProSellingDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProSellingDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProSellingDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProSellingDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProSellingDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProSellingDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProSellingDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProSellingDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProSellingDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProSellingDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProSellingDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProSellingDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ProSellingDGV.ThemeStyle.ReadOnly = false;
            this.ProSellingDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProSellingDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProSellingDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProSellingDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProSellingDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ProSellingDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProSellingDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProSellingDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProSellingDGV_CellContentClick);
            // 
            // SellingDate
            // 
            this.SellingDate.AutoSize = true;
            this.SellingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellingDate.ForeColor = System.Drawing.Color.White;
            this.SellingDate.Location = new System.Drawing.Point(1233, 43);
            this.SellingDate.Name = "SellingDate";
            this.SellingDate.Size = new System.Drawing.Size(52, 22);
            this.SellingDate.TabIndex = 20;
            this.SellingDate.Text = "Date";
            this.SellingDate.Click += new System.EventHandler(this.SellingDate_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.DarkOrange;
            this.button9.Location = new System.Drawing.Point(264, 322);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 33);
            this.button9.TabIndex = 19;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox2.Location = new System.Drawing.Point(24, 322);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 33);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Select Category";
            // 
            // ProductDGV
            // 
            this.ProductDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ProductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProductDGV.ColumnHeadersHeight = 4;
            this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProductDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductDGV.Location = new System.Drawing.Point(438, 447);
            this.ProductDGV.Name = "ProductDGV";
            this.ProductDGV.RowHeadersVisible = false;
            this.ProductDGV.RowHeadersWidth = 51;
            this.ProductDGV.RowTemplate.Height = 24;
            this.ProductDGV.Size = new System.Drawing.Size(881, 165);
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
            this.ProductDelete.Location = new System.Drawing.Point(1012, 677);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(134, 41);
            this.ProductDelete.TabIndex = 16;
            this.ProductDelete.Text = "DELETE";
            this.ProductDelete.UseVisualStyleBackColor = false;
            // 
            // ProductEdit
            // 
            this.ProductEdit.BackColor = System.Drawing.Color.White;
            this.ProductEdit.FlatAppearance.BorderSize = 0;
            this.ProductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductEdit.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductEdit.ForeColor = System.Drawing.Color.DarkOrange;
            this.ProductEdit.Location = new System.Drawing.Point(853, 677);
            this.ProductEdit.Name = "ProductEdit";
            this.ProductEdit.Size = new System.Drawing.Size(99, 41);
            this.ProductEdit.TabIndex = 15;
            this.ProductEdit.Text = "PRINT";
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
            this.ProductSave.Location = new System.Drawing.Point(699, 677);
            this.ProductSave.Name = "ProductSave";
            this.ProductSave.Size = new System.Drawing.Size(99, 41);
            this.ProductSave.TabIndex = 5;
            this.ProductSave.Text = "ADD";
            this.ProductSave.UseVisualStyleBackColor = false;
            this.ProductSave.Click += new System.EventHandler(this.ProductSave_Click);
            // 
            // ProPriceTb
            // 
            this.ProPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProPriceTb.Enabled = false;
            this.ProPriceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPriceTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProPriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProPriceTb.HintText = "";
            this.ProPriceTb.isPassword = false;
            this.ProPriceTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProPriceTb.LineIdleColor = System.Drawing.Color.White;
            this.ProPriceTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProPriceTb.LineThickness = 3;
            this.ProPriceTb.Location = new System.Drawing.Point(148, 186);
            this.ProPriceTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProPriceTb.Name = "ProPriceTb";
            this.ProPriceTb.Size = new System.Drawing.Size(241, 34);
            this.ProPriceTb.TabIndex = 12;
            this.ProPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRICE";
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
            this.ProQuaTb.Location = new System.Drawing.Point(148, 229);
            this.ProQuaTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProQuaTb.Name = "ProQuaTb";
            this.ProQuaTb.Size = new System.Drawing.Size(241, 34);
            this.ProQuaTb.TabIndex = 10;
            this.ProQuaTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProQuaTb.OnValueChanged += new System.EventHandler(this.ProQuaTb_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUANTITY";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ProNameTb
            // 
            this.ProNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProNameTb.Enabled = false;
            this.ProNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.ProNameTb.HintText = "";
            this.ProNameTb.isPassword = false;
            this.ProNameTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.ProNameTb.LineIdleColor = System.Drawing.Color.White;
            this.ProNameTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.ProNameTb.LineThickness = 3;
            this.ProNameTb.Location = new System.Drawing.Point(148, 131);
            this.ProNameTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProNameTb.Name = "ProNameTb";
            this.ProNameTb.Size = new System.Drawing.Size(241, 34);
            this.ProNameTb.TabIndex = 8;
            this.ProNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "ProdNAme";
            // 
            // BillIdTb
            // 
            this.BillIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIdTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BillIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.BillIdTb.HintText = "";
            this.BillIdTb.isPassword = false;
            this.BillIdTb.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.BillIdTb.LineIdleColor = System.Drawing.Color.White;
            this.BillIdTb.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.BillIdTb.LineThickness = 3;
            this.BillIdTb.Location = new System.Drawing.Point(171, 83);
            this.BillIdTb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BillIdTb.Name = "BillIdTb";
            this.BillIdTb.Size = new System.Drawing.Size(241, 34);
            this.BillIdTb.TabIndex = 6;
            this.BillIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "BILLID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(620, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELLING";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(438, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(373, 41);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "ProId";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProSellingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox2;
        private Guna.UI2.WinForms.Guna2DataGridView ProductDGV;
        private System.Windows.Forms.Button ProductDelete;
        private System.Windows.Forms.Button ProductEdit;
        private System.Windows.Forms.Button ProductSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProPriceTb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProQuaTb;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProNameTb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillIdTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label SellingDate;
        private Guna.UI2.WinForms.Guna2DataGridView ProSellingDGV;
        private System.Windows.Forms.Label SellerNameLb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AmtLb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView OrderDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}