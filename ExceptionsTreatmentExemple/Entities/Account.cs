using System;
using System.Diagnostics.CodeAnalysis;
using ExceptionsTreatmentExemple.Entities.Exception;
using System.Globalization;


namespace ExceptionsTreatmentExemple.Entities {
    internal class Account {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() {
        }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            if (balance == 0.0) {
                throw new DomainException("There is no balance in your account.");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            Balance = Balance + amount;

        }
        public void WithDraw(double amount) {

            if (Balance < amount) {
                throw new DomainException("There is no enough balance in your account.");

            }
            if (amount > WithdrawLimit) {
                throw new DomainException("The withdraw must not overcome the withdraw limit.");
            }

            Balance = Balance - amount;

        }

        public override string ToString() {
            return "New balance: $" +
                Balance.ToString("F2", CultureInfo.InvariantCulture);
        }






    }
}
