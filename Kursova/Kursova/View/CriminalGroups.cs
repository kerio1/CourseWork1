using Kursova.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class CriminalGroups : Form
    {
        List<CrimeGroup> criminalGroups = [];
        public CriminalGroups()
        {
            InitializeComponent();

            criminalGroups = DataAccess.ReadCrimeGroupsFromFile();
            dataGridView1.DataSource = criminalGroups;
        }

        private void button1_Click(object sender, EventArgs e) // КНОПКА ПОКАЗУ УЧАСНИКІВ
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Отримую виділений об'єкт
                var selectedCrimeGroup = (CrimeGroup)dataGridView1.SelectedRows[0].DataBoundItem;

                var criminals = DataAccess.ReadCriminalsFromFile();
                var groupCriminals = new List<Criminal>();
                foreach (var criminal in criminals)
                {
                    if (criminal.Archive == false && criminal.CrimeGroupId == selectedCrimeGroup.Id)
                    {
                        groupCriminals.Add(criminal);
                    }
                }
                dataGridView2.DataSource = groupCriminals;
            }
            else
            {
                MessageBox.Show("Виберіть рядок для редагування.");
            }
        }

        private void button2_Click(object sender, EventArgs e) // КНОПКА ВИДАЛЕННЯ УГРУПУВАННЯ
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Отримую виділений об'єкт
                var selectedCrimeGroup = (CrimeGroup)dataGridView1.SelectedRows[0].DataBoundItem;

                // 'видаляємо' злочинців з угрупування
                var criminals = DataAccess.ReadCriminalsFromFile();
                for (int i = 0; i < criminals.Count; i++)
                {
                    if (criminals[i].CrimeGroupId == selectedCrimeGroup.Id)
                    {
                        criminals[i].CrimeGroupId = null;
                    }
                }
                DataAccess.WriteCriminalsToFile(criminals);
                dataGridView2.DataSource = null;

                // видаляємо угрупування
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < criminals.Count)
                {
                    criminalGroups.RemoveAt(selectedIndex);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = criminalGroups;
                    DataAccess.WriteCrimeGroupsToFile(criminalGroups);
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок для редагування.");
            }
        }

        private void button3_Click(object sender, EventArgs e) // КНОПКА ДОДАВАННЯ УГРУПУВАННЯ
        {
            using (AddCriminalGroup newForm = new AddCriminalGroup())
            {
                var result = newForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //this.DialogResult = DialogResult.Cancel;
                    //this.Close();
                    criminalGroups = DataAccess.ReadCrimeGroupsFromFile();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = criminalGroups;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // ПОЛЕ З ПОШУКОМ ЗЛОЧИННИХ УГРУПОВАННЬ
        {
            var nameCriminalGroup = textBox1.Text;
            var foundCriminalGroup = new List<CrimeGroup>();
            foreach (var criminal in criminalGroups)
            {
                if (!criminal.Name.ToLower().Contains(nameCriminalGroup.ToLower()))
                {
                    continue;
                }
                else
                {
                    foundCriminalGroup.Add(criminal);
                }
            }

            dataGridView1.DataSource = foundCriminalGroup;
        }

        private void button4_Click(object sender, EventArgs e) // КПОПКА РЕДАГУВАННЯ
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Отримую виділений об'єкт
                var selectedCrimeGroup = (CrimeGroup)dataGridView1.SelectedRows[0].DataBoundItem;

                // Відкриваю форму редагування
                var editForm = new EditCriminalGroup(selectedCrimeGroup);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Зберігаю зміни
                    DataAccess.WriteCrimeGroupsToFile(criminalGroups);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = criminalGroups;

                    // Оновлення DataGridView2, якщо потрібно
                    //var criminals = DataAccess.ReadCriminalsFromFile();
                    //dataGridView2.DataSource = criminals;
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок для редагування.");
            }
        }
    }
}
