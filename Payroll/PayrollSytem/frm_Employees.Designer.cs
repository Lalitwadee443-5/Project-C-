namespace PayrollSytem
{
    partial class frm_Employees
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
            this.btndelete = new System.Windows.Forms.Button();
            this.Label46 = new System.Windows.Forms.Label();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.btnempnew = new System.Windows.Forms.Button();
            this.btnempsave = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtpdbirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtnname = new System.Windows.Forms.TextBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.txtemerg = new System.Windows.Forms.TextBox();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.txtpmethod = new System.Windows.Forms.ComboBox();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.txtposition = new System.Windows.Forms.ComboBox();
            this.txtworkstatus = new System.Windows.Forms.ComboBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.txtdrate = new System.Windows.Forms.TextBox();
            this.dtpdhired = new System.Windows.Forms.DateTimePicker();
            this.txtidc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            this.TabPage7.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(943, 454);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(172, 28);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Location = new System.Drawing.Point(833, 71);
            this.Label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(61, 17);
            this.Label46.TabIndex = 3;
            this.Label46.Text = "Search :";
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgemplist.Location = new System.Drawing.Point(4, 98);
            this.dtgemplist.Margin = new System.Windows.Forms.Padding(4);
            this.dtgemplist.Name = "dtgemplist";
            this.dtgemplist.RowHeadersVisible = false;
            this.dtgemplist.RowHeadersWidth = 51;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgemplist.ShowCellToolTips = false;
            this.dtgemplist.Size = new System.Drawing.Size(1115, 348);
            this.dtgemplist.TabIndex = 0;
            // 
            // TabPage7
            // 
            this.TabPage7.Controls.Add(this.btn_edit);
            this.TabPage7.Controls.Add(this.btndelete);
            this.TabPage7.Controls.Add(this.Label46);
            this.TabPage7.Controls.Add(this.txtempsearch);
            this.TabPage7.Controls.Add(this.dtgemplist);
            this.TabPage7.Location = new System.Drawing.Point(4, 25);
            this.TabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage7.Size = new System.Drawing.Size(1121, 540);
            this.TabPage7.TabIndex = 1;
            this.TabPage7.Text = "Employee\'s List";
            this.TabPage7.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(763, 454);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(172, 28);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txtempsearch
            // 
            this.txtempsearch.Location = new System.Drawing.Point(897, 66);
            this.txtempsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(216, 22);
            this.txtempsearch.TabIndex = 2;
            this.txtempsearch.TextChanged += new System.EventHandler(this.txtempsearch_TextChanged);
            // 
            // btnempnew
            // 
            this.btnempnew.Location = new System.Drawing.Point(649, 455);
            this.btnempnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnempnew.Name = "btnempnew";
            this.btnempnew.Size = new System.Drawing.Size(100, 39);
            this.btnempnew.TabIndex = 15;
            this.btnempnew.Text = "New";
            this.btnempnew.UseVisualStyleBackColor = true;
            this.btnempnew.Click += new System.EventHandler(this.btnempnew_Click);
            // 
            // btnempsave
            // 
            this.btnempsave.Location = new System.Drawing.Point(433, 455);
            this.btnempsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnempsave.Name = "btnempsave";
            this.btnempsave.Size = new System.Drawing.Size(100, 39);
            this.btnempsave.TabIndex = 16;
            this.btnempsave.Text = "Save";
            this.btnempsave.UseVisualStyleBackColor = true;
            this.btnempsave.Click += new System.EventHandler(this.btnempsave_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(113, 75);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(220, 66);
            this.txtaddress.TabIndex = 17;
            this.txtaddress.Text = "";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(-3, 160);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(102, 17);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "เลขบัตรประชาชน";
            this.Label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // dtpdbirth
            // 
            this.dtpdbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdbirth.Location = new System.Drawing.Point(835, 117);
            this.dtpdbirth.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdbirth.Name = "dtpdbirth";
            this.dtpdbirth.Size = new System.Drawing.Size(160, 22);
            this.dtpdbirth.TabIndex = 12;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(777, 121);
            this.Label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(44, 17);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "วันเกิด";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(471, 39);
            this.txtlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(236, 22);
            this.txtlname.TabIndex = 0;
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox9.Controls.Add(this.txtidc);
            this.GroupBox9.Controls.Add(this.txtaddress);
            this.GroupBox9.Controls.Add(this.Label21);
            this.GroupBox9.Controls.Add(this.dtpdbirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.txtlname);
            this.GroupBox9.Controls.Add(this.Label23);
            this.GroupBox9.Controls.Add(this.txtcontact);
            this.GroupBox9.Controls.Add(this.txtage);
            this.GroupBox9.Controls.Add(this.txtfname);
            this.GroupBox9.Controls.Add(this.Label24);
            this.GroupBox9.Controls.Add(this.txtnname);
            this.GroupBox9.Controls.Add(this.rdofemale);
            this.GroupBox9.Controls.Add(this.txtemerg);
            this.GroupBox9.Controls.Add(this.rdomale);
            this.GroupBox9.Controls.Add(this.Label25);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Controls.Add(this.Label27);
            this.GroupBox9.Controls.Add(this.txtstatus);
            this.GroupBox9.Controls.Add(this.Label28);
            this.GroupBox9.Controls.Add(this.Label29);
            this.GroupBox9.Controls.Add(this.Label30);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.Location = new System.Drawing.Point(41, 58);
            this.GroupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox9.Size = new System.Drawing.Size(1055, 233);
            this.GroupBox9.TabIndex = 18;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "ข้อมูลส่วนบุคคล";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(428, 166);
            this.Label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(28, 17);
            this.Label23.TabIndex = 9;
            this.Label23.Text = "อายุ";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(471, 73);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontact.MaxLength = 10;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(236, 22);
            this.txtcontact.TabIndex = 0;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(471, 161);
            this.txtage.Margin = new System.Windows.Forms.Padding(4);
            this.txtage.MaxLength = 2;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(76, 22);
            this.txtage.TabIndex = 8;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(113, 39);
            this.txtfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(225, 22);
            this.txtfname.TabIndex = 0;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(428, 123);
            this.Label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(29, 17);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "เพศ";
            // 
            // txtnname
            // 
            this.txtnname.Location = new System.Drawing.Point(835, 39);
            this.txtnname.Margin = new System.Windows.Forms.Padding(4);
            this.txtnname.Name = "txtnname";
            this.txtnname.Size = new System.Drawing.Size(207, 22);
            this.txtnname.TabIndex = 0;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(541, 121);
            this.rdofemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(54, 21);
            this.rdofemale.TabIndex = 6;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "หญิง";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // txtemerg
            // 
            this.txtemerg.Location = new System.Drawing.Point(835, 161);
            this.txtemerg.Margin = new System.Windows.Forms.Padding(4);
            this.txtemerg.MaxLength = 10;
            this.txtemerg.Name = "txtemerg";
            this.txtemerg.Size = new System.Drawing.Size(205, 22);
            this.txtemerg.TabIndex = 0;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(469, 121);
            this.rdomale.Margin = new System.Windows.Forms.Padding(4);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(50, 21);
            this.rdomale.TabIndex = 6;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "ชาย";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(377, 75);
            this.Label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(80, 17);
            this.Label25.TabIndex = 1;
            this.Label25.Text = "เบอร์โทรศัพท์";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(62, 44);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(43, 17);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "ชื่อจริง";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(777, 75);
            this.Label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(44, 17);
            this.Label27.TabIndex = 1;
            this.Label27.Text = "สถานะ";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "แต่งงานแล้ว",
            "โสด",
            "หย่าร้าง"});
            this.txtstatus.Location = new System.Drawing.Point(835, 71);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(160, 24);
            this.txtstatus.TabIndex = 2;
            this.txtstatus.Text = "โสด";
            this.txtstatus.SelectedIndexChanged += new System.EventHandler(this.txtstatus_SelectedIndexChanged);
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(403, 42);
            this.Label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(53, 17);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "นามสกุล";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(71, 78);
            this.Label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(30, 17);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "ที่อยู่";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(652, 164);
            this.Label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(159, 17);
            this.Label30.TabIndex = 1;
            this.Label30.Text = "เบอร์โทรศัพท์ (กรณีฉุกเฉิน)";
            this.Label30.Click += new System.EventHandler(this.Label30_Click);
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(778, 44);
            this.Label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(43, 17);
            this.Label31.TabIndex = 1;
            this.Label31.Text = "ชื่อเล่น";
            // 
            // txtpmethod
            // 
            this.txtpmethod.FormattingEnabled = true;
            this.txtpmethod.Items.AddRange(new object[] {
            "รายสัปดาห์",
            "รายเดือน"});
            this.txtpmethod.Location = new System.Drawing.Point(120, 59);
            this.txtpmethod.Margin = new System.Windows.Forms.Padding(4);
            this.txtpmethod.Name = "txtpmethod";
            this.txtpmethod.Size = new System.Drawing.Size(204, 24);
            this.txtpmethod.TabIndex = 0;
            this.txtpmethod.Text = "รายสัปดาห์";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(1129, 569);
            this.TabControl2.TabIndex = 2;
            // 
            // TabPage6
            // 
            this.TabPage6.Controls.Add(this.btnempupdate);
            this.TabPage6.Controls.Add(this.txtcode);
            this.TabPage6.Controls.Add(this.Label20);
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Controls.Add(this.GroupBox9);
            this.TabPage6.Controls.Add(this.btnempnew);
            this.TabPage6.Controls.Add(this.btnempsave);
            this.TabPage6.Location = new System.Drawing.Point(4, 25);
            this.TabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage6.Size = new System.Drawing.Size(1121, 540);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "Information";
            this.TabPage6.UseVisualStyleBackColor = true;
            // 
            // btnempupdate
            // 
            this.btnempupdate.Location = new System.Drawing.Point(541, 455);
            this.btnempupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(100, 39);
            this.btnempupdate.TabIndex = 21;
            this.btnempupdate.Text = "Update";
            this.btnempupdate.UseVisualStyleBackColor = true;
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(155, 26);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(265, 22);
            this.txtcode.TabIndex = 15;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(49, 30);
            this.Label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(90, 17);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "รหัสพนักงาน  :";
            // 
            // GroupBox10
            // 
            this.GroupBox10.Controls.Add(this.txtposition);
            this.GroupBox10.Controls.Add(this.txtworkstatus);
            this.GroupBox10.Controls.Add(this.Label37);
            this.GroupBox10.Controls.Add(this.Label36);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.txtdrate);
            this.GroupBox10.Controls.Add(this.dtpdhired);
            this.GroupBox10.Controls.Add(this.txtpmethod);
            this.GroupBox10.Location = new System.Drawing.Point(41, 298);
            this.GroupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox10.Size = new System.Drawing.Size(1047, 137);
            this.GroupBox10.TabIndex = 19;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "ข้อมูลการทำงาน";
            // 
            // txtposition
            // 
            this.txtposition.FormattingEnabled = true;
            this.txtposition.Items.AddRange(new object[] {
            "พนักงานประจำ",
            "พนักงานชั่วคราว"});
            this.txtposition.Location = new System.Drawing.Point(464, 25);
            this.txtposition.Margin = new System.Windows.Forms.Padding(4);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(204, 24);
            this.txtposition.TabIndex = 9;
            this.txtposition.Text = "พนักงานประจำ";
            this.txtposition.SelectedIndexChanged += new System.EventHandler(this.txtposition_SelectedIndexChanged);
            // 
            // txtworkstatus
            // 
            this.txtworkstatus.FormattingEnabled = true;
            this.txtworkstatus.Items.AddRange(new object[] {
            "พนักงาน",
            "ลาออก",
            "เกษียณ"});
            this.txtworkstatus.Location = new System.Drawing.Point(465, 55);
            this.txtworkstatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtworkstatus.Name = "txtworkstatus";
            this.txtworkstatus.Size = new System.Drawing.Size(204, 24);
            this.txtworkstatus.TabIndex = 8;
            this.txtworkstatus.Text = "พนักงาน";
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(15, 28);
            this.Label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(87, 17);
            this.Label37.TabIndex = 7;
            this.Label37.Text = "ค่าแรงรายวัน :";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(384, 28);
            this.Label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(62, 17);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "ตำแหน่ง :";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(339, 59);
            this.Label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(108, 17);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "สถานะการทำงาน :";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(24, 62);
            this.Label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(78, 17);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "วิธีรับค่าจ้าง :";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(699, 26);
            this.Label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(85, 17);
            this.Label33.TabIndex = 3;
            this.Label33.Text = "วันเข้าทำงาน :";
            // 
            // txtdrate
            // 
            this.txtdrate.Location = new System.Drawing.Point(120, 23);
            this.txtdrate.Margin = new System.Windows.Forms.Padding(4);
            this.txtdrate.MaxLength = 3;
            this.txtdrate.Name = "txtdrate";
            this.txtdrate.Size = new System.Drawing.Size(204, 22);
            this.txtdrate.TabIndex = 2;
            // 
            // dtpdhired
            // 
            this.dtpdhired.CustomFormat = "yyyy-MM-dd";
            this.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdhired.Location = new System.Drawing.Point(801, 23);
            this.dtpdhired.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdhired.Name = "dtpdhired";
            this.dtpdhired.Size = new System.Drawing.Size(204, 22);
            this.dtpdhired.TabIndex = 1;
            // 
            // txtidc
            // 
            this.txtidc.Location = new System.Drawing.Point(113, 163);
            this.txtidc.Margin = new System.Windows.Forms.Padding(4);
            this.txtidc.MaxLength = 13;
            this.txtidc.Name = "txtidc";
            this.txtidc.Size = new System.Drawing.Size(225, 22);
            this.txtidc.TabIndex = 0;
            // 
            // frm_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 569);
            this.Controls.Add(this.TabControl2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.DataGridView dtgemplist;
        internal System.Windows.Forms.TabPage TabPage7;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.Button btnempnew;
        internal System.Windows.Forms.Button btnempsave;
        internal System.Windows.Forms.RichTextBox txtaddress;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker dtpdbirth;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txtcontact;
        internal System.Windows.Forms.TextBox txtage;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtnname;
        internal System.Windows.Forms.RadioButton rdofemale;
        internal System.Windows.Forms.TextBox txtemerg;
        internal System.Windows.Forms.RadioButton rdomale;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.ComboBox txtstatus;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.ComboBox txtpmethod;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Button btnempupdate;
        internal System.Windows.Forms.TextBox txtcode;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.ComboBox txtworkstatus;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox txtdrate;
        internal System.Windows.Forms.DateTimePicker dtpdhired;
        internal System.Windows.Forms.Button btn_edit;
        internal System.Windows.Forms.ComboBox txtposition;
        internal System.Windows.Forms.TextBox txtidc;
    }
}