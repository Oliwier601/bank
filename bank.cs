using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Klient
    {
        public int Id_Klienta;
        public int pesel;
        public int Nr_konta;
        public string password;
        public string name;
        public string lastname;

        public Klient(int Id_Klienta, int pesel, int Nr_konta, string password, string name, string lastname)
        {
            this.Id_Klienta = Id_Klienta;
            this.pesel = pesel;
            this.Nr_konta = Nr_konta;
            this.password = password;
            this.name = name;
            this.lastname = lastname;
        }
        public void setpassword(string password)
        {
            this.password = password;
        }
        public void logowanie()
        {
            Console.WriteLine("Podaj numer klienta");
            int Id_Klienta = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj hasło");
            string password = Console.ReadLine();
            if (this.Id_Klienta == Id_Klienta && this.password == password)
            {
                Console.WriteLine("Zalogowano pomyślnie");
            }
            else 
            { 
                Console.WriteLine("Błędny login lub hasło"); 
            }
        }
    }
    class Pracownik
    {
        public int Id_pracownika;
        public int Nr_konta;
        public string imie;
        public string nazwisko;
        public string password;
        public Pracownik(int Id_pracownika, string imie, string nazwisko, int Nr_konta, string password)
        {
            this.Id_pracownika = Id_pracownika;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.Nr_konta = Nr_konta;
            this.password = password;
        }
        public void setpassword(string password)
        {
            this.password = password;
        }
        public void logowanie()
        {
            Console.WriteLine("Podaj numer konta");
            int Nr_konta = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj hasło");
            string password = Console.ReadLine();
            if (this.Nr_konta == Nr_konta && this.password == password)
            {
                Console.WriteLine("Zalogowano pomyślnie");
            }
            else { Console.WriteLine("Błędny login lub hasło"); }
        }
    }


    class Kredyt
    {
        private Klient klient;
        private Pracownik pracownik;
        private Konto konto;

        public int kwota;
        public int id_kredytu;

        public Kredyt(int kwota, int id_klienta, int Id_pracownika)
        {
            this.kwota = kwota;
            this.klient.Id_Klienta = id_klienta;
            this.pracownik.Id_pracownika = Id_pracownika;
        }
        public void czy_spłacono()
        {
            if (konto.czy_kredyt == false) Console.WriteLine("spłacono");
            else Console.WriteLine("nie spłacono");
        }
    }
    class Konto
    {
        private Klient klient;
        private Kredyt kredyt;

        int ile_na_koncie;
        public bool czy_kredyt = false;
        public Konto(int id_kredytu, int id_klienta, int ile_na_koncie)
        {
            klient.Id_Klienta = id_klienta;
            kredyt.id_kredytu = id_kredytu;
            this.ile_na_koncie = ile_na_koncie;

        }
        public void setile(int ile_na_koncie)
        {
            this.ile_na_koncie = ile_na_koncie;
        }
        public void wyplata()
        {
            string a = "";
            do
            {
                Console.WriteLine("wpłacić czy wypłacić?");
                a = Console.ReadLine();
                if (a == "wpłać")
                {
                    Console.WriteLine("ile?");
                    this.ile_na_koncie += int.Parse(Console.ReadLine());

                }
                else if (a == "wypłać")
                {
                    Console.WriteLine("ile?");
                    this.ile_na_koncie -= int.Parse(Console.ReadLine());
                }
                else Console.WriteLine("błędne polecenia");

                if (this.ile_na_koncie < 0)
                {
                    this.czy_kredyt = true;
                }
                else
                {
                    this.czy_kredyt = false;
                }
            } while (a != "wpłać" || a != "wypłać");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
