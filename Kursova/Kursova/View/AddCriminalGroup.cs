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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova
{
    public partial class AddCriminalGroup : Form
    {
        public AddCriminalGroup()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e) // КНОПКА ДОДАННЯ УГРУПУВАННЯ
        {
            SaveData();
        }

        public void SaveData()
        {
            var nameCriminalGroup = textBox1.Text;

            // Зчитуємо всі існуючі угрупування
            List<CrimeGroup> crimeGroups = DataAccess.ReadCrimeGroupsFromFile();

            // Визначаємо останній ID
            int lastId = 0;
            if (crimeGroups.Count > 0)
            {
                lastId = crimeGroups[crimeGroups.Count - 1].Id;
            }

            var line = string.Join("|", lastId + 1, nameCriminalGroup);
            File.AppendAllText(DataAccess.FilePathCriminalGroups, line + Environment.NewLine);
            MessageBox.Show("Форма успішно надіслана!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
