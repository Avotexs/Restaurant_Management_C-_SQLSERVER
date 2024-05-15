namespace RM.Model
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeach = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDin = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnHold = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnTake = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnKot = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnBill = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnNew = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.lblTotal);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 577);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1135, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(859, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(966, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 32);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "00.00";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2TileButton1);
            this.guna2Panel2.Controls.Add(this.btnDin);
            this.guna2Panel2.Controls.Add(this.btnHold);
            this.guna2Panel2.Controls.Add(this.btnTake);
            this.guna2Panel2.Controls.Add(this.btnDelivery);
            this.guna2Panel2.Controls.Add(this.btnKot);
            this.guna2Panel2.Controls.Add(this.btnBill);
            this.guna2Panel2.Controls.Add(this.btnNew);
            this.guna2Panel2.Controls.Add(this.lblWaiter);
            this.guna2Panel2.Controls.Add(this.lblTable);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1135, 100);
            this.guna2Panel2.TabIndex = 0;
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiter.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWaiter.Location = new System.Drawing.Point(820, 59);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(77, 21);
            this.lblWaiter.TabIndex = 1;
            this.lblWaiter.Text = "Waiter";
            this.lblWaiter.Visible = false;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BackColor = System.Drawing.Color.Transparent;
            this.lblTable.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTable.Location = new System.Drawing.Point(820, 24);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(61, 21);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Table";
            this.lblTable.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(94, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Location = new System.Drawing.Point(147, 165);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(499, 406);
            this.ProductPanel.TabIndex = 1;
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.Location = new System.Drawing.Point(12, 165);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(129, 406);
            this.CategoryPanel.TabIndex = 1;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(96)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(652, 165);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(471, 406);
            this.guna2DataGridView1.TabIndex = 7;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridView1_CellFormatting);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 40F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 40;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 40;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 50;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 60F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 60;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // txtSeach
            // 
            this.txtSeach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeach.DefaultText = "";
            this.txtSeach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSeach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeach.IconLeft = global::RM.Properties.Resources.icons8_search_96;
            this.txtSeach.Location = new System.Drawing.Point(144, 123);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.PasswordChar = '\0';
            this.txtSeach.PlaceholderText = "Seach Here";
            this.txtSeach.SelectedText = "";
            this.txtSeach.Size = new System.Drawing.Size(285, 36);
            this.txtSeach.TabIndex = 2;
            this.txtSeach.TextChanged += new System.EventHandler(this.txtSeach_TextChanged);
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.guna2TileButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.guna2TileButton1.BorderRadius = 10;
            this.guna2TileButton1.BorderThickness = 2;
            this.guna2TileButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2TileButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.guna2TileButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Image = global::RM.Properties.Resources.icons8_take_away_food_50;
            this.guna2TileButton1.Location = new System.Drawing.Point(652, 12);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(78, 78);
            this.guna2TileButton1.TabIndex = 2;
            this.guna2TileButton1.Text = "Take Away";
            this.guna2TileButton1.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnDin
            // 
            this.btnDin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnDin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnDin.BorderRadius = 10;
            this.btnDin.BorderThickness = 2;
            this.btnDin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnDin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnDin.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDin.ForeColor = System.Drawing.Color.White;
            this.btnDin.Image = global::RM.Properties.Resources.icons8_restaurant_table_100__1_2;
            this.btnDin.Location = new System.Drawing.Point(736, 12);
            this.btnDin.Name = "btnDin";
            this.btnDin.Size = new System.Drawing.Size(78, 78);
            this.btnDin.TabIndex = 2;
            this.btnDin.Text = "Din in";
            this.btnDin.Click += new System.EventHandler(this.btnDin_Click);
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnHold.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnHold.BorderRadius = 10;
            this.btnHold.BorderThickness = 2;
            this.btnHold.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnHold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnHold.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.Image = global::RM.Properties.Resources.icons8_hold_32;
            this.btnHold.Location = new System.Drawing.Point(316, 12);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(78, 78);
            this.btnHold.TabIndex = 2;
            this.btnHold.Text = "Hold";
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnTake.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnTake.BorderRadius = 10;
            this.btnTake.BorderThickness = 2;
            this.btnTake.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTake.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnTake.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTake.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTake.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTake.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTake.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnTake.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTake.ForeColor = System.Drawing.Color.White;
            this.btnTake.Image = global::RM.Properties.Resources.icons8_take_away_food_50;
            this.btnTake.Location = new System.Drawing.Point(652, 12);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(78, 78);
            this.btnTake.TabIndex = 2;
            this.btnTake.Text = "Take Away";
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnDelivery.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnDelivery.BorderRadius = 10;
            this.btnDelivery.BorderThickness = 2;
            this.btnDelivery.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDelivery.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Image = global::RM.Properties.Resources.icons8_delivery_50;
            this.btnDelivery.Location = new System.Drawing.Point(568, 12);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(78, 78);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnKot
            // 
            this.btnKot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnKot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnKot.BorderRadius = 10;
            this.btnKot.BorderThickness = 2;
            this.btnKot.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnKot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnKot.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKot.ForeColor = System.Drawing.Color.White;
            this.btnKot.Image = global::RM.Properties.Resources.icons8_chef_hat_96__1_1;
            this.btnKot.Location = new System.Drawing.Point(484, 12);
            this.btnKot.Name = "btnKot";
            this.btnKot.Size = new System.Drawing.Size(78, 78);
            this.btnKot.TabIndex = 2;
            this.btnKot.Text = "Kot";
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnBill.BorderRadius = 10;
            this.btnBill.BorderThickness = 2;
            this.btnBill.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = global::RM.Properties.Resources.icons8_bill_100;
            this.btnBill.Location = new System.Drawing.Point(400, 12);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(78, 78);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Bill List";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnNew.BorderRadius = 10;
            this.btnNew.BorderThickness = 2;
            this.btnNew.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(130)))), ((int)(((byte)(119)))));
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(62)))), ((int)(((byte)(83)))));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::RM.Properties.Resources.icons8_add_properties_26;
            this.btnNew.Location = new System.Drawing.Point(232, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 78);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::RM.Properties.Resources.icons8_shutdown_50__1_;
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(1046, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 53);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::RM.Properties.Resources.eat;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(76, 78);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1135, 677);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSeach);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton btnNew;
        private Guna.UI2.WinForms.Guna2TileButton btnHold;
        private Guna.UI2.WinForms.Guna2TileButton btnTake;
        private Guna.UI2.WinForms.Guna2TileButton btnDelivery;
        private Guna.UI2.WinForms.Guna2TileButton btnKot;
        private Guna.UI2.WinForms.Guna2TileButton btnBill;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTable;
        private Guna.UI2.WinForms.Guna2PictureBox btnExit;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        public System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtSeach;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TileButton btnDin;
    }
}