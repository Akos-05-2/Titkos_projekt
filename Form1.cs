using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OA_Titkos_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolNew_Click(object sender, EventArgs e)
        {
            new FormCreate().ShowDialog();
            dataGridViewCargo.DataSource = CargoRepository.FindAll();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CargoRepository.Path = openFileDialog1.FileName;
                dataGridViewCargo.DataSource = CargoRepository.FindAll();
                Text = $"Cargo - {openFileDialog1.FileName}";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by: Olajkár Ákos");
        }
    }
}
