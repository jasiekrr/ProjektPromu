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
using System.Diagnostics;
using static Projekt_promu.Przeprawa;
using static Projekt_promu.Semafory;



namespace Projekt_promu
{

    class Prom : PictureBox
    {
        public static int pojemnosc;

        public int cierpliwosc;
        public double czas_oczekiwania;
        System.Windows.Forms.PictureBox rzeka;
        ProgressBar pasek_czasu = new ProgressBar();
        static Semafory zbior_semaforow = new Semafory();
        //stany promu:
        Stopwatch stoper = new Stopwatch();
        public Prom(int zaladunek,int czas, PictureBox rzeczka, ProgressBar pasek)
        {
            pasek_czasu = pasek;
            pojemnosc = zaladunek;
            rzeka = rzeczka;
            cierpliwosc = czas;
            pasek_czasu.Maximum = cierpliwosc;
            wolne_miejsca = zaladunek;
            this.BringToFront();
        }
        private void WPrawo()
        {
            while (wolne_miejsca < pojemnosc)
            {
                ;
            }
            stoper.Start();
            czas_oczekiwania = 0;
            while (true)
            {

                TimeSpan t = stoper.Elapsed;
                czas_oczekiwania = t.TotalSeconds;
                if(czas_oczekiwania <= cierpliwosc)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        pasek_czasu.Value = (int)(czas_oczekiwania);
                    }));
                }
                else
                {
                    this.Invoke(new Action(delegate ()
                    {
                        pasek_czasu.Value = cierpliwosc;
                    }));
                }
                if (czas_oczekiwania >= cierpliwosc && oczekujace_z_lewej < wolne_miejsca)
                {
                    if(oczekujace_z_prawej > oczekujace_z_lewej)
                    {
                        for (int i = 0; i < oczekujace_z_lewej; i++)
                        {
                            Interlocked.Decrement(ref oczekujace_z_lewej);
                            Interlocked.Decrement(ref wolne_miejsca);
                            this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                            {
                                licznik_lewych.Text = oczekujace_z_lewej.ToString();

                            }));
                            sem_lewy_brzeg.Release(); //prom pozwala autom wjechac
                            sem_lewy_prom.WaitOne();
                        }
                        stoper.Reset();
                        for (int i = 0; i < (pojemnosc - wolne_miejsca); i++)
                        {
                            sem_lewy_na_promie.Release();
                        }
                        while (this.Right < rzeka.Right)
                        {
                            Thread.Sleep(20);
                            this.Invoke(new Action(delegate ()
                            {
                                this.Left += 3;
                            }));
                        }
                        break;
                    }
                    else
                    {
                        if (oczekujace_z_lewej == 0)
                        {
                            ;
                        }
                        else
                        {
                            int oczekujace = oczekujace_z_lewej;
                            for (int i = 0; i < oczekujace; i++)
                            {
                                Interlocked.Decrement(ref oczekujace_z_lewej);
                                Interlocked.Decrement(ref wolne_miejsca);
                                this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                                {
                                    licznik_lewych.Text = oczekujace_z_lewej.ToString();

                                }));
                                sem_lewy_brzeg.Release(); //prom pozwala autom wjechac
                                sem_lewy_prom.WaitOne();
                            }
                            stoper.Reset();
                            for (int i = 0; i < (pojemnosc - wolne_miejsca); i++)
                            {
                                sem_lewy_na_promie.Release();
                            }
                            while (this.Right < rzeka.Right)
                            {
                                Thread.Sleep(20);
                                this.Invoke(new Action(delegate ()
                                {
                                    this.Left += 3;
                                }));
                            }
                            break;
                        }
                    }               
                }
                else if (oczekujace_z_lewej >= wolne_miejsca)
                {
                    while (wolne_miejsca > 0)
                    {
                        Interlocked.Decrement(ref oczekujace_z_lewej);
                        Interlocked.Decrement(ref wolne_miejsca);
                        this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                        {
                            licznik_lewych.Text = oczekujace_z_lewej.ToString();

                        }));
                        sem_lewy_brzeg.Release(); //prom pozwala autom wjechac
                        sem_lewy_prom.WaitOne();
                    }
                    //for(int i = 0;i<)
                    stoper.Reset();
                    for (int i = 0; i < (pojemnosc - wolne_miejsca); i++)
                    {
                        sem_lewy_na_promie.Release();
                    }
                    while (this.Right < rzeka.Right)
                    {
                        Thread.Sleep(20);
                        this.Invoke(new Action(delegate ()
                        {
                            this.Left += 3;
                        }));
                    }
                    break;
                }
                else if (czas_oczekiwania < cierpliwosc && oczekujace_z_lewej < wolne_miejsca)
                {
                    if (oczekujace_z_prawej >= pojemnosc)
                    {
                        while (oczekujace_z_lewej > 0)
                        {
                            Interlocked.Decrement(ref oczekujace_z_lewej);
                            Interlocked.Decrement(ref wolne_miejsca);
                            this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                            {
                                licznik_lewych.Text = oczekujace_z_lewej.ToString();

                            }));
                            sem_lewy_brzeg.Release(); //prom pozwala autom wjechac
                            sem_lewy_prom.WaitOne();
                        }
                        //for(int i = 0;i<)
                        stoper.Reset();
                        for (int i = 0; i < (pojemnosc - wolne_miejsca); i++)
                        {
                            sem_lewy_na_promie.Release();
                        }
                        while (this.Right < rzeka.Right)
                        {
                            Thread.Sleep(20);
                            this.Invoke(new Action(delegate ()
                            {
                                this.Left += 3;
                            }));
                        }
                        break;
                    }

                }
            }            
        }
        private void WLewo()
        {
            while (wolne_miejsca < pojemnosc)
            {
                //Thread.Sleep(10000);
            }
            stoper.Start();
            czas_oczekiwania = 0;
            while (true)
            {
                TimeSpan t = stoper.Elapsed;
                czas_oczekiwania = t.TotalSeconds;
                if (czas_oczekiwania <= cierpliwosc)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        pasek_czasu.Value = (int)(czas_oczekiwania);
                    }));
                }
                else
                {
                    this.Invoke(new Action(delegate ()
                    {
                        pasek_czasu.Value = cierpliwosc;
                    }));
                }
                if (czas_oczekiwania >= cierpliwosc && oczekujace_z_prawej < wolne_miejsca)
                {
                    if(oczekujace_z_lewej > oczekujace_z_prawej)
                    {
                        for (int i = 0; i < oczekujace_z_prawej; i++)
                        {
                            Interlocked.Decrement(ref oczekujace_z_prawej);
                            Interlocked.Decrement(ref wolne_miejsca);
                            this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                            {
                                licznik_prawych.Text = oczekujace_z_prawej.ToString();

                            }));
                            sem_prawy_brzeg.Release(); //prom pozwala autom wjechac
                            sem_prawy_prom.WaitOne();
                        }
                        stoper.Reset();
                        for (int i = 0; i < (pojemnosc - wolne_miejsca); i++)
                        {
                            sem_prawy_na_promie.Release();
                        }
                        while (this.Left > rzeka.Left)
                        {
                            Thread.Sleep(20);
                            this.Invoke(new Action(delegate ()
                            {
                                this.Left -= 3;
                            }));
                        }
                        break;
                    }
                    else
                    {
                        if (oczekujace_z_prawej == 0)
                        {
                            ;
                        }
                        else
                        {
                            int oczekujace = oczekujace_z_prawej;
                            for (int i = 0; i < oczekujace; i++)
                            {
                                Interlocked.Decrement(ref oczekujace_z_prawej);
                                Interlocked.Decrement(ref wolne_miejsca);
                                this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                                {
                                    licznik_prawych.Text = oczekujace_z_prawej.ToString();

                                }));
                                sem_prawy_brzeg.Release(); //prom pozwala autom wjechac
                                sem_prawy_prom.WaitOne();
                            }
                            stoper.Reset();
                            for (int i = 0; i < (pojemnosc - wolne_miejsca); i++)
                            {
                                sem_prawy_na_promie.Release();
                            }
                            while (this.Left > rzeka.Left)
                            {
                                Thread.Sleep(20);
                                this.Invoke(new Action(delegate ()
                                {
                                    this.Left -= 3;
                                }));
                            }
                            break;
                        }
                    }
                   
                }
                else if (oczekujace_z_prawej >= wolne_miejsca)
                {
                    while (wolne_miejsca > 0)
                    {
                        Interlocked.Decrement(ref oczekujace_z_prawej);
                        Interlocked.Decrement(ref wolne_miejsca);
                        this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                        {
                            licznik_prawych.Text = oczekujace_z_prawej.ToString();

                        }));
                        sem_prawy_brzeg.Release(); //prom pozwala autom wjechac
                        sem_prawy_prom.WaitOne();
                    }
                    //for(int i = 0;i<)
                    stoper.Reset();
                    for (int i = 0; i < (pojemnosc - wolne_miejsca); i++)
                    {
                        sem_prawy_na_promie.Release();
                    }
                    while (this.Left > rzeka.Left)
                    {
                        Thread.Sleep(20);
                        this.Invoke(new Action(delegate ()
                        {
                            this.Left -= 3;
                        }));
                    }
                    break;
                }
                else if (czas_oczekiwania < cierpliwosc && oczekujace_z_prawej < wolne_miejsca)
                {
                    if (oczekujace_z_lewej >= pojemnosc)
                    {
                        while (oczekujace_z_prawej > 0)
                        {
                            Interlocked.Decrement(ref oczekujace_z_prawej);
                            Interlocked.Decrement(ref wolne_miejsca);
                            this.Invoke(new Action(delegate () //zapewnienie synchronicznego dostępu do ekranu
                            {
                                licznik_prawych.Text = oczekujace_z_prawej.ToString();

                            }));
                            sem_prawy_brzeg.Release(); //prom pozwala autom wjechac
                            sem_prawy_prom.WaitOne();
                        }
                        //for(int i = 0;i<)
                        stoper.Reset();
                        for (int i = 0; i < (pojemnosc - wolne_miejsca); i++)
                        {
                            sem_prawy_na_promie.Release();
                        }
                        while (this.Left > rzeka.Left)
                        {
                            Thread.Sleep(20);
                            this.Invoke(new Action(delegate ()
                            {
                                this.Left -= 3;
                            }));
                        }
                        break;
                    }                    
                }
            }
        }
        public void FunkcjaWatkuPromu()
        {
            while(true)
            {
                WPrawo();
                WLewo();
            }
        }
    }
}
