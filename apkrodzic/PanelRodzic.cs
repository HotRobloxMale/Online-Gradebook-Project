﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.apknauczyciel;
using Tylka.apkuczen;
using Tylka.dziennik_funkcje;

namespace Tylka.apkrodzic
{
    public partial class PanelRodzic : Form
    {
        public PanelRodzic()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            UserData.admin = false;
            chowaj();
        }

        private void chowaj()
        {
            classRodzic1.Hide();
            plansRodzic1.Hide();
            przedmiotyRodzic1.Hide();
            examsRodzic1.Hide();
            ocenyRodzic1.Hide();
            edycjaDanychRodzic1.Hide();
            message1.Hide();
            home1.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            chowaj();
            home1.Show();
        }

        private void Klasy_Click(object sender, EventArgs e)
        {
            chowaj();
            classRodzic1.Show();
        }

        private void Plany_Lekcji_Click(object sender, EventArgs e)
        {
            chowaj();
            plansRodzic1.Show();
        }

        private void Przedmioty_Click(object sender, EventArgs e)
        {
            chowaj();
            przedmiotyRodzic1.Show();
        }

        private void Sprawdziany_Click(object sender, EventArgs e)
        {
            chowaj();
            examsRodzic1.Show();
        }

        private void PanelRodzic_Load(object sender, EventArgs e)
        {
            classRodzic1.Parent = this.gradient1;
            plansRodzic1.Parent = this.gradient1;
            przedmiotyRodzic1.Parent = this.gradient1;
            examsRodzic1.Parent = this.gradient1; 
            home1.Parent = this.gradient1;
            home1.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            chowaj();
            ocenyRodzic1.Show();
        }

        private void Edycja_Danych_Click(object sender, EventArgs e)
        {
            chowaj();
            edycjaDanychRodzic1.Show();
        }

        private void wiadomosci_Click(object sender, EventArgs e)
        {
            chowaj();
            message1.Show();
        }
    }
}
