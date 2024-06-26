﻿using System;
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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo()
            {
                Date = DateTime.Parse(textBoxDate.Text),
                Source = textBoxSource.Text,
                Destination = textBoxDestination.Text,
                Good = comboBoxGoods.Text,
                Quantity = int.Parse(textBoxQuantity.Text)
            };
            CargoRepository.Save(cargo);
            MessageBox.Show("New object added");
        }
    }
}
