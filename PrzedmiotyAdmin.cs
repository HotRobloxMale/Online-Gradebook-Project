﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tylka
{
    public partial class PrzedmiotyAdmin : UserControl
    {
        public PrzedmiotyAdmin()
        {
            InitializeComponent();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.przedmiotyBindingSource1.EndEdit();
            this.przedmiotyTableAdapter1.Update(onlinegradebookprojectDataSet1.Przedmioty);
        }

        private void PrzedmiotyAdmin_Load(object sender, EventArgs e)
        {
            this.przedmiotyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Przedmioty);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.przedmiotyTableAdapter1.Fill(onlinegradebookprojectDataSet1.Przedmioty);
        }
    }
}
