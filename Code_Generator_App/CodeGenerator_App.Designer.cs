namespace Code_Generator_App
{
    partial class CodeGenerator_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeGenerator_App));
            this.button1 = new System.Windows.Forms.Button();
            this.rbBusinessLyaer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFunctionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbDataLayer = new System.Windows.Forms.RadioButton();
            this.cbFunctionType = new System.Windows.Forms.ComboBox();
            this.gbTableChoices = new System.Windows.Forms.GroupBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblClassname = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbColumnType = new System.Windows.Forms.ComboBox();
            this.txtAddColumn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbColumnChoices = new System.Windows.Forms.GroupBox();
            this.rbNull = new System.Windows.Forms.RadioButton();
            this.rbNotNull = new System.Windows.Forms.RadioButton();
            this.rbAdding = new System.Windows.Forms.RadioButton();
            this.rbDeleting = new System.Windows.Forms.RadioButton();
            this.rbReading = new System.Windows.Forms.RadioButton();
            this.rbUpdating = new System.Windows.Forms.RadioButton();
            this.gbCrudChoices = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.rbObject = new System.Windows.Forms.RadioButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.rbAllOfObject = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdding = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rtxtbString = new System.Windows.Forms.RichTextBox();
            this.gbTableChoices.SuspendLayout();
            this.gbColumnChoices.SuspendLayout();
            this.gbCrudChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1666, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rbBusinessLyaer
            // 
            this.rbBusinessLyaer.AutoSize = true;
            this.rbBusinessLyaer.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBusinessLyaer.ForeColor = System.Drawing.Color.Crimson;
            this.rbBusinessLyaer.Location = new System.Drawing.Point(22, 59);
            this.rbBusinessLyaer.Name = "rbBusinessLyaer";
            this.rbBusinessLyaer.Size = new System.Drawing.Size(235, 37);
            this.rbBusinessLyaer.TabIndex = 3;
            this.rbBusinessLyaer.TabStop = true;
            this.rbBusinessLyaer.Text = "Business Layer";
            this.rbBusinessLyaer.UseVisualStyleBackColor = true;
            this.rbBusinessLyaer.Click += new System.EventHandler(this.rbBusinessLyaer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Business And Data Layer Codes Generator";
            // 
            // txtFunctionName
            // 
            this.txtFunctionName.Location = new System.Drawing.Point(187, 167);
            this.txtFunctionName.Name = "txtFunctionName";
            this.txtFunctionName.Size = new System.Drawing.Size(163, 23);
            this.txtFunctionName.TabIndex = 13;
            this.txtFunctionName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(6, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Function Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Function Name";
            // 
            // rbDataLayer
            // 
            this.rbDataLayer.AutoSize = true;
            this.rbDataLayer.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDataLayer.ForeColor = System.Drawing.Color.Crimson;
            this.rbDataLayer.Location = new System.Drawing.Point(280, 59);
            this.rbDataLayer.Name = "rbDataLayer";
            this.rbDataLayer.Size = new System.Drawing.Size(179, 37);
            this.rbDataLayer.TabIndex = 15;
            this.rbDataLayer.TabStop = true;
            this.rbDataLayer.Text = "Data Layer";
            this.rbDataLayer.UseVisualStyleBackColor = true;
            this.rbDataLayer.Click += new System.EventHandler(this.rbDataLayer_Click);
            // 
            // cbFunctionType
            // 
            this.cbFunctionType.FormattingEnabled = true;
            this.cbFunctionType.Items.AddRange(new object[] {
            "bool",
            "byte",
            "char",
            "DataTable",
            "decimal",
            "double",
            "enum",
            "float",
            "int",
            "long",
            "object",
            "sbyte",
            "short",
            "string",
            "struct",
            "uint",
            "ulong",
            "ushort"});
            this.cbFunctionType.Location = new System.Drawing.Point(187, 212);
            this.cbFunctionType.Name = "cbFunctionType";
            this.cbFunctionType.Size = new System.Drawing.Size(163, 24);
            this.cbFunctionType.Sorted = true;
            this.cbFunctionType.TabIndex = 17;
            this.cbFunctionType.SelectedIndexChanged += new System.EventHandler(this.cbFunctionType_SelectedIndexChanged);
            // 
            // gbTableChoices
            // 
            this.gbTableChoices.BackColor = System.Drawing.Color.Transparent;
            this.gbTableChoices.Controls.Add(this.txtClassName);
            this.gbTableChoices.Controls.Add(this.lblClassname);
            this.gbTableChoices.Controls.Add(this.txtConnectionString);
            this.gbTableChoices.Controls.Add(this.lblConnectionString);
            this.gbTableChoices.Controls.Add(this.txtTableName);
            this.gbTableChoices.Controls.Add(this.label6);
            this.gbTableChoices.Controls.Add(this.txtFunctionName);
            this.gbTableChoices.Controls.Add(this.label5);
            this.gbTableChoices.Controls.Add(this.cbFunctionType);
            this.gbTableChoices.Controls.Add(this.label4);
            this.gbTableChoices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbTableChoices.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTableChoices.ForeColor = System.Drawing.SystemColors.Control;
            this.gbTableChoices.Location = new System.Drawing.Point(22, 113);
            this.gbTableChoices.Name = "gbTableChoices";
            this.gbTableChoices.Size = new System.Drawing.Size(362, 256);
            this.gbTableChoices.TabIndex = 19;
            this.gbTableChoices.TabStop = false;
            this.gbTableChoices.Text = "Choose Code Type";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(187, 32);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(163, 23);
            this.txtClassName.TabIndex = 32;
            this.txtClassName.Validating += new System.ComponentModel.CancelEventHandler(this.txtClassName_Validating);
            // 
            // lblClassname
            // 
            this.lblClassname.AutoSize = true;
            this.lblClassname.BackColor = System.Drawing.Color.Transparent;
            this.lblClassname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblClassname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblClassname.Location = new System.Drawing.Point(6, 29);
            this.lblClassname.Name = "lblClassname";
            this.lblClassname.Size = new System.Drawing.Size(103, 19);
            this.lblClassname.TabIndex = 31;
            this.lblClassname.Text = "Class Name";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(187, 77);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(163, 23);
            this.txtConnectionString.TabIndex = 30;
            this.txtConnectionString.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.BackColor = System.Drawing.Color.Transparent;
            this.lblConnectionString.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblConnectionString.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionString.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblConnectionString.Location = new System.Drawing.Point(6, 73);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(149, 19);
            this.lblConnectionString.TabIndex = 29;
            this.lblConnectionString.Text = "ConnectionString";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(187, 122);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(163, 23);
            this.txtTableName.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Table Name";
            // 
            // cbColumnType
            // 
            this.cbColumnType.FormattingEnabled = true;
            this.cbColumnType.Items.AddRange(new object[] {
            "byte",
            "sbyte",
            "short",
            "ushort",
            "int",
            "uint",
            "long",
            "ulong",
            "float",
            "double",
            "decimal",
            "bool",
            "char",
            "string",
            "DateTime",
            "object",
            "enum",
            "struct"});
            this.cbColumnType.Location = new System.Drawing.Point(187, 81);
            this.cbColumnType.Name = "cbColumnType";
            this.cbColumnType.Size = new System.Drawing.Size(163, 24);
            this.cbColumnType.TabIndex = 23;
            // 
            // txtAddColumn
            // 
            this.txtAddColumn.Location = new System.Drawing.Point(187, 32);
            this.txtAddColumn.Name = "txtAddColumn";
            this.txtAddColumn.Size = new System.Drawing.Size(163, 23);
            this.txtAddColumn.TabIndex = 22;
            this.txtAddColumn.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Column Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add Column";
            // 
            // gbColumnChoices
            // 
            this.gbColumnChoices.BackColor = System.Drawing.Color.Transparent;
            this.gbColumnChoices.Controls.Add(this.label2);
            this.gbColumnChoices.Controls.Add(this.cbColumnType);
            this.gbColumnChoices.Controls.Add(this.label3);
            this.gbColumnChoices.Controls.Add(this.rbNull);
            this.gbColumnChoices.Controls.Add(this.txtAddColumn);
            this.gbColumnChoices.Controls.Add(this.rbNotNull);
            this.gbColumnChoices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbColumnChoices.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbColumnChoices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbColumnChoices.Location = new System.Drawing.Point(17, 610);
            this.gbColumnChoices.Name = "gbColumnChoices";
            this.gbColumnChoices.Size = new System.Drawing.Size(364, 144);
            this.gbColumnChoices.TabIndex = 24;
            this.gbColumnChoices.TabStop = false;
            this.gbColumnChoices.Text = "Choose Code Type";
            // 
            // rbNull
            // 
            this.rbNull.AutoSize = true;
            this.rbNull.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNull.ForeColor = System.Drawing.Color.DarkViolet;
            this.rbNull.Location = new System.Drawing.Point(187, 111);
            this.rbNull.Name = "rbNull";
            this.rbNull.Size = new System.Drawing.Size(59, 23);
            this.rbNull.TabIndex = 24;
            this.rbNull.TabStop = true;
            this.rbNull.Text = "Null";
            this.rbNull.UseVisualStyleBackColor = true;
            // 
            // rbNotNull
            // 
            this.rbNotNull.AutoSize = true;
            this.rbNotNull.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotNull.ForeColor = System.Drawing.Color.DarkViolet;
            this.rbNotNull.Location = new System.Drawing.Point(258, 111);
            this.rbNotNull.Name = "rbNotNull";
            this.rbNotNull.Size = new System.Drawing.Size(93, 23);
            this.rbNotNull.TabIndex = 25;
            this.rbNotNull.TabStop = true;
            this.rbNotNull.Text = "Not Null";
            this.rbNotNull.UseVisualStyleBackColor = true;
            // 
            // rbAdding
            // 
            this.rbAdding.AutoSize = true;
            this.rbAdding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdding.ForeColor = System.Drawing.Color.DeepPink;
            this.rbAdding.Location = new System.Drawing.Point(61, 35);
            this.rbAdding.Name = "rbAdding";
            this.rbAdding.Size = new System.Drawing.Size(84, 23);
            this.rbAdding.TabIndex = 28;
            this.rbAdding.TabStop = true;
            this.rbAdding.Text = "Adding";
            this.rbAdding.UseVisualStyleBackColor = true;
            this.rbAdding.Click += new System.EventHandler(this.rbCrud_Click);
            // 
            // rbDeleting
            // 
            this.rbDeleting.AutoSize = true;
            this.rbDeleting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeleting.ForeColor = System.Drawing.Color.DeepPink;
            this.rbDeleting.Location = new System.Drawing.Point(244, 35);
            this.rbDeleting.Name = "rbDeleting";
            this.rbDeleting.Size = new System.Drawing.Size(96, 23);
            this.rbDeleting.TabIndex = 29;
            this.rbDeleting.TabStop = true;
            this.rbDeleting.Text = "Deleting";
            this.rbDeleting.UseVisualStyleBackColor = true;
            this.rbDeleting.Click += new System.EventHandler(this.rbCrud_Click);
            // 
            // rbReading
            // 
            this.rbReading.AutoSize = true;
            this.rbReading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReading.ForeColor = System.Drawing.Color.DeepPink;
            this.rbReading.Location = new System.Drawing.Point(56, 104);
            this.rbReading.Name = "rbReading";
            this.rbReading.Size = new System.Drawing.Size(94, 23);
            this.rbReading.TabIndex = 30;
            this.rbReading.TabStop = true;
            this.rbReading.Text = "Reading";
            this.rbReading.UseVisualStyleBackColor = true;
            this.rbReading.Click += new System.EventHandler(this.rbCrud_Click);
            // 
            // rbUpdating
            // 
            this.rbUpdating.AutoSize = true;
            this.rbUpdating.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpdating.ForeColor = System.Drawing.Color.DeepPink;
            this.rbUpdating.Location = new System.Drawing.Point(244, 104);
            this.rbUpdating.Name = "rbUpdating";
            this.rbUpdating.Size = new System.Drawing.Size(101, 23);
            this.rbUpdating.TabIndex = 31;
            this.rbUpdating.TabStop = true;
            this.rbUpdating.Text = "Updating";
            this.rbUpdating.UseVisualStyleBackColor = true;
            this.rbUpdating.Click += new System.EventHandler(this.rbCrud_Click);
            // 
            // gbCrudChoices
            // 
            this.gbCrudChoices.BackColor = System.Drawing.Color.Transparent;
            this.gbCrudChoices.Controls.Add(this.pictureBox6);
            this.gbCrudChoices.Controls.Add(this.rbObject);
            this.gbCrudChoices.Controls.Add(this.pictureBox5);
            this.gbCrudChoices.Controls.Add(this.rbAllOfObject);
            this.gbCrudChoices.Controls.Add(this.pictureBox3);
            this.gbCrudChoices.Controls.Add(this.rbUpdating);
            this.gbCrudChoices.Controls.Add(this.pictureBox4);
            this.gbCrudChoices.Controls.Add(this.rbReading);
            this.gbCrudChoices.Controls.Add(this.pictureBox2);
            this.gbCrudChoices.Controls.Add(this.rbDeleting);
            this.gbCrudChoices.Controls.Add(this.pictureBox1);
            this.gbCrudChoices.Controls.Add(this.rbAdding);
            this.gbCrudChoices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbCrudChoices.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrudChoices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbCrudChoices.Location = new System.Drawing.Point(22, 384);
            this.gbCrudChoices.Name = "gbCrudChoices";
            this.gbCrudChoices.Size = new System.Drawing.Size(362, 220);
            this.gbCrudChoices.TabIndex = 32;
            this.gbCrudChoices.TabStop = false;
            this.gbCrudChoices.Text = "Choose Curd Type";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(10, 158);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // rbObject
            // 
            this.rbObject.AutoSize = true;
            this.rbObject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbObject.ForeColor = System.Drawing.Color.DeepPink;
            this.rbObject.Location = new System.Drawing.Point(65, 173);
            this.rbObject.Name = "rbObject";
            this.rbObject.Size = new System.Drawing.Size(80, 23);
            this.rbObject.TabIndex = 40;
            this.rbObject.TabStop = true;
            this.rbObject.Text = "Object";
            this.rbObject.UseVisualStyleBackColor = true;
            this.rbObject.Click += new System.EventHandler(this.rbCrud_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(195, 158);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 39;
            this.pictureBox5.TabStop = false;
            // 
            // rbAllOfObject
            // 
            this.rbAllOfObject.AutoSize = true;
            this.rbAllOfObject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllOfObject.ForeColor = System.Drawing.Color.DeepPink;
            this.rbAllOfObject.Location = new System.Drawing.Point(244, 173);
            this.rbAllOfObject.Name = "rbAllOfObject";
            this.rbAllOfObject.Size = new System.Drawing.Size(103, 23);
            this.rbAllOfObject.TabIndex = 38;
            this.rbAllOfObject.TabStop = true;
            this.rbAllOfObject.Text = "GetingAll";
            this.rbAllOfObject.UseVisualStyleBackColor = true;
            this.rbAllOfObject.Click += new System.EventHandler(this.rbCrud_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 37;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(195, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 630);
            this.dataGridView1.TabIndex = 33;
            // 
            // btnAdding
            // 
            this.btnAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdding.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdding.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdding.Image = ((System.Drawing.Image)(resources.GetObject("btnAdding.Image")));
            this.btnAdding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdding.Location = new System.Drawing.Point(12, 771);
            this.btnAdding.Name = "btnAdding";
            this.btnAdding.Size = new System.Drawing.Size(179, 75);
            this.btnAdding.TabIndex = 24;
            this.btnAdding.Text = "Add";
            this.btnAdding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdding.UseVisualStyleBackColor = false;
            this.btnAdding.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopy.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(601, 771);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(149, 74);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(387, 771);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(207, 74);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1666, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 41);
            this.button2.TabIndex = 34;
            this.button2.Text = "Close";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(197, 771);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 75);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete\r\nText";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // rtxtbString
            // 
            this.rtxtbString.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxtbString.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbString.ForeColor = System.Drawing.Color.Chocolate;
            this.rtxtbString.Location = new System.Drawing.Point(771, 27);
            this.rtxtbString.Name = "rtxtbString";
            this.rtxtbString.Size = new System.Drawing.Size(889, 818);
            this.rtxtbString.TabIndex = 36;
            this.rtxtbString.Text = "";
            // 
            // CodeGenerator_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1750, 858);
            this.Controls.Add(this.rtxtbString);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdding);
            this.Controls.Add(this.gbCrudChoices);
            this.Controls.Add(this.rbBusinessLyaer);
            this.Controls.Add(this.rbDataLayer);
            this.Controls.Add(this.gbColumnChoices);
            this.Controls.Add(this.gbTableChoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CodeGenerator_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CodeGenerator_App_Load);
            this.gbTableChoices.ResumeLayout(false);
            this.gbTableChoices.PerformLayout();
            this.gbColumnChoices.ResumeLayout(false);
            this.gbColumnChoices.PerformLayout();
            this.gbCrudChoices.ResumeLayout(false);
            this.gbCrudChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton rbBusinessLyaer;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFunctionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDataLayer;
        private System.Windows.Forms.ComboBox cbFunctionType;
        private System.Windows.Forms.GroupBox gbTableChoices;
        private System.Windows.Forms.ComboBox cbColumnType;
        private System.Windows.Forms.TextBox txtAddColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbColumnChoices;
        private System.Windows.Forms.RadioButton rbNull;
        private System.Windows.Forms.RadioButton rbNotNull;
        private System.Windows.Forms.RadioButton rbAdding;
        private System.Windows.Forms.RadioButton rbDeleting;
        private System.Windows.Forms.RadioButton rbReading;
        private System.Windows.Forms.RadioButton rbUpdating;
        private System.Windows.Forms.GroupBox gbCrudChoices;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnAdding;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblClassname;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton rbAllOfObject;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox rtxtbString;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton rbObject;
    }
}

