using System;
using System.Collections.Generic;

namespace Lab02._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<Account>()
            {
                new Account("Walter", null, "webos"),
                new Account("Walter", null, "webos"),
                new Account("Walter", null, "webos"),
                new Account("Alejandra", 100, "wenas"),
                new Account("Marcos", 50, "1234")
            };

            // Action - Predicate
            // Accion -> No retorna un valor
            // Predicate -> Retornar un valor de verdad (valor booleano)
            // Function -> Retornan un valor no booleano
            accounts.ForEach(acc => 
            {
                Console.WriteLine("Pin: ");
                var pin = Console.ReadLine();

                acc.GetAccountInfo(pin);
            });

            // Encontar la cuenta de Alejandra y asignarla a la var aleAccount
            var aleAccount = accounts.Find(acc => acc.CheckIfOwner("Alejandra"));

            // Encontrar las cuentas de Walter y asignarlas a la var waltAccounts
            var waltAccounts = accounts.FindAll(acc => acc.CheckIfOwner("Walter"));
        }
    }
}