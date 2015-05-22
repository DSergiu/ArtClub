namespace GUI
{
    partial class ArtClubApp
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
            this.login_panel = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.login_email = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_main = new System.Windows.Forms.TabControl();
            this.tab_members = new System.Windows.Forms.TabPage();
            this.member_tb_employee_no = new System.Windows.Forms.NumericUpDown();
            this.member_cb_gender = new System.Windows.Forms.ComboBox();
            this.member_iscancelled_checkbox = new System.Windows.Forms.CheckBox();
            this.member_btn_clear = new System.Windows.Forms.Button();
            this.member_btn_add = new System.Windows.Forms.Button();
            this.member_grid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_employeeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_isBoard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_cancelled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.m_createAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_isboard_checkbox = new System.Windows.Forms.CheckBox();
            this.member_tb_phone = new System.Windows.Forms.TextBox();
            this.member_tb_email = new System.Windows.Forms.TextBox();
            this.member_tb_name = new System.Windows.Forms.TextBox();
            this.member_tb_createAt = new System.Windows.Forms.TextBox();
            this.member_tb_points = new System.Windows.Forms.TextBox();
            this.member_tb_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.member_btn_update = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.artitem_pb_image = new System.Windows.Forms.PictureBox();
            this.artitem_btn_uploadimg = new System.Windows.Forms.Button();
            this.artitem_rtb_description = new System.Windows.Forms.RichTextBox();
            this.artitem_tb_minimumBid = new System.Windows.Forms.TextBox();
            this.artitem_btn_clear = new System.Windows.Forms.Button();
            this.artitem_btn_add = new System.Windows.Forms.Button();
            this.artitem_grid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_minimumBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artitem_tb_purchasePrice = new System.Windows.Forms.TextBox();
            this.artitem_tb_artist = new System.Windows.Forms.TextBox();
            this.artitem_tb_name = new System.Windows.Forms.TextBox();
            this.artitem_tb_createAt = new System.Windows.Forms.TextBox();
            this.artitem_tb_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.artitem_btn_update = new System.Windows.Forms.Button();
            this.lbl_errors = new System.Windows.Forms.Label();
            this.loggedin_lbl = new System.Windows.Forms.Label();
            this.login_panel.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.tab_members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_tb_employee_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_grid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artitem_pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artitem_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_panel.Controls.Add(this.btn_login);
            this.login_panel.Controls.Add(this.lbl_pass);
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Controls.Add(this.login_pass);
            this.login_panel.Controls.Add(this.login_email);
            this.login_panel.Location = new System.Drawing.Point(2, 1);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(851, 441);
            this.login_panel.TabIndex = 5;
            this.login_panel.Visible = false;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(516, 252);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(301, 214);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(78, 20);
            this.lbl_pass.TabIndex = 8;
            this.lbl_pass.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // login_pass
            // 
            this.login_pass.Location = new System.Drawing.Point(385, 214);
            this.login_pass.Name = "login_pass";
            this.login_pass.PasswordChar = '*';
            this.login_pass.Size = new System.Drawing.Size(206, 20);
            this.login_pass.TabIndex = 6;
            this.login_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_pass_KeyDown);
            // 
            // login_email
            // 
            this.login_email.Location = new System.Drawing.Point(385, 180);
            this.login_email.Name = "login_email";
            this.login_email.Size = new System.Drawing.Size(206, 20);
            this.login_email.TabIndex = 5;
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Controls.Add(this.tab_members);
            this.panel_main.Controls.Add(this.tabPage1);
            this.panel_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_main.Location = new System.Drawing.Point(2, 4);
            this.panel_main.Name = "panel_main";
            this.panel_main.SelectedIndex = 0;
            this.panel_main.Size = new System.Drawing.Size(851, 438);
            this.panel_main.TabIndex = 0;
            this.panel_main.SelectedIndexChanged += new System.EventHandler(this.panel_main_SelectedIndexChanged);
            // 
            // tab_members
            // 
            this.tab_members.Controls.Add(this.member_tb_employee_no);
            this.tab_members.Controls.Add(this.member_cb_gender);
            this.tab_members.Controls.Add(this.member_iscancelled_checkbox);
            this.tab_members.Controls.Add(this.member_btn_clear);
            this.tab_members.Controls.Add(this.member_btn_add);
            this.tab_members.Controls.Add(this.member_grid);
            this.tab_members.Controls.Add(this.member_isboard_checkbox);
            this.tab_members.Controls.Add(this.member_tb_phone);
            this.tab_members.Controls.Add(this.member_tb_email);
            this.tab_members.Controls.Add(this.member_tb_name);
            this.tab_members.Controls.Add(this.member_tb_createAt);
            this.tab_members.Controls.Add(this.member_tb_points);
            this.tab_members.Controls.Add(this.member_tb_id);
            this.tab_members.Controls.Add(this.label6);
            this.tab_members.Controls.Add(this.label7);
            this.tab_members.Controls.Add(this.label8);
            this.tab_members.Controls.Add(this.label9);
            this.tab_members.Controls.Add(this.label10);
            this.tab_members.Controls.Add(this.label3);
            this.tab_members.Controls.Add(this.label5);
            this.tab_members.Controls.Add(this.label4);
            this.tab_members.Controls.Add(this.Name);
            this.tab_members.Controls.Add(this.label2);
            this.tab_members.Controls.Add(this.member_btn_update);
            this.tab_members.Location = new System.Drawing.Point(4, 29);
            this.tab_members.Name = "tab_members";
            this.tab_members.Padding = new System.Windows.Forms.Padding(3);
            this.tab_members.Size = new System.Drawing.Size(843, 405);
            this.tab_members.TabIndex = 0;
            this.tab_members.Text = "Members";
            this.tab_members.UseVisualStyleBackColor = true;
            // 
            // member_tb_employee_no
            // 
            this.member_tb_employee_no.Location = new System.Drawing.Point(462, 21);
            this.member_tb_employee_no.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.member_tb_employee_no.Name = "member_tb_employee_no";
            this.member_tb_employee_no.Size = new System.Drawing.Size(140, 26);
            this.member_tb_employee_no.TabIndex = 0;
            // 
            // member_cb_gender
            // 
            this.member_cb_gender.FormattingEnabled = true;
            this.member_cb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.member_cb_gender.Location = new System.Drawing.Point(125, 164);
            this.member_cb_gender.Name = "member_cb_gender";
            this.member_cb_gender.Size = new System.Drawing.Size(121, 28);
            this.member_cb_gender.TabIndex = 27;
            // 
            // member_iscancelled_checkbox
            // 
            this.member_iscancelled_checkbox.AutoSize = true;
            this.member_iscancelled_checkbox.Location = new System.Drawing.Point(462, 129);
            this.member_iscancelled_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.member_iscancelled_checkbox.Name = "member_iscancelled_checkbox";
            this.member_iscancelled_checkbox.Size = new System.Drawing.Size(15, 14);
            this.member_iscancelled_checkbox.TabIndex = 26;
            this.member_iscancelled_checkbox.UseVisualStyleBackColor = true;
            // 
            // member_btn_clear
            // 
            this.member_btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_btn_clear.Location = new System.Drawing.Point(616, 135);
            this.member_btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.member_btn_clear.Name = "member_btn_clear";
            this.member_btn_clear.Size = new System.Drawing.Size(115, 28);
            this.member_btn_clear.TabIndex = 25;
            this.member_btn_clear.Text = "Clear";
            this.member_btn_clear.UseVisualStyleBackColor = true;
            this.member_btn_clear.Click += new System.EventHandler(this.member_btn_clear_Click);
            // 
            // member_btn_add
            // 
            this.member_btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_btn_add.Location = new System.Drawing.Point(616, 88);
            this.member_btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.member_btn_add.Name = "member_btn_add";
            this.member_btn_add.Size = new System.Drawing.Size(115, 28);
            this.member_btn_add.TabIndex = 23;
            this.member_btn_add.Text = "Add";
            this.member_btn_add.UseVisualStyleBackColor = true;
            this.member_btn_add.Click += new System.EventHandler(this.member_btn_add_Click);
            // 
            // member_grid
            // 
            this.member_grid.AllowUserToAddRows = false;
            this.member_grid.AllowUserToOrderColumns = true;
            this.member_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.member_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.member_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.member_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.m_Name,
            this.m_email,
            this.m_phone,
            this.m_gender,
            this.m_employeeNo,
            this.m_points,
            this.m_isBoard,
            this.m_cancelled,
            this.m_createAt});
            this.member_grid.Location = new System.Drawing.Point(2, 220);
            this.member_grid.Margin = new System.Windows.Forms.Padding(2);
            this.member_grid.MultiSelect = false;
            this.member_grid.Name = "member_grid";
            this.member_grid.ReadOnly = true;
            this.member_grid.RowTemplate.Height = 33;
            this.member_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.member_grid.Size = new System.Drawing.Size(839, 193);
            this.member_grid.TabIndex = 22;
            this.member_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.member_grid_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // m_Name
            // 
            this.m_Name.HeaderText = "Name";
            this.m_Name.Name = "m_Name";
            this.m_Name.ReadOnly = true;
            // 
            // m_email
            // 
            this.m_email.HeaderText = "Email";
            this.m_email.Name = "m_email";
            this.m_email.ReadOnly = true;
            // 
            // m_phone
            // 
            this.m_phone.HeaderText = "Phone";
            this.m_phone.Name = "m_phone";
            this.m_phone.ReadOnly = true;
            // 
            // m_gender
            // 
            this.m_gender.HeaderText = "Gender";
            this.m_gender.Name = "m_gender";
            this.m_gender.ReadOnly = true;
            // 
            // m_employeeNo
            // 
            this.m_employeeNo.HeaderText = "Employee number";
            this.m_employeeNo.Name = "m_employeeNo";
            this.m_employeeNo.ReadOnly = true;
            // 
            // m_points
            // 
            this.m_points.HeaderText = "Points";
            this.m_points.Name = "m_points";
            this.m_points.ReadOnly = true;
            // 
            // m_isBoard
            // 
            this.m_isBoard.HeaderText = "Board ";
            this.m_isBoard.Name = "m_isBoard";
            this.m_isBoard.ReadOnly = true;
            // 
            // m_cancelled
            // 
            this.m_cancelled.HeaderText = "Cancelled";
            this.m_cancelled.Name = "m_cancelled";
            this.m_cancelled.ReadOnly = true;
            // 
            // m_createAt
            // 
            this.m_createAt.HeaderText = "Create at";
            this.m_createAt.Name = "m_createAt";
            this.m_createAt.ReadOnly = true;
            // 
            // member_isboard_checkbox
            // 
            this.member_isboard_checkbox.AutoSize = true;
            this.member_isboard_checkbox.Location = new System.Drawing.Point(462, 159);
            this.member_isboard_checkbox.Margin = new System.Windows.Forms.Padding(2);
            this.member_isboard_checkbox.Name = "member_isboard_checkbox";
            this.member_isboard_checkbox.Size = new System.Drawing.Size(15, 14);
            this.member_isboard_checkbox.TabIndex = 21;
            this.member_isboard_checkbox.UseVisualStyleBackColor = true;
            // 
            // member_tb_phone
            // 
            this.member_tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_tb_phone.Location = new System.Drawing.Point(125, 128);
            this.member_tb_phone.Margin = new System.Windows.Forms.Padding(2);
            this.member_tb_phone.Name = "member_tb_phone";
            this.member_tb_phone.Size = new System.Drawing.Size(140, 26);
            this.member_tb_phone.TabIndex = 16;
            // 
            // member_tb_email
            // 
            this.member_tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_tb_email.Location = new System.Drawing.Point(125, 94);
            this.member_tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.member_tb_email.Name = "member_tb_email";
            this.member_tb_email.Size = new System.Drawing.Size(140, 26);
            this.member_tb_email.TabIndex = 15;
            // 
            // member_tb_name
            // 
            this.member_tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_tb_name.Location = new System.Drawing.Point(125, 61);
            this.member_tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.member_tb_name.Name = "member_tb_name";
            this.member_tb_name.Size = new System.Drawing.Size(140, 26);
            this.member_tb_name.TabIndex = 14;
            // 
            // member_tb_createAt
            // 
            this.member_tb_createAt.Enabled = false;
            this.member_tb_createAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_tb_createAt.Location = new System.Drawing.Point(462, 55);
            this.member_tb_createAt.Margin = new System.Windows.Forms.Padding(2);
            this.member_tb_createAt.Name = "member_tb_createAt";
            this.member_tb_createAt.Size = new System.Drawing.Size(140, 26);
            this.member_tb_createAt.TabIndex = 13;
            // 
            // member_tb_points
            // 
            this.member_tb_points.Enabled = false;
            this.member_tb_points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_tb_points.Location = new System.Drawing.Point(462, 88);
            this.member_tb_points.Margin = new System.Windows.Forms.Padding(2);
            this.member_tb_points.Name = "member_tb_points";
            this.member_tb_points.Size = new System.Drawing.Size(140, 26);
            this.member_tb_points.TabIndex = 12;
            // 
            // member_tb_id
            // 
            this.member_tb_id.Enabled = false;
            this.member_tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_tb_id.Location = new System.Drawing.Point(125, 26);
            this.member_tb_id.Margin = new System.Windows.Forms.Padding(2);
            this.member_tb_id.Name = "member_tb_id";
            this.member_tb_id.Size = new System.Drawing.Size(140, 26);
            this.member_tb_id.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Created at";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Membership Canceled";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Points";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(335, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Is board member";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(327, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Employee number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email ";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(57, 61);
            this.Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 17);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // member_btn_update
            // 
            this.member_btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_btn_update.Location = new System.Drawing.Point(616, 88);
            this.member_btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.member_btn_update.Name = "member_btn_update";
            this.member_btn_update.Size = new System.Drawing.Size(115, 28);
            this.member_btn_update.TabIndex = 24;
            this.member_btn_update.Text = "Update";
            this.member_btn_update.UseVisualStyleBackColor = true;
            this.member_btn_update.Click += new System.EventHandler(this.member_btn_update_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.artitem_pb_image);
            this.tabPage1.Controls.Add(this.artitem_btn_uploadimg);
            this.tabPage1.Controls.Add(this.artitem_rtb_description);
            this.tabPage1.Controls.Add(this.artitem_tb_minimumBid);
            this.tabPage1.Controls.Add(this.artitem_btn_clear);
            this.tabPage1.Controls.Add(this.artitem_btn_add);
            this.tabPage1.Controls.Add(this.artitem_grid);
            this.tabPage1.Controls.Add(this.artitem_tb_purchasePrice);
            this.tabPage1.Controls.Add(this.artitem_tb_artist);
            this.tabPage1.Controls.Add(this.artitem_tb_name);
            this.tabPage1.Controls.Add(this.artitem_tb_createAt);
            this.tabPage1.Controls.Add(this.artitem_tb_id);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.artitem_btn_update);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 405);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Art items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // artitem_pb_image
            // 
            this.artitem_pb_image.Image = global::GUI.Properties.Resources._default;
            this.artitem_pb_image.InitialImage = global::GUI.Properties.Resources._default;
            this.artitem_pb_image.Location = new System.Drawing.Point(640, 6);
            this.artitem_pb_image.Name = "artitem_pb_image";
            this.artitem_pb_image.Size = new System.Drawing.Size(172, 183);
            this.artitem_pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.artitem_pb_image.TabIndex = 30;
            this.artitem_pb_image.TabStop = false;
            // 
            // artitem_btn_uploadimg
            // 
            this.artitem_btn_uploadimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_btn_uploadimg.Location = new System.Drawing.Point(664, 190);
            this.artitem_btn_uploadimg.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_btn_uploadimg.Name = "artitem_btn_uploadimg";
            this.artitem_btn_uploadimg.Size = new System.Drawing.Size(115, 28);
            this.artitem_btn_uploadimg.TabIndex = 29;
            this.artitem_btn_uploadimg.Text = "Upload Img";
            this.artitem_btn_uploadimg.UseVisualStyleBackColor = true;
            this.artitem_btn_uploadimg.Click += new System.EventHandler(this.artitem_btn_uploadimg_Click);
            // 
            // artitem_rtb_description
            // 
            this.artitem_rtb_description.Location = new System.Drawing.Point(376, 29);
            this.artitem_rtb_description.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_rtb_description.Name = "artitem_rtb_description";
            this.artitem_rtb_description.Size = new System.Drawing.Size(221, 131);
            this.artitem_rtb_description.TabIndex = 28;
            this.artitem_rtb_description.Text = "";
            // 
            // artitem_tb_minimumBid
            // 
            this.artitem_tb_minimumBid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_tb_minimumBid.Location = new System.Drawing.Point(125, 165);
            this.artitem_tb_minimumBid.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_tb_minimumBid.Name = "artitem_tb_minimumBid";
            this.artitem_tb_minimumBid.Size = new System.Drawing.Size(140, 26);
            this.artitem_tb_minimumBid.TabIndex = 27;
            // 
            // artitem_btn_clear
            // 
            this.artitem_btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_btn_clear.Location = new System.Drawing.Point(340, 190);
            this.artitem_btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_btn_clear.Name = "artitem_btn_clear";
            this.artitem_btn_clear.Size = new System.Drawing.Size(115, 28);
            this.artitem_btn_clear.TabIndex = 25;
            this.artitem_btn_clear.Text = "Clear";
            this.artitem_btn_clear.UseVisualStyleBackColor = true;
            this.artitem_btn_clear.Click += new System.EventHandler(this.artitem_btn_clear_Click);
            // 
            // artitem_btn_add
            // 
            this.artitem_btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_btn_add.Location = new System.Drawing.Point(482, 190);
            this.artitem_btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_btn_add.Name = "artitem_btn_add";
            this.artitem_btn_add.Size = new System.Drawing.Size(115, 28);
            this.artitem_btn_add.TabIndex = 23;
            this.artitem_btn_add.Text = "Add";
            this.artitem_btn_add.UseVisualStyleBackColor = true;
            this.artitem_btn_add.Click += new System.EventHandler(this.artitem_btn_add_Click);
            // 
            // artitem_grid
            // 
            this.artitem_grid.AllowUserToAddRows = false;
            this.artitem_grid.AllowUserToOrderColumns = true;
            this.artitem_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artitem_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.artitem_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artitem_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.item_artist,
            this.item_purchasePrice,
            this.item_minimumBid,
            this.dataGridViewTextBoxColumn8});
            this.artitem_grid.Location = new System.Drawing.Point(2, 227);
            this.artitem_grid.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_grid.MultiSelect = false;
            this.artitem_grid.Name = "artitem_grid";
            this.artitem_grid.ReadOnly = true;
            this.artitem_grid.RowTemplate.Height = 33;
            this.artitem_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.artitem_grid.Size = new System.Drawing.Size(824, 187);
            this.artitem_grid.TabIndex = 22;
            this.artitem_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.artitem_grid_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // item_artist
            // 
            this.item_artist.HeaderText = "Artist";
            this.item_artist.Name = "item_artist";
            this.item_artist.ReadOnly = true;
            // 
            // item_purchasePrice
            // 
            this.item_purchasePrice.HeaderText = "Purchase Price";
            this.item_purchasePrice.Name = "item_purchasePrice";
            this.item_purchasePrice.ReadOnly = true;
            // 
            // item_minimumBid
            // 
            this.item_minimumBid.HeaderText = "Minimum bid";
            this.item_minimumBid.Name = "item_minimumBid";
            this.item_minimumBid.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Create at";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // artitem_tb_purchasePrice
            // 
            this.artitem_tb_purchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_tb_purchasePrice.Location = new System.Drawing.Point(125, 128);
            this.artitem_tb_purchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_tb_purchasePrice.Name = "artitem_tb_purchasePrice";
            this.artitem_tb_purchasePrice.Size = new System.Drawing.Size(140, 26);
            this.artitem_tb_purchasePrice.TabIndex = 16;
            // 
            // artitem_tb_artist
            // 
            this.artitem_tb_artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_tb_artist.Location = new System.Drawing.Point(125, 94);
            this.artitem_tb_artist.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_tb_artist.Name = "artitem_tb_artist";
            this.artitem_tb_artist.Size = new System.Drawing.Size(140, 26);
            this.artitem_tb_artist.TabIndex = 15;
            // 
            // artitem_tb_name
            // 
            this.artitem_tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_tb_name.Location = new System.Drawing.Point(125, 61);
            this.artitem_tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_tb_name.Name = "artitem_tb_name";
            this.artitem_tb_name.Size = new System.Drawing.Size(140, 26);
            this.artitem_tb_name.TabIndex = 14;
            // 
            // artitem_tb_createAt
            // 
            this.artitem_tb_createAt.Enabled = false;
            this.artitem_tb_createAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_tb_createAt.Location = new System.Drawing.Point(125, 197);
            this.artitem_tb_createAt.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_tb_createAt.Name = "artitem_tb_createAt";
            this.artitem_tb_createAt.Size = new System.Drawing.Size(140, 26);
            this.artitem_tb_createAt.TabIndex = 12;
            // 
            // artitem_tb_id
            // 
            this.artitem_tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_tb_id.Location = new System.Drawing.Point(125, 26);
            this.artitem_tb_id.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_tb_id.Name = "artitem_tb_id";
            this.artitem_tb_id.Size = new System.Drawing.Size(140, 26);
            this.artitem_tb_id.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 168);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Minimum bid";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 206);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Create at";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 131);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Purchase price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(62, 100);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Artist";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(293, 29);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Description";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(57, 61);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(74, 29);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "ID";
            // 
            // artitem_btn_update
            // 
            this.artitem_btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artitem_btn_update.Location = new System.Drawing.Point(482, 190);
            this.artitem_btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.artitem_btn_update.Name = "artitem_btn_update";
            this.artitem_btn_update.Size = new System.Drawing.Size(115, 28);
            this.artitem_btn_update.TabIndex = 24;
            this.artitem_btn_update.Text = "Update";
            this.artitem_btn_update.UseVisualStyleBackColor = true;
            this.artitem_btn_update.Click += new System.EventHandler(this.artitem_btn_update_Click);
            // 
            // lbl_errors
            // 
            this.lbl_errors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbl_errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_errors.Location = new System.Drawing.Point(-1, 445);
            this.lbl_errors.MinimumSize = new System.Drawing.Size(620, 0);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(620, 17);
            this.lbl_errors.TabIndex = 10;
            // 
            // loggedin_lbl
            // 
            this.loggedin_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loggedin_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loggedin_lbl.Location = new System.Drawing.Point(622, 441);
            this.loggedin_lbl.Name = "loggedin_lbl";
            this.loggedin_lbl.Size = new System.Drawing.Size(231, 23);
            this.loggedin_lbl.TabIndex = 11;
            this.loggedin_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ArtClubApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 462);
            this.Controls.Add(this.loggedin_lbl);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.lbl_errors);
            this.Controls.Add(this.login_panel);
            this.MinimumSize = new System.Drawing.Size(873, 501);
            this.Text = "ArtClubApp";
            this.Load += new System.EventHandler(this.ArtClubApp_Load);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.tab_members.ResumeLayout(false);
            this.tab_members.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_tb_employee_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_grid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artitem_pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artitem_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_pass;
        private System.Windows.Forms.TextBox login_email;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl panel_main;
        private System.Windows.Forms.TabPage tab_members;
        private System.Windows.Forms.NumericUpDown member_tb_employee_no;
        private System.Windows.Forms.ComboBox member_cb_gender;
        private System.Windows.Forms.CheckBox member_iscancelled_checkbox;
        private System.Windows.Forms.Button member_btn_clear;
        private System.Windows.Forms.Button member_btn_add;
        private System.Windows.Forms.DataGridView member_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_employeeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_points;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_isBoard;
        private System.Windows.Forms.DataGridViewCheckBoxColumn m_cancelled;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_createAt;
        private System.Windows.Forms.CheckBox member_isboard_checkbox;
        private System.Windows.Forms.TextBox member_tb_phone;
        private System.Windows.Forms.TextBox member_tb_email;
        private System.Windows.Forms.TextBox member_tb_name;
        private System.Windows.Forms.TextBox member_tb_createAt;
        private System.Windows.Forms.TextBox member_tb_points;
        private System.Windows.Forms.TextBox member_tb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button member_btn_update;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox artitem_pb_image;
        private System.Windows.Forms.Button artitem_btn_uploadimg;
        private System.Windows.Forms.RichTextBox artitem_rtb_description;
        private System.Windows.Forms.TextBox artitem_tb_minimumBid;
        private System.Windows.Forms.Button artitem_btn_clear;
        private System.Windows.Forms.Button artitem_btn_add;
        private System.Windows.Forms.DataGridView artitem_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_minimumBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox artitem_tb_purchasePrice;
        private System.Windows.Forms.TextBox artitem_tb_artist;
        private System.Windows.Forms.TextBox artitem_tb_name;
        private System.Windows.Forms.TextBox artitem_tb_createAt;
        private System.Windows.Forms.TextBox artitem_tb_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button artitem_btn_update;
        private System.Windows.Forms.Label lbl_errors;
        private System.Windows.Forms.Label loggedin_lbl;

    }
}