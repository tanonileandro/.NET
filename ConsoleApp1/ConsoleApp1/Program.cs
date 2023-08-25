// See https://aka.ms/new-console-template for more information
using ClasesPrueba;

var account = new BankAccount("<name>", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");