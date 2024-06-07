using System.Text.RegularExpressions;
using System.Windows.Forms;
using Kursova.Models;

namespace Kursova
{
    public partial class CardIndex : Form
    {
        List<Criminal> criminals = [];

        public CardIndex()
        {
            InitializeComponent();

            criminals = DataAccess.ReadCriminalsFromFile();
            var activeCriminals = new List<Criminal>();
            foreach (var criminal in criminals)
            {
                if (criminal.Archive == false)
                {
                    activeCriminals.Add(criminal);
                }
            }
            dataGridView1.DataSource = activeCriminals;

            List hairColorProvider = new List();
            comboBox1.Items.AddRange(hairColorProvider.GetHairColors().ToArray());

            List eyeColorProvider = new List();
            comboBox2.Items.AddRange(eyeColorProvider.GetEyeColors().ToArray());

            List countrieProvider = new List();
            comboBox4.Items.AddRange(countrieProvider.GetCountries().ToArray());

            List criminalProfessionProvider = new List();
            comboBox6.Items.AddRange(criminalProfessionProvider.GetCriminalProfession().ToArray());

            List languageProvider = new List();
            comboBox3.Items.AddRange(languageProvider.GetLanguages().ToArray());
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // КНОПКА ДОДАННЯ ЗЛОЧИНЦЯ
        {
            //AddCrime newForm = new AddCrime();
            //newForm.Show();

            using (AddCrime newForm = new AddCrime())
            {
                var result = newForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    criminals = DataAccess.ReadCriminalsFromFile();
                    var activeCriminals = new List<Criminal>();
                    foreach (var criminal in criminals)
                    {
                        if (criminal.Archive == false)
                        {
                            activeCriminals.Add(criminal);
                        }
                    }
                    dataGridView1.DataSource = activeCriminals;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) // КНОПКА ВИДАЛЕННЯ ЗЛОЧИНЦЯ
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < criminals.Count)
                {
                    criminals.RemoveAt(selectedIndex);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = criminals;
                    DataAccess.WriteCriminalsToFile(criminals);
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок для редагування.");
            }
        }

        private void Searchbutton1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e) // КНОПКА РЕДАГУВАННЯ ЗЛОЧИНЦЯ
        {
            //using (EditCard newForm = new EditCard())
            //{
            //    var result = newForm.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        criminals = DataAccess.ReadCriminalsFromFile();
            //        dataGridView1.DataSource = criminals;
            //    }
            //}
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Отримую виділений об'єкт Criminal
                var selectedCriminal = (Criminal)dataGridView1.SelectedRows[0].DataBoundItem;

                // Створюю та показую форму для редагування
                using (var newForm = new EditCard(selectedCriminal))
                {
                    var result = newForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        // Оновлюю дані у списку criminals
                        var updatedCriminal = newForm.criminal;
                        //int selectedIndex = dataGridView1.SelectedRows[0].Index;
                        //criminals[selectedIndex] = updatedCriminal;

                        for (int i = 0; i < criminals.Count; i++)
                        {
                            if (criminals[i].Id == updatedCriminal.Id)
                            {
                                criminals[i] = updatedCriminal;
                            }
                        }

                        dataGridView1.DataSource = null;

                        DataAccess.WriteCriminalsToFile(criminals);

                        var activeCriminals = new List<Criminal>();
                        foreach (var criminal in criminals)
                        {
                            if (criminal.Archive == false)
                            {
                                activeCriminals.Add(criminal);
                            }
                        }
                        dataGridView1.DataSource = activeCriminals;
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок для редагування.");
            }

        }
        private void clearbutton_Click(object sender, EventArgs e) // КНОПКА ОЧИЩЕННЯ ПОЛІВ
        {
            firstNametextBox1.Text = "";
            lastNametextBox2.Text = "";
            nicknametextBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox4.Text = "";
            comboBox3.Text = "";
            comboBox6.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            dateTimePicker1.Text = "01.01.1900";
            dateTimePicker2.Text = "";
            textBox2.Text = "";
            numericUpDown1.Text = "130";
            numericUpDown2.Text = "230";

            //dataGridView1.DataSource = criminals;
            var activeCriminals = new List<Criminal>();
            foreach (var criminal in criminals)
            {
                if (criminal.Archive == false)
                {
                    activeCriminals.Add(criminal);
                }
            }
            dataGridView1.DataSource = activeCriminals;

            label18.Visible = false;
        }

        private void FilterCriminals()
        {
            var firstName = firstNametextBox1.Text;
            var lastName = lastNametextBox2.Text;
            var nickname = nicknametextBox3.Text;
            var selectedHairColor = comboBox1.SelectedItem?.ToString();
            var selectedEyeColor = comboBox2.SelectedItem?.ToString();
            var selectedCountrie = comboBox4.SelectedItem?.ToString();
            var selectedCriminalProfession = comboBox6.SelectedItem?.ToString();
            var lastResidence = textBox3.Text;
            var birthPlace = textBox1.Text;
            var selectedlanguages = comboBox3.SelectedItem?.ToString();

            //var birthDate = dateTimePicker1.Value.ToShortDateString();

            var startbirthDate = DateOnly.FromDateTime(dateTimePicker1.Value);
            var endBirthDate = DateOnly.FromDateTime(dateTimePicker2.Value);

            var startHeight = numericUpDown1.Value;
            var endHeight = numericUpDown2.Value;


            var specialMarks = textBox2.Text;

            var archive = checkBox1.Checked;


            var foundCharacteristicsCriminals = new List<Criminal>();
            foreach (var criminal in criminals)
            {
                if (
                    (selectedHairColor != null && !criminal.HairColor.Equals(selectedHairColor, StringComparison.OrdinalIgnoreCase))
                    || (selectedEyeColor != null && !criminal.EyeColor.Equals(selectedEyeColor, StringComparison.OrdinalIgnoreCase))
                    || (selectedCountrie != null && !criminal.Citizenship.Equals(selectedCountrie, StringComparison.OrdinalIgnoreCase))
                    || (selectedlanguages != null && !criminal.LanguagesString.Equals(selectedlanguages, StringComparison.OrdinalIgnoreCase))
                    || (selectedCriminalProfession != null && !criminal.CriminalProfession.Equals(selectedCriminalProfession, StringComparison.OrdinalIgnoreCase))
                    || !criminal.LastResidence.ToLower().Contains(lastResidence.ToLower())
                    || !criminal.FirstName.ToLower().Contains(firstName.ToLower())
                    || !criminal.LastName.ToLower().Contains(lastName.ToLower())
                    || !criminal.Nickname.ToLower().Contains(nickname.ToLower())
                    || !criminal.BirthPlace.ToLower().Contains(birthPlace.ToLower())

                    //|| !criminal.BirthDate.ToShortDateString().Equals(birthDate)

                    || criminal.BirthDate <= startbirthDate || criminal.BirthDate >= endBirthDate

                    || criminal.Height < startHeight || criminal.Height > endHeight

                    || !criminal.SpecialMarks.ToLower().Contains(specialMarks.ToLower())
                    || criminal.Archive != archive
                    )
                {
                    continue;
                }
                else
                {
                    foundCharacteristicsCriminals.Add(criminal);
                }
            }

            dataGridView1.DataSource = foundCharacteristicsCriminals;

            // Відображення повідомлення, якщо результатів немає
            if (foundCharacteristicsCriminals.Count == 0)
            {
                label18.Text = "Злочинців не знайдено";
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void firstNametextBox1_TextChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void lastNametextBox2_TextChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void nicknametextBox3_TextChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CriminalGroups newForm = new CriminalGroups())
            {
                var result = newForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    criminals = DataAccess.ReadCriminalsFromFile();
                    dataGridView1.DataSource = criminals;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            FilterCriminals();
        }
    }
}
