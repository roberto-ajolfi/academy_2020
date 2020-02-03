using System;
using System.IO;

namespace Week1_Exercise
{
    /* WEEK 1 EXERCISE
     * Roberto Ajolfi
     */
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
            if(args.Length != 2)
            {
                Console.WriteLine("USAGE: " + 
                    AppDomain.CurrentDomain.FriendlyName + 
                    " numberOfItems filename");
                return;
            }
            else
            {
                numberOfItems = int.Parse(args[0]);
                if (numberOfItems < 1 && numberOfItems > 10)
                    throw new ArgumentOutOfRangeException("numberOfItems must be between 1 and 10.");

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
            Product p;

            Console.Write("Codice: ");
            p.Code = Console.ReadLine();
            Console.Write("Nome: ");
            p.Description = Console.ReadLine();
            Console.Write("Prezzo: ");
            string price = Console.ReadLine();
            int.TryParse(price, out p.Price);

            return p;
        }

        private static void PrintProducts(Product[] products)
        {
            Console.WriteLine("/// ELENCO PRODOTTI ///");
            for (int i = 0; i < products.Length; i++)
            {
                Product p = products[i];
                Console.WriteLine("[{0}] {1} - EUR {2}", p.Code, p.Description, p.Price);
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
                    sw.WriteLine("Code,Description,Price");
                    for (int i = 0; i < products.Length; i++)
                    {
                        Product p = products[i];
                        sw.WriteLine("{0},{1},{2}", p.Code, p.Description, p.Price);
                        Console.Write("...");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cannot save data.");
                Console.WriteLine("Error: {0}", ex.Message);
            }

            Console.WriteLine();
        }

        #endregion
    }

    #region Product struct

    public struct Product
    {
        public string Code;
        public string Description;
        public int Price;
    }

    #endregion
}