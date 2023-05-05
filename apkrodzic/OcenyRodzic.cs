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
    public partial class OcenyRodzic : UserControl
    {
        public OcenyRodzic()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        private void OcenyRodzic_Load(object sender, EventArgs e)
        {
            this.ocenyTableAdapter.Fill(onlinegradebookprojectDataSet.Oceny);
            Resize_data TaH = new Resize_data();
            TaH.Table_auto_size(dataGridView1);
        }
    }
}
