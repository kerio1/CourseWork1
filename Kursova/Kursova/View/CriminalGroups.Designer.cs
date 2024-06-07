namespace Kursova
{
    partial class CriminalGroups
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            crimeGroupBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
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
            languagesStringDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            criminalProfessionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            archiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            crimeGroupIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            criminalBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crimeGroupBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)criminalBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridView1.DataSource = crimeGroupBindingSource;
            dataGridView1.Location = new Point(12, 38);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(313, 326);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 59;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 90;
            // 
            // crimeGroupBindingSource
            // 
            crimeGroupBindingSource.DataSource = typeof(Models.CrimeGroup);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, lastNameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, nicknameDataGridViewTextBoxColumn, heightDataGridViewTextBoxColumn, hairColorDataGridViewTextBoxColumn, eyeColorDataGridViewTextBoxColumn, specialMarksDataGridViewTextBoxColumn, citizenshipDataGridViewTextBoxColumn, birthPlaceDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, lastResidenceDataGridViewTextBoxColumn, languagesStringDataGridViewTextBoxColumn, criminalProfessionDataGridViewTextBoxColumn, archiveDataGridViewCheckBoxColumn, crimeGroupIdDataGridViewTextBoxColumn });
            dataGridView2.DataSource = criminalBindingSource;
            dataGridView2.Location = new Point(358, 38);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(755, 326);
            dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "ID";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 59;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Ім'я";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 72;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 121;
            // 
            // nicknameDataGridViewTextBoxColumn
            // 
            nicknameDataGridViewTextBoxColumn.DataPropertyName = "Nickname";
            nicknameDataGridViewTextBoxColumn.HeaderText = "Кличка";
            nicknameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nicknameDataGridViewTextBoxColumn.Name = "nicknameDataGridViewTextBoxColumn";
            nicknameDataGridViewTextBoxColumn.ReadOnly = true;
            nicknameDataGridViewTextBoxColumn.Width = 98;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            heightDataGridViewTextBoxColumn.HeaderText = "Height";
            heightDataGridViewTextBoxColumn.MinimumWidth = 6;
            heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            heightDataGridViewTextBoxColumn.ReadOnly = true;
            heightDataGridViewTextBoxColumn.Visible = false;
            heightDataGridViewTextBoxColumn.Width = 125;
            // 
            // hairColorDataGridViewTextBoxColumn
            // 
            hairColorDataGridViewTextBoxColumn.DataPropertyName = "HairColor";
            hairColorDataGridViewTextBoxColumn.HeaderText = "HairColor";
            hairColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            hairColorDataGridViewTextBoxColumn.Name = "hairColorDataGridViewTextBoxColumn";
            hairColorDataGridViewTextBoxColumn.ReadOnly = true;
            hairColorDataGridViewTextBoxColumn.Visible = false;
            hairColorDataGridViewTextBoxColumn.Width = 125;
            // 
            // eyeColorDataGridViewTextBoxColumn
            // 
            eyeColorDataGridViewTextBoxColumn.DataPropertyName = "EyeColor";
            eyeColorDataGridViewTextBoxColumn.HeaderText = "EyeColor";
            eyeColorDataGridViewTextBoxColumn.MinimumWidth = 6;
            eyeColorDataGridViewTextBoxColumn.Name = "eyeColorDataGridViewTextBoxColumn";
            eyeColorDataGridViewTextBoxColumn.ReadOnly = true;
            eyeColorDataGridViewTextBoxColumn.Visible = false;
            eyeColorDataGridViewTextBoxColumn.Width = 125;
            // 
            // specialMarksDataGridViewTextBoxColumn
            // 
            specialMarksDataGridViewTextBoxColumn.DataPropertyName = "SpecialMarks";
            specialMarksDataGridViewTextBoxColumn.HeaderText = "SpecialMarks";
            specialMarksDataGridViewTextBoxColumn.MinimumWidth = 6;
            specialMarksDataGridViewTextBoxColumn.Name = "specialMarksDataGridViewTextBoxColumn";
            specialMarksDataGridViewTextBoxColumn.ReadOnly = true;
            specialMarksDataGridViewTextBoxColumn.Visible = false;
            specialMarksDataGridViewTextBoxColumn.Width = 125;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            citizenshipDataGridViewTextBoxColumn.MinimumWidth = 6;
            citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            citizenshipDataGridViewTextBoxColumn.ReadOnly = true;
            citizenshipDataGridViewTextBoxColumn.Visible = false;
            citizenshipDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthPlaceDataGridViewTextBoxColumn
            // 
            birthPlaceDataGridViewTextBoxColumn.DataPropertyName = "BirthPlace";
            birthPlaceDataGridViewTextBoxColumn.HeaderText = "BirthPlace";
            birthPlaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthPlaceDataGridViewTextBoxColumn.Name = "birthPlaceDataGridViewTextBoxColumn";
            birthPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            birthPlaceDataGridViewTextBoxColumn.Visible = false;
            birthPlaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            birthDateDataGridViewTextBoxColumn.Width = 169;
            // 
            // lastResidenceDataGridViewTextBoxColumn
            // 
            lastResidenceDataGridViewTextBoxColumn.DataPropertyName = "LastResidence";
            lastResidenceDataGridViewTextBoxColumn.HeaderText = "LastResidence";
            lastResidenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastResidenceDataGridViewTextBoxColumn.Name = "lastResidenceDataGridViewTextBoxColumn";
            lastResidenceDataGridViewTextBoxColumn.ReadOnly = true;
            lastResidenceDataGridViewTextBoxColumn.Visible = false;
            lastResidenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // languagesStringDataGridViewTextBoxColumn
            // 
            languagesStringDataGridViewTextBoxColumn.DataPropertyName = "LanguagesString";
            languagesStringDataGridViewTextBoxColumn.HeaderText = "LanguagesString";
            languagesStringDataGridViewTextBoxColumn.MinimumWidth = 6;
            languagesStringDataGridViewTextBoxColumn.Name = "languagesStringDataGridViewTextBoxColumn";
            languagesStringDataGridViewTextBoxColumn.ReadOnly = true;
            languagesStringDataGridViewTextBoxColumn.Visible = false;
            languagesStringDataGridViewTextBoxColumn.Width = 125;
            // 
            // criminalProfessionDataGridViewTextBoxColumn
            // 
            criminalProfessionDataGridViewTextBoxColumn.DataPropertyName = "CriminalProfession";
            criminalProfessionDataGridViewTextBoxColumn.HeaderText = "Злочинна професія";
            criminalProfessionDataGridViewTextBoxColumn.MinimumWidth = 6;
            criminalProfessionDataGridViewTextBoxColumn.Name = "criminalProfessionDataGridViewTextBoxColumn";
            criminalProfessionDataGridViewTextBoxColumn.ReadOnly = true;
            criminalProfessionDataGridViewTextBoxColumn.Width = 182;
            // 
            // archiveDataGridViewCheckBoxColumn
            // 
            archiveDataGridViewCheckBoxColumn.DataPropertyName = "Archive";
            archiveDataGridViewCheckBoxColumn.HeaderText = "Archive";
            archiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            archiveDataGridViewCheckBoxColumn.Name = "archiveDataGridViewCheckBoxColumn";
            archiveDataGridViewCheckBoxColumn.ReadOnly = true;
            archiveDataGridViewCheckBoxColumn.Visible = false;
            archiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // crimeGroupIdDataGridViewTextBoxColumn
            // 
            crimeGroupIdDataGridViewTextBoxColumn.DataPropertyName = "CrimeGroupId";
            crimeGroupIdDataGridViewTextBoxColumn.HeaderText = "CrimeGroupId";
            crimeGroupIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            crimeGroupIdDataGridViewTextBoxColumn.Name = "crimeGroupIdDataGridViewTextBoxColumn";
            crimeGroupIdDataGridViewTextBoxColumn.ReadOnly = true;
            crimeGroupIdDataGridViewTextBoxColumn.Visible = false;
            crimeGroupIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // criminalBindingSource
            // 
            criminalBindingSource.DataSource = typeof(Criminal);
            // 
            // button1
            // 
            button1.Location = new Point(12, 372);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(196, 36);
            button1.TabIndex = 2;
            button1.Text = "Показати учасників";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(475, 372);
            button2.Name = "button2";
            button2.Size = new Size(233, 36);
            button2.TabIndex = 3;
            button2.Text = "Видалити угруповання";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(225, 372);
            button3.Name = "button3";
            button3.Size = new Size(231, 36);
            button3.TabIndex = 4;
            button3.Text = "Додати угруповання";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 5;
            label1.Text = "Злочинні угруповання";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 6;
            label2.Text = "Учасники";
            // 
            // button4
            // 
            button4.Location = new Point(724, 371);
            button4.Name = "button4";
            button4.Size = new Size(165, 36);
            button4.TabIndex = 7;
            button4.Text = "Редагувати";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 415);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 31);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 421);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 9;
            label3.Text = "Пошук угрупованнь";
            // 
            // CriminalGroups
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1130, 459);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximumSize = new Size(1148, 506);
            MinimumSize = new Size(1148, 506);
            Name = "CriminalGroups";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CriminalGroups";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)crimeGroupBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)criminalBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource crimeGroupBindingSource;
        private DataGridView dataGridView2;
        private BindingSource criminalBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
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
        private DataGridViewTextBoxColumn languagesStringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn criminalProfessionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn archiveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn crimeGroupIdDataGridViewTextBoxColumn;
        private Label label1;
        private Label label2;
        private Button button4;
        private TextBox textBox1;
        private Label label3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}