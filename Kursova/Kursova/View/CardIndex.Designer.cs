namespace Kursova
{
    partial class CardIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nicknameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            heightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hairColorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eyeColorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            specialMarksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            citizenshipDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthPlaceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastResidenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            criminalProfessionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            LanguagesString = new DataGridViewTextBoxColumn();
            criminalBindingSource = new BindingSource(components);
            Searchbutton1 = new Button();
            AddCardCriminal = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            содержимоеToolStripMenuItem = new ToolStripMenuItem();
            индексToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            опрограммеToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            firstNametextBox1 = new TextBox();
            label2 = new Label();
            lastNametextBox2 = new TextBox();
            label3 = new Label();
            nicknametextBox3 = new TextBox();
            clearbutton = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            comboBox4 = new ComboBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            comboBox6 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label14 = new Label();
            comboBox3 = new ComboBox();
            label15 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)criminalBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, nicknameDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, hairColorDataGridViewTextBoxColumn, eyeColorDataGridViewTextBoxColumn, specialMarksDataGridViewTextBoxColumn, citizenshipDataGridViewTextBoxColumn, birthPlaceDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, lastResidenceDataGridViewTextBoxColumn, criminalProfessionDataGridViewTextBoxColumn, LanguagesString });
            dataGridView1.DataSource = criminalBindingSource;
            dataGridView1.Location = new Point(17, 36);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1873, 498);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 56;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Ім'я";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 69;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 115;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            nicknameDataGridViewTextBoxColumn.HeaderText = "Кличка";
            nicknameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            nicknameDataGridViewTextBoxColumn.Width = 95;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Зріст";
            heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.ReadOnly = true;
            heightDataGridViewTextBoxColumn.Width = 77;
            // 
            // hairColorDataGridViewTextBoxColumn
            // 
            hairColorDataGridViewTextBoxColumn.DataPropertyName = "HairColor";
            hairColorDataGridViewTextBoxColumn.HeaderText = "Колір волосся";
            hairColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            hairColorDataGridViewTextBoxColumn.Name = "hairColorDataGridViewTextBoxColumn";
            hairColorDataGridViewTextBoxColumn.ReadOnly = true;
            hairColorDataGridViewTextBoxColumn.Width = 137;
            // 
            // eyeColorDataGridViewTextBoxColumn
            // 
            eyeColorDataGridViewTextBoxColumn.DataPropertyName = "EyeColor";
            eyeColorDataGridViewTextBoxColumn.HeaderText = "Колір очей";
            eyeColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            eyeColorDataGridViewTextBoxColumn.Name = "eyeColorDataGridViewTextBoxColumn";
            eyeColorDataGridViewTextBoxColumn.ReadOnly = true;
            eyeColorDataGridViewTextBoxColumn.Width = 116;
            // 
            // specialMarksDataGridViewTextBoxColumn
            // 
            specialMarksDataGridViewTextBoxColumn.DataPropertyName = "SpecialMarks";
            specialMarksDataGridViewTextBoxColumn.HeaderText = "Особливі прикмети";
            specialMarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            specialMarksDataGridViewTextBoxColumn.Name = "specialMarksDataGridViewTextBoxColumn";
            specialMarksDataGridViewTextBoxColumn.ReadOnly = true;
            specialMarksDataGridViewTextBoxColumn.Width = 176;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            citizenshipDataGridViewTextBoxColumn.HeaderText = "Громадянство";
            citizenshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            citizenshipDataGridViewTextBoxColumn.ReadOnly = true;
            citizenshipDataGridViewTextBoxColumn.Width = 150;
            // 
            // birthPlaceDataGridViewTextBoxColumn
            // 
            birthPlaceDataGridViewTextBoxColumn.DataPropertyName = "BirthPlace";
            birthPlaceDataGridViewTextBoxColumn.HeaderText = "Місце народження";
            birthPlaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthPlaceDataGridViewTextBoxColumn.Name = "birthPlaceDataGridViewTextBoxColumn";
            birthPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            birthPlaceDataGridViewTextBoxColumn.Width = 173;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            birthDateDataGridViewTextBoxColumn.Width = 164;
            // 
            // lastResidenceDataGridViewTextBoxColumn
            // 
            lastResidenceDataGridViewTextBoxColumn.DataPropertyName = "LastResidence";
            lastResidenceDataGridViewTextBoxColumn.HeaderText = "Остання справа";
            lastResidenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastResidenceDataGridViewTextBoxColumn.Name = "lastResidenceDataGridViewTextBoxColumn";
            lastResidenceDataGridViewTextBoxColumn.ReadOnly = true;
            lastResidenceDataGridViewTextBoxColumn.Width = 151;
            // 
            // criminalProfessionDataGridViewTextBoxColumn
            // 
            criminalProfessionDataGridViewTextBoxColumn.DataPropertyName = "CriminalProfession";
            criminalProfessionDataGridViewTextBoxColumn.HeaderText = "Злочинна професія";
            criminalProfessionDataGridViewTextBoxColumn.MinimumWidth = 6;
            criminalProfessionDataGridViewTextBoxColumn.Name = "criminalProfessionDataGridViewTextBoxColumn";
            criminalProfessionDataGridViewTextBoxColumn.ReadOnly = true;
            criminalProfessionDataGridViewTextBoxColumn.Width = 176;
            // 
            // LanguagesString
            // 
            LanguagesString.DataPropertyName = "LanguagesString";
            LanguagesString.HeaderText = "Знання мови";
            LanguagesString.MinimumWidth = 6;
            LanguagesString.Name = "LanguagesString";
            LanguagesString.ReadOnly = true;
            LanguagesString.Width = 130;
            // 
            // criminalBindingSource
            // 
            criminalBindingSource.DataSource = typeof(Criminal);
            // 
            // Searchbutton1
            // 
            Searchbutton1.Location = new Point(17, 672);
            Searchbutton1.Margin = new Padding(4);
            Searchbutton1.Name = "Searchbutton1";
            Searchbutton1.Size = new Size(125, 36);
            Searchbutton1.TabIndex = 1;
            Searchbutton1.Text = "Пошук";
            Searchbutton1.UseVisualStyleBackColor = true;
            Searchbutton1.Click += Searchbutton1_Click;
            // 
            // AddCardCriminal
            // 
            AddCardCriminal.Location = new Point(270, 588);
            AddCardCriminal.Margin = new Padding(4);
            AddCardCriminal.Name = "AddCardCriminal";
            AddCardCriminal.Size = new Size(118, 30);
            AddCardCriminal.TabIndex = 2;
            AddCardCriminal.Text = "Додати";
            AddCardCriminal.UseVisualStyleBackColor = true;
            AddCardCriminal.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(270, 544);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(118, 30);
            button3.TabIndex = 3;
            button3.Text = "Редагувати";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(270, 631);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(118, 30);
            button4.TabIndex = 4;
            button4.Text = "Видалити";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 1, 0, 1);
            menuStrip1.Size = new Size(1905, 26);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { содержимоеToolStripMenuItem, индексToolStripMenuItem, поискToolStripMenuItem, toolStripSeparator5, опрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(77, 24);
            справкаToolStripMenuItem.Text = "&Довідка";
            // 
            // содержимоеToolStripMenuItem
            // 
            содержимоеToolStripMenuItem.Name = "содержимоеToolStripMenuItem";
            содержимоеToolStripMenuItem.Size = new Size(224, 26);
            содержимоеToolStripMenuItem.Text = "&Содержимое";
            // 
            // индексToolStripMenuItem
            // 
            индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            индексToolStripMenuItem.Size = new Size(224, 26);
            индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(224, 26);
            поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(221, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            опрограммеToolStripMenuItem.Size = new Size(224, 26);
            опрограммеToolStripMenuItem.Text = "&О программе…";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 548);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 6;
            label1.Text = "Ім'я";
            // 
            // firstNametextBox1
            // 
            firstNametextBox1.Location = new Point(105, 544);
            firstNametextBox1.Margin = new Padding(4);
            firstNametextBox1.Name = "firstNametextBox1";
            firstNametextBox1.Size = new Size(140, 30);
            firstNametextBox1.TabIndex = 7;
            firstNametextBox1.TextChanged += firstNametextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 592);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 8;
            label2.Text = "Прізвище";
            // 
            // lastNametextBox2
            // 
            lastNametextBox2.Location = new Point(105, 588);
            lastNametextBox2.Margin = new Padding(4);
            lastNametextBox2.Name = "lastNametextBox2";
            lastNametextBox2.Size = new Size(140, 30);
            lastNametextBox2.TabIndex = 9;
            lastNametextBox2.TextChanged += lastNametextBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 635);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 10;
            label3.Text = "Кличка";
            // 
            // nicknametextBox3
            // 
            nicknametextBox3.Location = new Point(105, 631);
            nicknametextBox3.Margin = new Padding(4);
            nicknametextBox3.Name = "nicknametextBox3";
            nicknametextBox3.Size = new Size(140, 30);
            nicknametextBox3.TabIndex = 11;
            nicknametextBox3.TextChanged += nicknametextBox3_TextChanged;
            // 
            // clearbutton
            // 
            clearbutton.Location = new Point(150, 672);
            clearbutton.Margin = new Padding(4);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(95, 36);
            clearbutton.TabIndex = 12;
            clearbutton.Text = "Очистити";
            clearbutton.UseVisualStyleBackColor = true;
            clearbutton.Click += clearbutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 548);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 13;
            label4.Text = "Колір волосся";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(599, 544);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 31);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 592);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 15;
            label5.Text = "Колір очей";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(599, 588);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 31);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(418, 635);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(164, 23);
            label6.TabIndex = 17;
            label6.Text = "Особливі прикмети";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(800, 548);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 19;
            label7.Text = "Громадянство";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(973, 544);
            comboBox4.Margin = new Padding(4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(170, 31);
            comboBox4.TabIndex = 20;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(800, 592);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(160, 23);
            label8.TabIndex = 21;
            label8.Text = "Місце народження";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(973, 588);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 30);
            textBox1.TabIndex = 22;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(800, 635);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(151, 23);
            label9.TabIndex = 23;
            label9.Text = "Дата народження";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1017, 631);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.MaxDate = new DateTime(2024, 5, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 30);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1179, 548);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(136, 23);
            label10.TabIndex = 25;
            label10.Text = "Остання справа";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1179, 592);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(164, 23);
            label11.TabIndex = 27;
            label11.Text = "Злочинна професія";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(1364, 588);
            comboBox6.Margin = new Padding(4);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(170, 31);
            comboBox6.TabIndex = 28;
            comboBox6.SelectedIndexChanged += comboBox6_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(599, 631);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 30);
            textBox2.TabIndex = 29;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1364, 544);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 30);
            textBox3.TabIndex = 30;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(1018, 672);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.MaxDate = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(126, 30);
            dateTimePicker2.TabIndex = 31;
            dateTimePicker2.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(973, 635);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(33, 23);
            label12.TabIndex = 32;
            label12.Text = "Від";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(973, 676);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(32, 23);
            label13.TabIndex = 33;
            label13.Text = "До";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(1551, 544);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(339, 161);
            button1.TabIndex = 34;
            button1.Text = "Злочинні угруповання";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1460, 671);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 27);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Архів";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(418, 676);
            label14.Name = "label14";
            label14.Size = new Size(113, 23);
            label14.TabIndex = 36;
            label14.Text = "Знання мови";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(599, 672);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(170, 31);
            comboBox3.TabIndex = 37;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1179, 635);
            label15.Name = "label15";
            label15.Size = new Size(48, 23);
            label15.TabIndex = 38;
            label15.Text = "Зріст";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1271, 631);
            numericUpDown1.Maximum = new decimal(new int[] { 230, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(72, 30);
            numericUpDown1.TabIndex = 39;
            numericUpDown1.Value = new decimal(new int[] { 130, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(1271, 672);
            numericUpDown2.Maximum = new decimal(new int[] { 230, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(72, 30);
            numericUpDown2.TabIndex = 40;
            numericUpDown2.Value = new decimal(new int[] { 230, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1233, 635);
            label16.Name = "label16";
            label16.Size = new Size(33, 23);
            label16.TabIndex = 41;
            label16.Text = "Від";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1233, 675);
            label17.Name = "label17";
            label17.Size = new Size(32, 23);
            label17.TabIndex = 42;
            label17.Text = "До";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label18.Location = new Point(195, 217);
            label18.Name = "label18";
            label18.Size = new Size(226, 81);
            label18.TabIndex = 43;
            label18.Text = "label18";
            label18.Visible = false;
            // 
            // CardIndex
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1905, 714);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label15);
            Controls.Add(comboBox3);
            Controls.Add(label14);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dateTimePicker2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox6);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(dateTimePicker1);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(comboBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(clearbutton);
            Controls.Add(nicknametextBox3);
            Controls.Add(label3);
            Controls.Add(lastNametextBox2);
            Controls.Add(label2);
            Controls.Add(firstNametextBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(AddCardCriminal);
            Controls.Add(Searchbutton1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximumSize = new Size(1923, 761);
            MinimumSize = new Size(1809, 761);
            Name = "CardIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Card-Index";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)criminalBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button Searchbutton1;
        private Button AddCardCriminal;
        private Button button3;
        private Button button4;
        private BindingSource criminalBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem содержимоеToolStripMenuItem;
        private ToolStripMenuItem индексToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private Label label1;
        private TextBox firstNametextBox1;
        private Label label2;
        private TextBox lastNametextBox2;
        private Label label3;
        private TextBox nicknametextBox3;
        private Button clearbutton;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private Label label7;
        private ComboBox comboBox4;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label11;
        private ComboBox comboBox6;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private Label label13;
        private Button button1;
        //private BindingSource languagesBindingSource;
        private CheckBox checkBox1;
        private Label label14;
        private ComboBox comboBox3;
        private Label label15;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label16;
        private Label label17;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nicknameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hairColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eyeColorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specialMarksDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthPlaceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastResidenceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn criminalProfessionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LanguagesString;
        private Label label18;
    }
}
