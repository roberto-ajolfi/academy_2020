using System;
using System.IO;

namespace Week1_Exercise
{
    /* WEEK 1 EXERCISE
     * Roberto Ajolfi
     */

    /*
     * Si chiede di creare un app console in .NET Core 3.0 che 
     * richieda la lettura come argomenti della linea di comando 
     * (a) di un numero compreso da 1 e 10 
     * e (b) una stringa; 
     * 
     * dovranno essere creati un pari numero di oggetti “prodotto” (struct Product), 
     * ciascuno dei quali caratterizzato da 
     * codice (alfanumerico, campo “Code”), 
     * nome (campo “Name”) e 
     * prezzo (numero intero, campo “Price”). 
     * Una volta terminato l’inserimento dei prodotti, gli stessi devono essere stampati a video 
     * e scritti all’interno di un file di testo [utilizzare come nome l’argomento (b)] in modo tale 
     * da poter essere facilmente riletti (la funzione di rilettura non è richiesta).
     * */
    class Program
    {
        #region Constants

        const string BasePath = @"C:\Temp\";

        #endregion

        #region Main

        static void Main(string[] args)
        {
            int numberOfItems = 0;
            string fileName = string.Empty;

            Console.WriteLine("=== Week 1 Exercise ======");

            #region Check Args

            // check args
            if (args.Length != 2)
            {
                Console.WriteLine("USAGE: " +
                    AppDomain.CurrentDomain.FriendlyName +
                    " numberOfItems filename");
                return;
            }
            else
            {
                //numberOfItems = int.Parse(args[0]);
                int.TryParse(args[0], out numberOfItems);
                if (numberOfItems < 1 && numberOfItems > 10)
                    throw new 
                        ArgumentOutOfRangeException("numberOfItems must be between 1 and 10.");

                fileName = BasePath + args[1];
            }

            #endregion

            Product[] products = new Product[numberOfItems];

            Console.WriteLine();
            for (int index = 0; index < numberOfItems; index++)
            {
                Console.WriteLine($"--- Prodotto #{index + 1} --- ");
                Product p = GetProduct();
                Console.WriteLine($"-------------------------");

                products[index] = p;
            }
            Console.WriteLine();

            PrintProducts(products);

            SaveProducts(products, fileName);


            Console.WriteLine("=== End of Exercise ======");
        }

        #endregion

        #region Other Methods

        private static Product GetProduct()
        {
            Product p = new Product();

            Console.Write("Codice: ");
            p.Code = Console.ReadLine();
            Console.Write("Nome: ");
            p.Description = Console.ReadLine();
            Console.Write("Prezzo: ");
            string price = Console.ReadLine();
            double temp;
            double.TryParse(price, out temp);
            p.Price = temp;
            
            return p;
        }

        private static void PrintProducts(Product[] products)
        {
            Console.WriteLine("/// ELENCO PRODOTTI ///");
            for (int i = 0; i < products.Length; i++)
            {
                Product p = products[i];
                Console.WriteLine("[{0}] {1} - EUR {2} (15% out = {3})", 
                    p.Code, p.Description, p.Price, p.DiscountedPrice(15));

            }
            Console.WriteLine("////////////////");
        }
        private static void SaveProducts(Product[] products, string fileName)
        {
            Console.WriteLine();
            Console.Write("Salvataggio Prodotti ");

            try
            {
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    //sw.WriteLine("Code,Description,Price");
                    for (int i = 0; i < products.Length; i++)
                    {
                        Product p = products[i];
                        sw.WriteLine("{0}:", p.Code);
                        sw.WriteLine("\t- {0}", p.Description);
                        sw.WriteLine("\t- {0}", p.Price);
                        sw.WriteLine("\t- {0}", p.Created.ToString("yyyy-MM-dd"));
                        Console.Write("...");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot save data.");
                Console.WriteLine("Error: {0}", ex.Message);
            }

            Console.WriteLine();
        }

        #endregion
    }
}
