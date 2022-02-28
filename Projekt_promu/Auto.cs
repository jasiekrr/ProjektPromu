using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using static Projekt_promu.Prom;
using static Projekt_promu.Semafory;

namespace Projekt_promu
{
    class Auto : PictureBox
    {
        static object mutex_wjazdu = new object();
        static object mutex_zjazdu = new object();
        public int lewe; //przyjmuje wartosci "1" lub "-1"
        public static int szerokosc = 30;
        public static int wysokosc = 30;
        public int speedx = 5;
        //Przeprawa prom;
        System.Windows.Forms.PictureBox rzeczka;
        Przeprawa promowa;
        Prom statek;
        //Semafory liczniki = new Semafory();

        public Auto(int kierunek, Przeprawa forma, PictureBox rzeka, Prom prom)
        {
            promowa = forma;
            rzeczka = rzeka;
            statek = prom;
            //definiowanie położenia auta na panelu:
            this.Width = szerokosc;
            this.Height = wysokosc;
            this.lewe = kierunek;
            if(kierunek == 1)
            {
                this.BackColor = Color.Red;
                this.Left = 1200 - szerokosc;
                this.Top = 300;
            }
            else
            {
                this.BackColor = Color.Green;
                this.Left = 0;
                this.Top = 300 + wysokosc;
            }
            this.Enabled = true;
            this.TabIndex = 1;
        }
        public void Dojazd()
        {
            while (((this.Right <= rzeczka.Left && lewe == -1) || (this.Left > rzeczka.Right && lewe == 1)) || ((this.Left >= rzeczka.Right && lewe == -1) || (this.Right < rzeczka.Left && lewe == 1)))
            {
                Thread.Sleep(20);
                if ((this.Left < 0 - this.Width) || (this.Left > 1200))
                {
                    break;
                }
                else
                {
                    this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                    {
                        this.Left -= (lewe * speedx);
                    }));
                }
            }
        }
        public void WjazdNaProm()
        {
            while (((this.Right <= (rzeczka.Left + 40)) && (lewe == -1)) || ((this.Left >= (rzeczka.Right - 40)) && (lewe == 1)))
            {
                Thread.Sleep(20);
                this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                {
                    this.Left -= (lewe * 1);
                }));
            }
        }
        public void PrzejazdPromem()
        {
            while(((this.Right <= (rzeczka.Right - 40)) && (lewe == -1)) || ((this.Left >= (rzeczka.Left + 40)) && (lewe == 1))) //podroz promem
            {
                Thread.Sleep(20);
                this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                {
                    this.Left -= (lewe * 3);
                }));
            }
        }
        public void ZjazdZPromu()
        {
            while (((this.Right >= (rzeczka.Right - 40)) && (lewe == -1)) || ((this.Left <= (rzeczka.Left + 40)) && (lewe == 1))) //zjazd z promu
            {
                Thread.Sleep(20);
                this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                {
                    this.Left -= (lewe * 1);
                }));
                if(this.Right >= rzeczka.Right + 40 || this.Left <= rzeczka.Left - 40)
                {
                    break;
                }
            }
        }
        public void RuchAuta()
        {
            Dojazd();
            if(this.lewe == -1)
            {
                Interlocked.Increment(ref oczekujace_z_lewej);
                this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                {
                    licznik_lewych.Text = oczekujace_z_lewej.ToString();
                }));
                sem_lewy_brzeg.WaitOne();
            }
            else
            {
                Interlocked.Increment(ref oczekujace_z_prawej);
                this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                {
                    licznik_prawych.Text = oczekujace_z_prawej.ToString();
                }));
                sem_prawy_brzeg.WaitOne();
            }
            Monitor.Enter(mutex_wjazdu);
            WjazdNaProm();
            Monitor.Exit(mutex_wjazdu);
            if (this.lewe == -1)
            {
                sem_lewy_prom.Release();
                sem_lewy_na_promie.WaitOne();
            }
            else
            {
                sem_prawy_prom.Release();
                sem_prawy_na_promie.WaitOne();
            }
            PrzejazdPromem();
            Monitor.Enter(mutex_zjazdu);
            ZjazdZPromu();
            Interlocked.Increment(ref wolne_miejsca);
            Monitor.Exit(mutex_zjazdu);
            Dojazd();
        }
        
    }
}
