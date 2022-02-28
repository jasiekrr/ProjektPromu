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
    class Semafory
    {
        public static int oczekujace_z_lewej = 0;
        public static int oczekujace_z_prawej = 0;
        public static int wolne_miejsca = 0;
        public static object pojedynczo = new object();
        public static Semaphore sem_lewy_brzeg = new Semaphore(0, 100);
        public static Semaphore sem_lewy_prom = new Semaphore(0, 1);
        public static Semaphore sem_lewy_na_promie = new Semaphore(0,100);
        public static Semaphore sem_prawy_brzeg = new Semaphore(0, 100);
        public static Semaphore sem_prawy_prom = new Semaphore(0, 1);
        public static Semaphore sem_prawy_na_promie = new Semaphore(0, 100);
        public static Label licznik_lewych = new Label();
        public static Label licznik_prawych = new Label();
        public Semafory()
        {

        }
    }
}
