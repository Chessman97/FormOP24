namespace InterfaceTable
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AccountingTab = new System.Windows.Forms.TabControl();
            this.accountingPage = new System.Windows.Forms.TabPage();
            this.accountTable = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdSystem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BeatenSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionPage = new System.Windows.Forms.TabPage();
            this.conditionsTable = new System.Windows.Forms.DataGridView();
            this.Number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Code1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.dateDocument = new System.Windows.Forms.DateTimePicker();
            this.numberDocument = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.viewOperation = new System.Windows.Forms.TextBox();
            this.viewOKPD = new System.Windows.Forms.TextBox();
            this.formOKPO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.organName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.organStruct = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dopDocument = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.AccountingTab.SuspendLayout();
            this.accountingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountTable)).BeginInit();
            this.conditionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditionsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountingTab
            // 
            this.AccountingTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AccountingTab.Controls.Add(this.accountingPage);
            this.AccountingTab.Controls.Add(this.conditionPage);
            this.AccountingTab.Location = new System.Drawing.Point(12, 162);
            this.AccountingTab.Name = "AccountingTab";
            this.AccountingTab.SelectedIndex = 0;
            this.AccountingTab.Size = new System.Drawing.Size(1062, 447);
            this.AccountingTab.TabIndex = 0;
            this.AccountingTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.AccountingTab_Selected);
            // 
            // accountingPage
            // 
            this.accountingPage.Controls.Add(this.accountTable);
            this.accountingPage.Location = new System.Drawing.Point(4, 22);
            this.accountingPage.Name = "accountingPage";
            this.accountingPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountingPage.Size = new System.Drawing.Size(1054, 421);
            this.accountingPage.TabIndex = 0;
            this.accountingPage.Text = "Страница 1";
            this.accountingPage.UseVisualStyleBackColor = true;
            // 
            // accountTable
            // 
            this.accountTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.accountTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Title,
            this.Code,
            this.EdSystem,
            this.BeatenSum,
            this.LostNum,
            this.LostSum,
            this.TotalNum,
            this.TotalSum});
            this.accountTable.Location = new System.Drawing.Point(6, 6);
            this.accountTable.Name = "accountTable";
            this.accountTable.Size = new System.Drawing.Size(1042, 440);
            this.accountTable.TabIndex = 0;
            this.accountTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountTable_CellContentClick);
            this.accountTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.accountTable_CellValueChanged);
            this.accountTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.accountTable_RowsAdded);
            this.accountTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.accountTable_UserDeletingRow);
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер по порядку";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Recname";
            this.Title.HeaderText = "Наименование";
            this.Title.Name = "Title";
            // 
            // Code
            // 
            this.Code.FillWeight = 10F;
            this.Code.HeaderText = "Код";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EdSystem
            // 
            this.EdSystem.FillWeight = 10F;
            this.EdSystem.HeaderText = "Ед.";
            this.EdSystem.Name = "EdSystem";
            this.EdSystem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EdSystem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BeatenSum
            // 
            this.BeatenSum.FillWeight = 15F;
            this.BeatenSum.HeaderText = "Код по ОКЕИ";
            this.BeatenSum.Name = "BeatenSum";
            this.BeatenSum.ReadOnly = true;
            // 
            // LostNum
            // 
            this.LostNum.FillWeight = 22.77342F;
            this.LostNum.HeaderText = "Масса штучного изделия";
            this.LostNum.Name = "LostNum";
            // 
            // LostSum
            // 
            this.LostSum.FillWeight = 22.77342F;
            this.LostSum.HeaderText = "Цена продажи, руб. коп.";
            this.LostSum.Name = "LostSum";
            // 
            // TotalNum
            // 
            this.TotalNum.FillWeight = 22.77342F;
            this.TotalNum.HeaderText = "Количество выпущено, шт.";
            this.TotalNum.Name = "TotalNum";
            // 
            // TotalSum
            // 
            this.TotalSum.FillWeight = 22.77342F;
            this.TotalSum.HeaderText = "Сумма выпущенных, руб., коп.";
            this.TotalSum.Name = "TotalSum";
            this.TotalSum.ReadOnly = true;
            // 
            // conditionPage
            // 
            this.conditionPage.Controls.Add(this.conditionsTable);
            this.conditionPage.Location = new System.Drawing.Point(4, 22);
            this.conditionPage.Name = "conditionPage";
            this.conditionPage.Padding = new System.Windows.Forms.Padding(3);
            this.conditionPage.Size = new System.Drawing.Size(1054, 421);
            this.conditionPage.TabIndex = 1;
            this.conditionPage.Text = "Страница 2";
            this.conditionPage.UseVisualStyleBackColor = true;
            // 
            // conditionsTable
            // 
            this.conditionsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conditionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conditionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number1,
            this.Title1,
            this.Code1,
            this.Condition,
            this.Note,
            this.Pro,
            this.Column1});
            this.conditionsTable.Location = new System.Drawing.Point(6, 6);
            this.conditionsTable.Name = "conditionsTable";
            this.conditionsTable.Size = new System.Drawing.Size(1042, 415);
            this.conditionsTable.TabIndex = 1;
            this.conditionsTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.conditionsTable_CellValueChanged);
            this.conditionsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.conditionsTable_RowsAdded);
            this.conditionsTable.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.conditionsTable_UserDeletingRow);
            // 
            // Number1
            // 
            this.Number1.FillWeight = 60.80187F;
            this.Number1.HeaderText = "Номер";
            this.Number1.Name = "Number1";
            this.Number1.ReadOnly = true;
            this.Number1.Visible = false;
            // 
            // Title1
            // 
            this.Title1.FillWeight = 57.22024F;
            this.Title1.HeaderText = "Наименование";
            this.Title1.Name = "Title1";
            // 
            // Code1
            // 
            this.Code1.FillWeight = 10F;
            this.Code1.HeaderText = "Код";
            this.Code1.Name = "Code1";
            this.Code1.ReadOnly = true;
            this.Code1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Code1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Condition
            // 
            this.Condition.FillWeight = 15F;
            this.Condition.HeaderText = "Сдано в экспедицию количество";
            this.Condition.Name = "Condition";
            // 
            // Note
            // 
            this.Note.FillWeight = 15F;
            this.Note.HeaderText = "Сумма, руб. коп.";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Pro
            // 
            this.Pro.FillWeight = 15F;
            this.Pro.HeaderText = "Прочий расход количество";
            this.Pro.Name = "Pro";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 15F;
            this.Column1.HeaderText = "Прочий расход сумма, руб. коп.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(129, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ведомость №";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(303, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата";
            // 
            // total
            // 
            this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(6, 40);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(80, 20);
            this.total.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(508, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(508, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "учета движения готовых изделий в кондитерском и других цехах ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnToExcel
            // 
            this.btnToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToExcel.Location = new System.Drawing.Point(946, 641);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(101, 34);
            this.btnToExcel.TabIndex = 20;
            this.btnToExcel.Text = "Экспорт в Excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // dateDocument
            // 
            this.dateDocument.Location = new System.Drawing.Point(357, 11);
            this.dateDocument.Name = "dateDocument";
            this.dateDocument.Size = new System.Drawing.Size(145, 20);
            this.dateDocument.TabIndex = 23;
            // 
            // numberDocument
            // 
            this.numberDocument.Location = new System.Drawing.Point(249, 11);
            this.numberDocument.Mask = "0000000";
            this.numberDocument.Name = "numberDocument";
            this.numberDocument.Size = new System.Drawing.Size(48, 20);
            this.numberDocument.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(815, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Вид операции";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(815, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Вид деятельности по ОКПД";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(815, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Форма по ОКПО";
            // 
            // viewOperation
            // 
            this.viewOperation.Location = new System.Drawing.Point(970, 121);
            this.viewOperation.Name = "viewOperation";
            this.viewOperation.Size = new System.Drawing.Size(100, 20);
            this.viewOperation.TabIndex = 2;
            // 
            // viewOKPD
            // 
            this.viewOKPD.Location = new System.Drawing.Point(970, 95);
            this.viewOKPD.Name = "viewOKPD";
            this.viewOKPD.Size = new System.Drawing.Size(100, 20);
            this.viewOKPD.TabIndex = 1;
            // 
            // formOKPO
            // 
            this.formOKPO.Location = new System.Drawing.Point(970, 68);
            this.formOKPO.Name = "formOKPO";
            this.formOKPO.Size = new System.Drawing.Size(100, 20);
            this.formOKPO.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Название организации";
            // 
            // organName
            // 
            this.organName.FormattingEnabled = true;
            this.organName.Items.AddRange(new object[] {
            "OOO \"Выпечка\"",
            "OOO \"Форне\"",
            "OOO \"Алтай-торт\""});
            this.organName.Location = new System.Drawing.Point(166, 70);
            this.organName.Name = "organName";
            this.organName.Size = new System.Drawing.Size(336, 21);
            this.organName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Структурное подразделение";
            // 
            // organStruct
            // 
            this.organStruct.FormattingEnabled = true;
            this.organStruct.Items.AddRange(new object[] {
            "Магазин",
            "Пекарня"});
            this.organStruct.Location = new System.Drawing.Point(166, 101);
            this.organStruct.Name = "organStruct";
            this.organStruct.Size = new System.Drawing.Size(336, 21);
            this.organStruct.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Приложение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "документов";
            // 
            // dopDocument
            // 
            this.dopDocument.Location = new System.Drawing.Point(90, 23);
            this.dopDocument.Name = "dopDocument";
            this.dopDocument.Size = new System.Drawing.Size(95, 20);
            this.dopDocument.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dopDocument);
            this.groupBox1.Location = new System.Drawing.Point(48, 615);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 79);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дополнительно";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Location = new System.Drawing.Point(330, 615);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 79);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Итого";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(496, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "Сумма";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(396, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Количество";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(482, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(396, 40);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 20);
            this.textBox5.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(310, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Сумма";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(210, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Количество";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(296, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(210, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Сумма";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Количество";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(92, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(436, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Прочий расход";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Сдано сумма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Выпущенно";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 47);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 13);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Расшифровка подписей";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.organName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.viewOperation);
            this.Controls.Add(this.dateDocument);
            this.Controls.Add(this.viewOKPD);
            this.Controls.Add(this.organStruct);
            this.Controls.Add(this.formOKPO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numberDocument);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.AccountingTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1102, 1080);
            this.MinimumSize = new System.Drawing.Size(1102, 400);
            this.Name = "MainForm";
            this.Text = "Ведомость учета движения готовых изделий в кондитерском и других цехах";
            this.AccountingTab.ResumeLayout(false);
            this.accountingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountTable)).EndInit();
            this.conditionPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conditionsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AccountingTab;
        private System.Windows.Forms.TabPage accountingPage;
        private System.Windows.Forms.DataGridView accountTable;
        private System.Windows.Forms.TabPage conditionPage;
        private System.Windows.Forms.DataGridView conditionsTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.DateTimePicker dateDocument;
        private System.Windows.Forms.MaskedTextBox numberDocument;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox viewOperation;
        private System.Windows.Forms.TextBox viewOKPD;
        private System.Windows.Forms.TextBox formOKPO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox organName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox organStruct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dopDocument;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewComboBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewComboBoxColumn EdSystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeatenSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

