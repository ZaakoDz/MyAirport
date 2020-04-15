using System;
using System.Linq;
using ZW.MyAirport.EF;

namespace ZW.MyAirport
{
    class Program
    {
        static void Main()
        {
            using ( MyAirportContext db = new MyAirportContext())
            {
                // Create

                // AJOUT DE VOLS

                Flight f1 = new Flight

                {
                    CIE = 1,
                    LIG = "knjfe",
                    JEX = 12,
                    DES="Kouba"
                };
                db.Add(f1);
               
                Flight f2 = new Flight

                {
                    CIE = 2,
                    LIG = "abcd",
                    JEX = 13,
                    DES="Paris"
                };

                db.Add(f2);

                // AJOUT DE BAGAGES

                Luggage l1 = new Luggage
                {
                    CODE_IATA="sciroc",
                    DATE_CREATION= Convert.ToDateTime("24/02/2020 15:01"),
                    DESTINATION = "Paris"                  
                };

                db.Add(l1);
                db.SaveChanges();

                Console.ReadLine();

                // Read
                
                //var permet de définir une variable dont on connait pas le type 
                Console.WriteLine("Voici la liste des vols diponibles");
                var flight = db.Flights    //dans le data context (sauvegardée en mémoire mais pas dans la dbs
                    //résultat du select
                    .OrderBy(f => f.CIE); //argument f trier par compagnie
                    foreach(var f in flight)
                {
                    Console.WriteLine($"Le vol {f.CIE}{f.LIG} N° {f.FLIGHTID} à destination de {f.DES} part à {f.DHC} heure");
                }
                Console.ReadLine();

                // Update

                Console.WriteLine($"Le bagage {l1.LUGGAGEID} est modifié pour être ...");
                l1.FLIGHTID = f1.FLIGHTID;
                 
                db.SaveChanges();

                Console.ReadLine();

                // Delete
        
                db.Remove(f1);
                db.SaveChanges(); 

            }
        }
    }
}