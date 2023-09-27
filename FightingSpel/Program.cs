
using System.Transactions;


Random generator = new Random();



Console.WriteLine("Welcome to FightingGame \nEnter your name to START");
string Name = Console.ReadLine();

while (Name == "")
{
    Console.WriteLine("Enter Your Name");
    Name = Console.ReadLine();
}

Console.WriteLine($"For our next fight we bring on a new fighter.\nIts {Name} against our one and only champion\nClone{Name}!!!!\nThe Champion goes first\n");
Thread.Sleep(2500);

int b;
int h = 25;
int h2 = 25;
int r;

        while (h > 0 && h2 > 0)
        {
            r = generator.Next(11);



            if (r >= 5)
            {
                Console.WriteLine($"Clone{Name} did {r} damage\nImpressive!\n");
                Thread.Sleep(1500);
                h = h - r;
            }

            if (r <= 4)
            {
                Console.WriteLine($"Clone{Name} did {r} damage\nI thought he could do better.\n");
                Thread.Sleep(1500);
                h = h - r;
            }

if (h <= 0)
            {
                Console.WriteLine($"Clone{Name} is ofcourse the clear winner with {h2}/25 heatlh left.\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }

            b = generator.Next(11);

            if (b >= 5)
            {
                Console.WriteLine($"{Name} did {b} damage\nPretty good for a Beginner!\n");
                Thread.Sleep(1500);
                h2 = h2 - b;

            }

            if (b <= 4)
            {
                Console.WriteLine($"{Name} did {b} damage\nLike i thought from a noob.\n");
                Thread.Sleep(1500);
                h2 = h2 - b;

            }

            if (h <= 0)
            {
                Console.WriteLine($"Clone{Name} is ofcourse the clear winner with {h2}/25 heatlh left.\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }

            if (h2 <= 0)
            {
                Console.WriteLine($"{Name} is suprisingly the winner with {h}/25 heatlh left.\nMaybe a new champion?\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }
        }
