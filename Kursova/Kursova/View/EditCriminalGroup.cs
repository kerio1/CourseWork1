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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursova
{
    public partial class EditCriminalGroup : Form
    {
        public CrimeGroup crimegroup;
        public EditCriminalGroup(CrimeGroup crimegroup)
        {
            InitializeComponent();

            this.crimegroup = crimegroup;

            textBox1.Text = crimegroup.Name;
        }
        private void button1_Click(object sender, EventArgs e) // КНОПКА ЗБЕРЕЖЕННЯ ДАНИХ
        {
            crimegroup.Name = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
