﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.dziennik_funkcje;

namespace Tylka.apkrodzic
{
    public partial class PlansRodzic : UserControl
    {
        public PlansRodzic()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plansbindingSource1.EndEdit();
            this.dniTableAdapter.Update(onlinegradebookprojectDataSet1.Dni);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dniTableAdapter.Fill(onlinegradebookprojectDataSet1.Dni);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }

        private void PlansRodzic_Load(object sender, EventArgs e)
        {
            this.dniTableAdapter.Fill(onlinegradebookprojectDataSet1.Dni);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
