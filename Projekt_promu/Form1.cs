using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using static Projekt_promu.Auto;
using static Projekt_promu.Prom;


namespace Projekt_promu
{

    public partial class Przeprawa : Form
    {
        int szerokosc_rzeki = 0;
        int pojemnosc_promu = 0;
        int prog_cierpliwosci = 0;
        int ile_aut_lewych = 0;
        int ile_aut_prawych = 0;
        public int iterator_lewych = 1;
        public int iterator_prawych = 1;
        Prom statek;
        public Przeprawa()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // sprawdzenie, czy wszystkie dane wprowadzone, jeśli tak:
            UstawieniaGRBX.Enabled = false;
            btnStart.Enabled = true;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;
            szerokosc_rzeki = (int)numericSzerokosc.Value;
            pojemnosc_promu = (int)numericPojemnosc.Value;
            prog_cierpliwosci = (int)numericProg.Value;
            ile_aut_lewych = (int)numericAutaLewe.Value;
            ile_aut_prawych = (int)numericAutaPrawe.Value;
            //MessageBox.Show("wprowadzone dane to: " + szerokosc_rzeki + "TEST: " + numericSzerokosc.Value, "TEST");
            dopasujRzeke(szerokosc_rzeki);
            Semafory.licznik_lewych.Left = 150;
            Semafory.licznik_lewych.Top = 95;
            Semafory.licznik_prawych.Left = 1100;
            Semafory.licznik_prawych.Top = 95;
            ekran.Controls.Add(Semafory.licznik_lewych);
            ekran.Controls.Add(Semafory.licznik_prawych);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result_wyjscia =  MessageBox.Show("Czy na pewno chcesz wyjść?","Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result_wyjscia == DialogResult.Yes)
            {
                Environment.Exit(0);
            }           
        }
        private void dopasujRzeke(int szerokosc)
        {
            rzeka.Width = szerokosc;
            rzeka.Location = new Point((ekran.Width / 2) - (szerokosc / 2), 0);
        }
        private void spawnProm()
        {
            statek = new Prom(pojemnosc_promu, prog_cierpliwosci, rzeka,pasek_czasu);
            statek.Enabled = true;
            statek.Left = rzeka.Left;
            statek.Width = 80;
            statek.Height = 70;
            statek.Top = 295;
            statek.BackColor = Color.DarkKhaki;
            ekran.Controls.Add(statek);
            //rzeka.Visible = false;
            Thread watek_promu = new Thread(statek.FunkcjaWatkuPromu);
            watek_promu.Start();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            spawnProm();
            rzeka.SendToBack();
            btnStart.Enabled = false;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (iterator_lewych < ile_aut_lewych)
            {
                iterator_lewych++;
                string name = "auto" + iterator_lewych;
                Auto autoLewe = new Auto(-1, this, rzeka, statek);
                Thread autoLeweW = new Thread(autoLewe.RuchAuta);
                ekran.Controls.Add(autoLewe);
                autoLewe.BringToFront();
                autoLeweW.Start();
            }
            else if(iterator_lewych == ile_aut_lewych)
            {
                string name = "auto" + iterator_lewych;
                Auto autoLewe = new Auto(-1, this, rzeka, statek);
                Thread autoLeweW = new Thread(autoLewe.RuchAuta);
                ekran.Controls.Add(autoLewe);
                autoLeweW.Start();
                autoLewe.BringToFront();
                btnLeft.Enabled = false;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if(iterator_prawych < ile_aut_prawych)
            {
                iterator_prawych++;
                Auto autoPrawe = new Auto(1, this, rzeka, statek);
                Thread autoPraweW = new Thread(autoPrawe.RuchAuta);
                ekran.Controls.Add(autoPrawe);
                autoPrawe.BringToFront();
                autoPraweW.Start();
            }
            else if(iterator_prawych == ile_aut_prawych)
            {
                Auto autoPrawe = new Auto(1, this, rzeka, statek);
                Thread autoPraweW = new Thread(autoPrawe.RuchAuta);
                ekran.Controls.Add(autoPrawe);
                autoPrawe.BringToFront();
                autoPraweW.Start();
                btnRight.Enabled = false;
            }
        }
    }
}
