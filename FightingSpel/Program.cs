
using System.Transactions;

Console.WriteLine("Welcome to FightingGame \nEnter your name to START");
string Name = Console.ReadLine();

while (Name == "") {
Console.WriteLine("Enter Your Name");
Name = Console.ReadLine();
}

Console.WriteLine($"For our next fight we bring on a new fighter.\nIts {Name} against our one and only champion\nClone{Name}!!!!");
Console.ReadLine();
