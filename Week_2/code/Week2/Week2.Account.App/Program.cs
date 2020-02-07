using System;
using Week2.Class;
using Week2.Class.Movements;

namespace Week2.AccountFinal.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Account =====");
            Account account = new Account(
                123456, 
                "Banca Popolare di Lodi", 
                1000
            );

            #region Test

            Movement transfertMovement = new TransfertMovement(
                500,
                "Pop Vicenza",
                "Banca Popolare di Lodi"
            );
            account += transfertMovement;

            Movement cashMovement = new CashMovement(
                100, 
                "Roberto Ajolfi"
            );
            account -= cashMovement;

            Movement ccMovement = new CreditCardMovement(
                230,
                CreditCardMovement.CreditCardType.AMEX,
                "9999-1234-1234-0001"
            );
            account -= ccMovement;

            #endregion

            #region Interactive Mode

            //bool next = true;
            //while (next)
            //{
            //    Console.Write("Amount: ");
            //    string amountString = Console.ReadLine();
            //    double.TryParse(amountString, out double amount);

            //    Console.Write("[I]n / [O]ut: ");
            //    string inOut = Console.ReadLine();

            //    Console.Write("Type ([C]Cash / [CC] / [T]ransfer: ");
            //    string type = Console.ReadLine();



            //    Movement movement;
            //    switch (type.ToUpper())
            //    {
            //        case "C":
            //            movement = new CashMovement(amount, "Roberto A.");
            //            break;
            //        case "CC":
            //            movement = new CreditCardMovement(
            //                amount,
            //                CreditCardMovement.CreditCardType.AMEX,
            //                "9999-12345-1234"
            //            );
            //            break;
            //        case "T":
            //            movement = new TransfertMovement(
            //                amount,
            //                "Pop Lodi",
            //                "Pop Vicenza"
            //            );
            //            break;
            //        default:
            //            movement = null;
            //            break;
            //    }

            //    if (movement != null)
            //        if (inOut.ToUpper() == "I")
            //            account += movement;
            //        else
            //            account -= movement;

            //    Console.Write("Ancora (S/N)?");
            //    string again = Console.ReadLine();
            //    next = (again.ToUpper() == "S");
            //}

            //Console.WriteLine("----------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();

            #endregion

            Console.WriteLine(account.Statement());
        }
    }
}
