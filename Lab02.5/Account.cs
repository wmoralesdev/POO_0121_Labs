using System;
using System.Collections.Generic;

namespace Lab02._5
{
    public class Account
    {
        // Attributes
        private string owner;

        private double balance;

        private string pin;

        private List<string> movements;

        // Methods
        public Account(string owner, double? balance, string pin)
        {
            this.owner = owner;
            this.balance = balance ?? 0;
            this.pin = pin;

            movements = new List<string>()
            {
                $"Creacion de cuenta de {owner}",
                $"Deposito inicial: {balance}"
            };
        }

        private bool CheckPin(string pin) 
        {
            return this.pin == pin;
        }

        public void Deposit(string pin, double ammount)
        {
            if(!CheckPin(pin))
            {
                Console.WriteLine("Pin incorrecto");
                return;
            }

            balance += ammount;
            
            movements.Add($"Se ha depositado ${ammount}");
        }

        public bool Retire(string pin, double ammount)
        {
            if(!CheckPin(pin))
            {
                Console.WriteLine("Pin incorrecto");
                return false;
            }

            if(balance >= ammount)
            {
                balance -= ammount;
                movements.Add($"Se ha retirado ${ammount}");
                return true;
            }
            else
                return false;
        }

        public void CheckMovements(string pin)
        {
            if(!CheckPin(pin))
            {
                Console.WriteLine("Pin incorrecto");
                return;
            }

            movements.ForEach(mov => Console.WriteLine(mov));
        }

        public void GetAccountInfo(string pin)
        {
            if(!CheckPin(pin))
            {
                Console.WriteLine("Pin incorrecto");
                return;
            }

            Console.WriteLine($"Owner: {owner}");
            Console.WriteLine($"Balance: ${balance}");
        }

        public bool CheckIfOwner(string owner) => this.owner == owner;
    }
}