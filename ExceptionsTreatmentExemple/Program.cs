using System;
using ExceptionsTreatmentExemple.Entities.Exception;
using System.Globalization;
using ExceptionsTreatmentExemple.Entities;

namespace ExceptionsTreatmentExemple {
    internal class Program {
        static void Main(string[] args) {



            Console.WriteLine("Bank account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder name: ");
            string holder = Console.ReadLine();
            Console.Write("Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Account a = new Account(number, holder, balance, limit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try {
                a.WithDraw(withdraw);
                Console.WriteLine(a);
            }

            catch (DomainException e) {
                Console.WriteLine("Withdraw error! " + e.Message);

            }
            catch (FormatException e) {
                Console.WriteLine("Error! " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Error! " + e.Message);
            }























        }
    }
}