using Week2.Class.Movements;
using System;
using System.Collections;
using System.Text;

namespace Week2.Class
{
    public class Account
    {
        public Account(int number, string bankName) : this(number, bankName, 0) { }

        public Account(int number, string bankName, double initialBalance)
        {
            this.Number = number;
            this.BankName = bankName;
            this.Balance = initialBalance;
            this.LastUpdate = DateTime.Now;
            this.Movements = new ArrayList();
        }

        public int Number { get; set; }
        public string BankName { get; set; }
        public DateTime LastUpdate { get; set; }
        public double Balance { get; set; }
        public ArrayList Movements { get; set; }

        public static Account operator+(Account acc, Movement m)
        {
            acc.Balance += m.Amount;
            acc.Movements.Add(m);
            acc.LastUpdate = DateTime.Now;
            return acc;
        }

        public static Account operator-(Account acc, Movement m)
        {
            acc.Balance -= m.Amount;
            acc.Movements.Add(m);
            acc.LastUpdate = DateTime.Now;
            return acc;
        }

        public string Statement()
        {
            #region String Concatenation

            string result = string.Empty;

            result += $"account # {Number}\n";
            result += $"bank # {BankName}\n";
            result += $"==============================\n";
            result += $"==== movements ===============\n";
            result += $"------------------------------\n";

            foreach (Movement m in this.Movements)
            {
                string timestamp = m.Timestamp.ToString("yyyy-mm-dd");
                result += $"[{timestamp}] {m.ToString()}\n";
            }

            result += $"==============================\n";
            result += $"== balance: {Balance} eur ==\n";
            result += $"==============================\n";

            return result;

            #endregion

            #region StringBuilder

            //StringBuilder result = new StringBuilder();

            //result.AppendLine("Account # " + Number);
            //result.AppendLine("Bank: " + BankName);
            //result.AppendLine("==============================");
            //result.AppendLine("==== Movements ===============");
            //result.AppendLine("------------------------------");

            //foreach (Movement m in this.Movements)
            //{
            //    string timestamp = m.Timestamp.ToString("yyyy-MM-dd");
            //    result.AppendLine(
            //        $"[{timestamp}] {m.ToString()}"
            //    );
            //}

            //result.AppendLine("==============================");
            //result.AppendLine($"== Balance: {Balance} EUR ==");
            //result.AppendLine("==============================");

            //return result.ToString();

            #endregion
        }
    }
}
