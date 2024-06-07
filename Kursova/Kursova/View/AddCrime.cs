using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursova.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova
{
    public partial class AddCrime : Form
    {
        public AddCrime()
        {
            InitializeComponent();

            List hairColorProvider = new List();
            comboBox1.Items.AddRange(hairColorProvider.GetHairColors().ToArray());
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            List eyeColorProvider = new List();
            comboBox2.Items.AddRange(eyeColorProvider.GetEyeColors().ToArray());
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            List countrieProvider = new List();
            comboBox3.Items.AddRange(countrieProvider.GetCountries().ToArray());
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            List criminalProfessionProvider = new List();
            comboBox4.Items.AddRange(criminalProfessionProvider.GetCriminalProfession().ToArray());
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            List languageProvider = new List();
            comboBox5.Items.AddRange(languageProvider.GetLanguages().ToArray());
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;

            var criminalGroups = DataAccess.ReadCrimeGroupsFromFile();
            crimeGroupBindingSource.DataSource = criminalGroups;
            comboBox6.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e) // КНОПКА ВІДМІНИ(ПІДТВЕРДЖЕННЯ ДІЇ)
        {

            //DialogResult result = MessageBox.Show("Ви хочете зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.No)
            //{
            //    this.DialogResult = DialogResult.Cancel;
            //    this.Close();
            //}
            using (ConfirmForm newForm = new ConfirmForm())
            {
                var result = newForm.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }

        }

        public void button2_Click(object sender, EventArgs e) // КНОПКА ДОДАТИ(ДЛЯ ДОДАВАННЯ ДАНИХ)
        {
            SaveData();
        }

        public void SaveData()
        {
            var firstName = textBox1.Text;
            var lastName = textBox2.Text;
            var nickname = textBox3.Text;
            var height = numericUpDown1.Value.ToString();
            var hairColor = comboBox1.Text;
            var eyeColor = comboBox2.Text;
            var specialMarks = textBox6.Text;
            var citizenship = comboBox3.Text;
            var birthPlace = textBox8.Text;
            var birthDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var lastResidence = textBox9.Text;
            var languages = comboBox5.Text;
            var criminalProfession = comboBox4.Text;

            int? crimeGroupId = null;
            if (comboBox6.SelectedItem != null)
            {
                crimeGroupId = (comboBox6.SelectedItem as CrimeGroup).Id;
            }

            List<Criminal> criminals = DataAccess.ReadCriminalsFromFile();
            int lastId = 0;
            if (criminals.Count > 0)
            {
                lastId = criminals[criminals.Count - 1].Id;
            }

            //
            if (ValidateFields())
            {
                // Proceed with form submission
                var line = string.Join("|", lastId + 1, firstName, lastName, nickname, height, hairColor, eyeColor, specialMarks, citizenship, 
                    birthPlace, birthDate, lastResidence, languages, criminalProfession, false, crimeGroupId);
                File.AppendAllText(DataAccess.FilePath, line + Environment.NewLine);
                MessageBox.Show("Форма успішно надіслана!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Show validation error
                MessageBox.Show("Виправте помилки та повторіть спробу.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //

            //var line = string.Join("|", lastId + 1, firstName, lastName, nickname, height, hairColor, eyeColor, specialMarks, citizenship, birthPlace, birthDate, lastResidence, languages, criminalProfession, false);

            //// Додаю рядок у файл
            //File.AppendAllText(filePath, line + Environment.NewLine);

            //MessageBox.Show("Дані успішно збережені.");

            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedHairColor = comboBox1.SelectedItem.ToString();

            var foundHairCriminals = new List<Criminal>();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEyeColor = comboBox2.SelectedItem.ToString();

            var foundEyeCriminals = new List<Criminal>();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCountrie = comboBox3.SelectedItem.ToString();

            var foundCountries = new List<Criminal>();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCriminalProfession = comboBox4.SelectedItem.ToString();

            var foundCriminalProfession = new List<Criminal>();

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLanguages = comboBox5.SelectedItem.ToString();

            var foundLanguage = new List<Criminal>();
        }
        private bool ValidateFields()
        {
            bool isValid = true;

            // Clear previous error messages
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider6.Clear();
            errorProvider7.Clear();
            errorProvider8.Clear();
            errorProvider9.Clear();
            errorProvider10.Clear();
            errorProvider11.Clear();
            errorProvider12.Clear();
            errorProvider13.Clear();

            // Validate First Name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Поле Ім'я обов'язкове для заповнення.");
                isValid = false;
            }
            else if (!Regex.IsMatch(textBox1.Text, @"^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ'\-\s]+$"))
            {
                errorProvider1.SetError(textBox1, "Ім'я недійсне.");
                isValid = false;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Поле Прізвище обов'язкове для заповнення.");
                isValid = false;
            }
            else if (!Regex.IsMatch(textBox2.Text, @"^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ'\-\s]+$"))
            {
                errorProvider2.SetError(textBox2, "Прізвище недійсне.");
                isValid = false;
            }

            // Validate Nickname
            if (!string.IsNullOrEmpty(textBox3.Text) && !Regex.IsMatch(textBox3.Text, @"^[a-zA-Zа-щА-ЩЬьЮюЯяЇїІіЄєҐґ0-9'\-\s]+$"))
            {
                errorProvider3.SetError(textBox3, "Кличка недійсна.");
                isValid = false;
            }

            // Validate Height
            if (!decimal.TryParse(numericUpDown1.Value.ToString(), out decimal heightValue) || heightValue < 130 || heightValue > 230)
            {
                errorProvider4.SetError(numericUpDown1, "Зріст недійсний.");
                isValid = false;
            }

            // Validate Hair Color
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider5.SetError(comboBox1, "Колір волосся обов'язковий для заповнення.");
                isValid = false;
            }

            // Validate Eye Color
            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                errorProvider6.SetError(comboBox2, "Колір очей обов'язковий для заповнення.");
                isValid = false;
            }

            // Validate Special Marks (Optional, can be empty)
            // No specific validation rules for special marks
            if (!string.IsNullOrEmpty(textBox6.Text) && !Regex.IsMatch(textBox6.Text, @"^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ'\-\s]+$"))
            {
                errorProvider12.SetError(textBox6, "Особлива прикмета недійсна.");
                isValid = false;
            }

            // Validate Citizenship
            if (string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                errorProvider7.SetError(comboBox3, "Громадянство обов'язкове для заповнення.");
                isValid = false;
            }

            // Validate Birth Place
            if (string.IsNullOrWhiteSpace(textBox8.Text))
            {
                errorProvider8.SetError(textBox8, "Місце народження обов'язкове для заповнення.");
                isValid = false;
            }
            else if (!Regex.IsMatch(textBox8.Text, @"^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ'\-\s]+$"))
            {
                errorProvider8.SetError(textBox8, "Місце народження недійсне.");
                isValid = false;
            }

            // Validate Birth Date

            DateTime minDate = DateTime.Now.AddYears(-80);
            DateTime maxDate = DateTime.Now.AddYears(-18);

            if (!DateTime.TryParseExact(dateTimePicker1.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDateValue))
            {
                errorProvider9.SetError(dateTimePicker1, "Дата народження обов'язкова для заповнення.");
                isValid = false;
            }
            else if (birthDateValue < minDate || birthDateValue > maxDate)
            {
                errorProvider9.SetError(dateTimePicker1, "Вік повинен бути від 18 до 80 років");
                isValid = false;
            }

            // Validate Last Residence
            if (string.IsNullOrWhiteSpace(textBox9.Text))
            {
                errorProvider10.SetError(textBox9, "Остання справа обов'язкова для заповнення.");
                isValid = false;
            }
            else if (!Regex.IsMatch(textBox8.Text, @"^[а-щА-ЩЬьЮюЯяЇїІіЄєҐґ'\-\s]+$"))
            {
                errorProvider10.SetError(textBox9, "Остання справа недійсна.");
                isValid = false;
            }

            // Validate Languages (Optional, can be empty)
            // No specific validation rules for languages
            //if (string.IsNullOrWhiteSpace(comboBox5.Text))
            //{
            //    errorProvider12.SetError(comboBox5, " обов'язковий для заповнення.");
            //    isValid = false;
            //}

            // Validate Criminal Profession
            if (string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                errorProvider11.SetError(comboBox4, "Злочинна професія обов'язкова для заповнення.");
                isValid = false;
            }

            return isValid;
        }
    }
}
