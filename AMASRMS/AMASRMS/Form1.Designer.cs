namespace AMASRMS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboNat = new System.Windows.Forms.ComboBox();
            this.dateBOD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtGuardian = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboSec = new System.Windows.Forms.ComboBox();
            this.comboDep = new System.Windows.Forms.ComboBox();
            this.comboYL = new System.Windows.Forms.ComboBox();
            this.BBrowse = new System.Windows.Forms.Button();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.BNew = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BEdit = new System.Windows.Forms.Button();
            this.BCancel = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.dateAdmit = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboSY = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.MyDB = new AMASRMS.MyDB();
            this.aMASTUDENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMA_STUDENTSTableAdapter = new AMASRMS.MyDBTableAdapters.AMA_STUDENTSTableAdapter();
            this.sNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfAdmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMASTUDENTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tabControl1);
            this.panel.Controls.Add(this.BBrowse);
            this.panel.Controls.Add(this.PhotoBox);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(12, 34);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(738, 320);
            this.panel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(185, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboNat);
            this.tabPage1.Controls.Add(this.dateBOD);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtLname);
            this.tabPage1.Controls.Add(this.comboGender);
            this.tabPage1.Controls.Add(this.txtFname);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtMname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student Personal Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboNat
            // 
            this.comboNat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "Nationality", true));
            this.comboNat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNat.FormattingEnabled = true;
            this.comboNat.Items.AddRange(new object[] {
            "African",
            "American",
            "American",
            "Argentinian",
            "Australian",
            "Austrian",
            "Bangladeshi",
            "Belgian",
            "Brazilian",
            "British",
            "Cambodian",
            "Chilean",
            "Chinese",
            "Colombian",
            "Croatian",
            "Czech",
            "Danish",
            "Dutch",
            "English",
            "Filipino",
            "Finnish",
            "French",
            "German",
            "Greek",
            "Hungarian",
            "Icelandic",
            "Indian",
            "Indonesian",
            "Iranian",
            "Iraqi",
            "Irish",
            "Israeli",
            "Jamaican",
            "Japanese",
            "Mexican",
            "Moroccan",
            "Norwegian",
            "Peruvian",
            "Polish",
            "Portuguese",
            "Rumanian",
            "Russian",
            "Saudi, Saudi Arabian",
            "Scottish",
            "Serbian",
            "Slovak",
            "Swedish",
            "Swiss",
            "Thai",
            "Tunisian",
            "Turkish",
            "Vietnamese",
            "Welsh",
            "Yugoslav"});
            this.comboNat.Location = new System.Drawing.Point(149, 175);
            this.comboNat.Name = "comboNat";
            this.comboNat.Size = new System.Drawing.Size(246, 24);
            this.comboNat.TabIndex = 5;
            // 
            // dateBOD
            // 
            this.dateBOD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "DOB", true));
            this.dateBOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBOD.Location = new System.Drawing.Point(149, 205);
            this.dateBOD.Name = "dateBOD";
            this.dateBOD.Size = new System.Drawing.Size(246, 22);
            this.dateBOD.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date Of Birth";
            // 
            // txtLname
            // 
            this.txtLname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "LastName", true));
            this.txtLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(149, 61);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(349, 22);
            this.txtLname.TabIndex = 1;
            // 
            // comboGender
            // 
            this.comboGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "Gender", true));
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(149, 145);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(99, 24);
            this.comboGender.TabIndex = 4;
            // 
            // txtFname
            // 
            this.txtFname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "FirstName", true));
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(149, 117);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(349, 22);
            this.txtFname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nationality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            // 
            // txtMname
            // 
            this.txtMname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "MiddleName", true));
            this.txtMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMname.Location = new System.Drawing.Point(149, 89);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(349, 22);
            this.txtMname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "StudentID", true));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(149, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 22);
            this.txtID.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtContact);
            this.tabPage2.Controls.Add(this.txtGuardian);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txtMobile);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contacts and Address";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtContact
            // 
            this.txtContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "ContactNo", true));
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(132, 217);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(276, 22);
            this.txtContact.TabIndex = 1;
            // 
            // txtGuardian
            // 
            this.txtGuardian.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "Guardian", true));
            this.txtGuardian.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardian.Location = new System.Drawing.Point(132, 189);
            this.txtGuardian.Name = "txtGuardian";
            this.txtGuardian.Size = new System.Drawing.Size(276, 22);
            this.txtGuardian.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Contact No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Home Address";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "HomeAddress", true));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(132, 18);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(386, 109);
            this.txtAddress.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Guardian";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mobile No.";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "Email", true));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(132, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtMobile
            // 
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "MobileNo", true));
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(132, 133);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(276, 22);
            this.txtMobile.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "E-mail";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtRemarks);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.comboSY);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.dateAdmit);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.comboSec);
            this.tabPage3.Controls.Add(this.comboDep);
            this.tabPage3.Controls.Add(this.comboYL);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(538, 272);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Class Records";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboSec
            // 
            this.comboSec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "Section", true));
            this.comboSec.FormattingEnabled = true;
            this.comboSec.Items.AddRange(new object[] {
            "DVA",
            "DVB",
            "DVC",
            "DVD",
            "DVE",
            "DVF"});
            this.comboSec.Location = new System.Drawing.Point(145, 134);
            this.comboSec.Name = "comboSec";
            this.comboSec.Size = new System.Drawing.Size(95, 24);
            this.comboSec.TabIndex = 6;
            // 
            // comboDep
            // 
            this.comboDep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "Department", true));
            this.comboDep.FormattingEnabled = true;
            this.comboDep.Items.AddRange(new object[] {
            "B.A. IN ECONOMICS",
            "B.A. IN ENGLISH",
            "B.A. IN MASS COMMUNICATION",
            "B.A. IN POLITICAL SCIENCE",
            "B.A. IN PSYCHOLOGY",
            "B.S. IN ACCOUNTANCY",
            "B.S. IN BUSINESS AD MJR IN MANAGEMENT INFO SYSTEM",
            "B.S. IN COMPUTER ENGINEERING",
            "B.S. IN COMPUTER SCIENCE",
            "B.S. IN INFORMATION TECHNOLOGY",
            "BEED",
            "BSED MAJOR IN COMPUTER SCIENCE",
            "BSED MAJOR IN ENGLISH",
            "BSED MAJOR IN MATHEMATICS"});
            this.comboDep.Location = new System.Drawing.Point(145, 104);
            this.comboDep.Name = "comboDep";
            this.comboDep.Size = new System.Drawing.Size(376, 24);
            this.comboDep.TabIndex = 5;
            // 
            // comboYL
            // 
            this.comboYL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "YearLevel", true));
            this.comboYL.FormattingEnabled = true;
            this.comboYL.Items.AddRange(new object[] {
            "1st year",
            "2nd year",
            "3rd year"});
            this.comboYL.Location = new System.Drawing.Point(145, 74);
            this.comboYL.Name = "comboYL";
            this.comboYL.Size = new System.Drawing.Size(95, 24);
            this.comboYL.TabIndex = 4;
            // 
            // BBrowse
            // 
            this.BBrowse.Location = new System.Drawing.Point(3, 201);
            this.BBrowse.Name = "BBrowse";
            this.BBrowse.Size = new System.Drawing.Size(157, 35);
            this.BBrowse.TabIndex = 0;
            this.BBrowse.Text = "&Browse";
            this.BBrowse.UseVisualStyleBackColor = true;
            this.BBrowse.Click += new System.EventHandler(this.BBrowse_Click);
            // 
            // PhotoBox
            // 
            this.PhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PhotoBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.aMASTUDENTSBindingSource, "Image", true));
            this.PhotoBox.Location = new System.Drawing.Point(3, 27);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(157, 168);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PhotoBox.TabIndex = 0;
            this.PhotoBox.TabStop = false;
            // 
            // BNew
            // 
            this.BNew.Location = new System.Drawing.Point(377, 360);
            this.BNew.Name = "BNew";
            this.BNew.Size = new System.Drawing.Size(86, 27);
            this.BNew.TabIndex = 2;
            this.BNew.Text = "&New";
            this.BNew.UseVisualStyleBackColor = true;
            this.BNew.Click += new System.EventHandler(this.BNew_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "&Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(74, 360);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // BEdit
            // 
            this.BEdit.Location = new System.Drawing.Point(469, 360);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(86, 27);
            this.BEdit.TabIndex = 3;
            this.BEdit.Text = "&Edit";
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(561, 360);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(86, 27);
            this.BCancel.TabIndex = 4;
            this.BCancel.Text = "&Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(653, 360);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(86, 27);
            this.BSave.TabIndex = 5;
            this.BSave.Text = "&Save";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.homeAddressDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.guardianDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.dateOfAdmissionDataGridViewTextBoxColumn,
            this.schoolYearDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.aMASTUDENTSBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(15, 393);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(724, 186);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Date Of Admission";
            // 
            // dateAdmit
            // 
            this.dateAdmit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "DateOfAdmission", true));
            this.dateAdmit.Location = new System.Drawing.Point(145, 16);
            this.dateAdmit.Name = "dateAdmit";
            this.dateAdmit.Size = new System.Drawing.Size(247, 22);
            this.dateAdmit.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 4;
            this.label15.Text = "Year Level";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "School Year";
            // 
            // comboSY
            // 
            this.comboSY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "SchoolYear", true));
            this.comboSY.FormattingEnabled = true;
            this.comboSY.Items.AddRange(new object[] {
            "2018 - 2019",
            "2019 - 2020",
            "2020 - 2021",
            "2021 - 2022",
            "2022 - 2023",
            "2023 - 2024",
            "2024 - 2025",
            "2025 - 2026",
            "2026 - 2027",
            "2027 - 2028",
            "2028 - 2029",
            "2029 - 2030",
            "2030 - 2031",
            "2031 - 2032",
            "2032 - 2033",
            "2033 - 2034",
            "2034 - 2035",
            "2035 - 2036",
            "2036 - 2037",
            "2037 - 2038",
            "2038 - 2039",
            "2039 - 2040",
            "2040 - 2041",
            "2041 - 2042",
            "2042 - 2043",
            "2043 - 2044",
            "2044 - 2045",
            "2045 - 2046",
            "2046 - 2047",
            "2047 - 2048",
            "2048 - 2049",
            "2049 - 2050",
            "2050 - 2051"});
            this.comboSY.Location = new System.Drawing.Point(145, 44);
            this.comboSY.Name = "comboSY";
            this.comboSY.Size = new System.Drawing.Size(118, 24);
            this.comboSY.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "Department";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 137);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 17);
            this.label18.TabIndex = 4;
            this.label18.Text = "Section";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 167);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.White;
            this.txtRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aMASTUDENTSBindingSource, "Remarks", true));
            this.txtRemarks.Location = new System.Drawing.Point(145, 164);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(376, 102);
            this.txtRemarks.TabIndex = 7;
            // 
            // myDB
            // 
            this.MyDB.DataSetName = "MyDB";
            this.MyDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aMASTUDENTSBindingSource
            // 
            this.aMASTUDENTSBindingSource.DataMember = "AMA_STUDENTS";
            this.aMASTUDENTSBindingSource.DataSource = this.MyDB;
            // 
            // aMA_STUDENTSTableAdapter
            // 
            this.aMA_STUDENTSTableAdapter.ClearBeforeFill = true;
            // 
            // sNDataGridViewTextBoxColumn
            // 
            this.sNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sNDataGridViewTextBoxColumn.DataPropertyName = "SN";
            this.sNDataGridViewTextBoxColumn.HeaderText = "SN";
            this.sNDataGridViewTextBoxColumn.Name = "sNDataGridViewTextBoxColumn";
            this.sNDataGridViewTextBoxColumn.Width = 56;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 99;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 101;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.Width = 115;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 101;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 85;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.Width = 103;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 67;
            // 
            // homeAddressDataGridViewTextBoxColumn
            // 
            this.homeAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.homeAddressDataGridViewTextBoxColumn.DataPropertyName = "HomeAddress";
            this.homeAddressDataGridViewTextBoxColumn.HeaderText = "HomeAddress";
            this.homeAddressDataGridViewTextBoxColumn.Name = "homeAddressDataGridViewTextBoxColumn";
            this.homeAddressDataGridViewTextBoxColumn.Width = 126;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.Width = 96;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 71;
            // 
            // guardianDataGridViewTextBoxColumn
            // 
            this.guardianDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.guardianDataGridViewTextBoxColumn.DataPropertyName = "Guardian";
            this.guardianDataGridViewTextBoxColumn.HeaderText = "Guardian";
            this.guardianDataGridViewTextBoxColumn.Name = "guardianDataGridViewTextBoxColumn";
            this.guardianDataGridViewTextBoxColumn.Width = 96;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 103;
            // 
            // dateOfAdmissionDataGridViewTextBoxColumn
            // 
            this.dateOfAdmissionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateOfAdmissionDataGridViewTextBoxColumn.DataPropertyName = "DateOfAdmission";
            this.dateOfAdmissionDataGridViewTextBoxColumn.HeaderText = "DateOfAdmission";
            this.dateOfAdmissionDataGridViewTextBoxColumn.Name = "dateOfAdmissionDataGridViewTextBoxColumn";
            this.dateOfAdmissionDataGridViewTextBoxColumn.Width = 146;
            // 
            // schoolYearDataGridViewTextBoxColumn
            // 
            this.schoolYearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.schoolYearDataGridViewTextBoxColumn.DataPropertyName = "SchoolYear";
            this.schoolYearDataGridViewTextBoxColumn.HeaderText = "SchoolYear";
            this.schoolYearDataGridViewTextBoxColumn.Name = "schoolYearDataGridViewTextBoxColumn";
            this.schoolYearDataGridViewTextBoxColumn.Width = 110;
            // 
            // yearLevelDataGridViewTextBoxColumn
            // 
            this.yearLevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.yearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.Name = "yearLevelDataGridViewTextBoxColumn";
            this.yearLevelDataGridViewTextBoxColumn.Width = 101;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 111;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.Width = 84;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.Width = 93;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 591);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.BEdit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BNew);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMA Student Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMASTUDENTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button BBrowse;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.ComboBox comboNat;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.DateTimePicker dateBOD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboSec;
        private System.Windows.Forms.ComboBox comboDep;
        private System.Windows.Forms.ComboBox comboYL;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGuardian;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BNew;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboSY;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateAdmit;
        private System.Windows.Forms.Label label14;
        private MyDB MyDB;
        private System.Windows.Forms.BindingSource aMASTUDENTSBindingSource;
        private MyDBTableAdapters.AMA_STUDENTSTableAdapter aMA_STUDENTSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfAdmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}

