using System;

namespace Hotel_Check_in_Programm
{
    class Program
    {
        
            static (bool, short, string, string, short, double) GetData(short diff, short[] zn, string[] vn, string[] nn, short[] ün, double[] rb)
            {

                bool flag = false;
                int index = 0;
                for (int h = 0; h < zn.Length; h++)
                {
                    if (diff == zn[h])
                    {
                        index = h;
                        flag = true;
                    }
                }
                return (flag, zn[index], vn[index], nn[index], ün[index], rb[index]);

            }
            static (bool, short, string, string, short, double) GetData(string diff, short[] zn, string[] vn, string[] nn, short[] ün, double[] rb)
            {
                {
                    bool flag = false;
                    int index = 0;
                    for (int i = 0; i < nn.Length; i++)
                    {
                        if (diff == nn[i])
                        {
                            index = i;
                            flag = true;
                        }
                    }
                    return (flag, zn[index], vn[index], nn[index], ün[index], rb[index]);

                }
            }
            static void Main(string[] args)
            {
                do
                {
                    short[] zimmernummer = { 45, 23, 3, 32 };
                    string[] vorname = { "John", "Paul", "George", "Ringo" };
                    string[] Nachname = { "Lennon", "McCartney", "Harrison", "Starr" };
                    short[] übernachtung = { 1, 4, 12, 3 };
                    double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };
                    bool flag = false;
                    Console.WriteLine("Bitte geben Sie Nachnamen oder Zimmernummer ein");
                    string eingabe_str = Console.ReadLine();
                    short eingabe_short;

                    flag = short.TryParse(eingabe_str, out eingabe_short);

                    if (flag == true)
                    {
                        var daten = GetData(eingabe_short, zimmernummer, vorname, Nachname, übernachtung, rechnungsbetrag);
                        if (daten.Item1 == true)
                        {
                            Console.WriteLine($"{ daten.Item2},{ daten.Item3},{ daten.Item4},{daten.Item5},{daten.Item6}");

                        }
                        else
                        {
                            Console.WriteLine("kein gegnstand gefunden");


                        }

                    }
                    else
                    {
                        var daten = GetData(eingabe_str, zimmernummer, vorname, Nachname, übernachtung, rechnungsbetrag);
                        if (daten.Item1 == true)
                        {


                        }
                        else
                        {
                            Console.WriteLine("kein gegnstand gefunden");


                        }

                    }


                } while (true);







            }
        }
    }
