
using System.Transactions;

Random generator = new Random();

Console.WriteLine("Welcome to FightingGame \nEnter your name to START");
string Name = Console.ReadLine();

while (Name == "") {
Console.WriteLine("Enter Your Name");
Name = Console.ReadLine();
}

Console.WriteLine($"For our next fight we bring on a new fighter.\nIts {Name} against our one and only champion\nClone{Name}!!!!\nThe Champion goes first");
Thread.Sleep(2500);
int r = generator.Next(10);

if (r > 4) {
Console.WriteLine($"Clone{Name} did {r} damage\nImpressive");
Thread.Sleep(1500);
}

if (r < 5) {
Console.WriteLine($"Clone{Name} did {r} damage\nI thought he could do better");
Thread.Sleep(1500);
}

int r2 = generator.Next(10);

Console.WriteLine($"Han gjorde {r2} skada");
Console.ReadLine();