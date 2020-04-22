using System;
using System.Globalization;

namespace FuncsDataHora {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);



            // DATE TIME

            // DateTime d = DateTime.Now;
            //string s1 = d.ToString("yy/MM/dd HH:mm:ss");

            //Console.WriteLine("1) Data: " + d.Date);
            //Console.WriteLine("2) Dia: " + d.Day);
            //Console.WriteLine("3) Dia da Semana: " + d.DayOfWeek);
            //Console.WriteLine("4) Dia do Ano: " + d.DayOfYear);
            //Console.WriteLine("5) Ano: " + d.Year);
            //Console.WriteLine("7) Mês: " + d.Month);
            //Console.WriteLine("6) Hora: " + d.Hour);
            //Console.WriteLine("7) Minuto: " + d.Minute);
            //Console.WriteLine("8) Segundo: " + d.Second);

            //Console.WriteLine("-----------------");

            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToShortTimeString());
            //Console.WriteLine(s1);

            // OPREAÇÔES COM DATAS

            //DateTime d = new DateTime(2020, 8, 15, 13, 45, 58);

            //DateTime d1 = d.AddHours(2);
            //DateTime d2 = d.AddDays(1);
            //DateTime d3 = d.AddMinutes(3);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);


            //DateTime d1 = new DateTime(2018, 11, 25);
            //DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 03);

            //DateTime d3 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;
            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("15-08-2000");

            //DateTime d3 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d4 = DateTime.ParseExact("15/08/2000", "dd-MM-yyyy", CultureInfo.InvariantCulture);

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d2);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);

            // TIME SPAN

            //TimeSpan t1 = new TimeSpan(2, 3, 5, 7, 11);

            //Console.WriteLine(t1);

            //Console.WriteLine("Dias: " + t1.Days);
            //Console.WriteLine("Horas: " + t1.Hours);
            //Console.WriteLine("Minutos: " + t1.Minutes);

            //Console.WriteLine("Total Dias: " + t1.TotalDays);
            //Console.WriteLine("Total Horas: " + t1.TotalHours);
            //Console.WriteLine("Total Minutos: " + t1.TotalMinutes);

            // OPREAÇÔES COM TIMESPAN

            //TimeSpan t1 = new TimeSpan(1, 30, 10);
            //TimeSpan t2 = new TimeSpan(1, 10, 5);

            //TimeSpan sum = t1.Add(t2);
            //TimeSpan dif = t1.Subtract(t2);
            //TimeSpan mult = t1.Multiply(2.0);
            //TimeSpan div = t1.Divide(2.0);

            //Console.WriteLine(t1);
            //Console.WriteLine(sum);
            //Console.WriteLine(dif);


            //TimeSpan t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(9000000000L);
            //TimeSpan t3 = new TimeSpan(0, 1, 30);
            //TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

            //Console.WriteLine(t2);

            //TimeSpan t1 = TimeSpan.FromDays(1.5);
            //TimeSpan t2 = TimeSpan.FromHours(1.5);
            //Console.WriteLine(t1);
        }
    }
}
