using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursova.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova
{
    public partial class EditCard : Form
    {
        public Criminal criminal;
        public EditCard(Criminal criminal)
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

            List languageProvider = new List();
            comboBox5.Items.AddRange(languageProvider.GetLanguages().ToArray());
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;

            var criminalGroups = DataAccess.ReadCrimeGroupsFromFile();
            crimeGroupBindingSource.DataSource = criminalGroups;
            //comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;

            this.criminal = criminal;

            // Заповнюю поля даними з об'єкта criminal
            textBox1.Text = criminal.FirstName;
            textBox2.Text = criminal.LastName;
            textBox3.Text = criminal.Nickname;
            comboBox1.SelectedItem = criminal.HairColor;
            comboBox2.SelectedItem = criminal.EyeColor;
            comboBox3.SelectedItem = criminal.Citizenship;
            comboBox4.SelectedItem = criminal.CriminalProfession;
            comboBox5.SelectedItem = criminal.LanguagesString;
            textBox9.Text = criminal.LastResidence;
            textBox8.Text = criminal.BirthPlace;
            //var startbirthDate = DateOnly.FromDateTime(dateTimePicker1.Value);
            //dateTimePicker1.Value = criminal.BirthDate;

            textBox6.Text = criminal.SpecialMarks;
            numericUpDown1.Value = criminal.Height;

            comboBox6.SelectedItem = criminalGroups.Where(gr => gr.Id == criminal.CrimeGroupId).FirstOrDefault();

        }


        private void button2_Click(object sender, EventArgs e) // КНОПКА ЗБЕРЕЖЕННЯ ДАНИХ
        {
            criminal.FirstName = textBox1.Text;
            criminal.LastName = textBox2.Text;
            criminal.Nickname = textBox3.Text;
            criminal.HairColor = comboBox1.SelectedItem?.ToString();
            criminal.EyeColor = comboBox2.SelectedItem?.ToString();
            criminal.Citizenship = comboBox3.SelectedItem?.ToString();
            criminal.CriminalProfession = comboBox4.SelectedItem?.ToString();
            criminal.LanguagesString = comboBox5.SelectedItem?.ToString();
            criminal.LastResidence = textBox9.Text;
            criminal.BirthPlace = textBox8.Text;
            //criminal.BirthDate = dateTimePickerBirthDate.Value;

            ////criminal.BirthDate = dateTimePicker1.Value;

            criminal.SpecialMarks = textBox6.Text;
            criminal.Height = (int)numericUpDown1.Value;
            criminal.Archive = checkBox1.Checked;

            if (comboBox6.SelectedItem == null)
            {
                criminal.CrimeGroupId = null;
            }
            else
            {
                criminal.CrimeGroupId = (comboBox6.SelectedItem as CrimeGroup).Id;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

