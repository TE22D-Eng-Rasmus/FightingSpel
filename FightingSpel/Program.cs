﻿
using System.Transactions;


Random generator = new Random();



Console.WriteLine("Welcome to FightingGame \nEnter your name to START");
string Name = Console.ReadLine();

while (Name == "")
{
    Console.WriteLine("Enter Your Name");
    Name = Console.ReadLine();
}


int Fighter;     //Slumpar för vilken fightern spelaren ska möta
Fighter = generator.Next(1,4);


if (Fighter == 1){

Console.WriteLine($"For our next fight we bring on a new fighter.\nIts {Name} against our one and only champion\nClone{Name}!!!!\nThe Champion goes first\n");
Thread.Sleep(5000);
}

if (Fighter == 2){

    Console.WriteLine("You Have the luck to fight against our BIGGEST fighter\nADAM!!!\n");
    Thread.Sleep(4000);
}

if (Fighter == 3){

    Console.WriteLine($"What a missfortune for you. Your career just started and  now it will end.\nIT IS {Name} AGAINST OUR BEST FIGHTER!!\nIts MEWTOO\n");
    Thread.Sleep(4500);
}

int b;   //Skada spelaren gör
int h; //Hälsa för Spelaren
int h2; //Hälsa för Fighter
int r;   //Skada fightern gör


if (Fighter == 1) {    //Fighting för första "bossen"

h = 25;
h2 = 25;

        while (h >= 0 && h2 >= 0)
        {
            r = generator.Next(11);



            if (r >= 5)
            {
                Console.WriteLine($"Clone{Name} did {r} damage\nImpressive!\n");
                Thread.Sleep(2000);
                h = h - r;
            }

            if (r <= 4)
            {
                Console.WriteLine($"Clone{Name} did {r} damage\nI thought he could do better.\n");
                Thread.Sleep(2000);
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
                Thread.Sleep(2000);
                h2 = h2 - b;

            }

            if (b <= 4)
            {
                Console.WriteLine($"{Name} did {b} damage\nLike i thought from a noob.\n");
                Thread.Sleep(2000);
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
}




if (Fighter == 2) {   //fighting för andra "bossen"

h=55;
h2=50;

        while (h >= 0 && h2 >= 0)
        {
            r = generator.Next(16);



            if (r >= 7)
            {
                Console.WriteLine($"ADAM did {r} damage\nMust be all the food!\n");
                Thread.Sleep(2000);
                h = h - r;
            }

            if (r <= 6)
            {
                Console.WriteLine($"ADAM did {r} damage\nI thought all the food would give him strength.\n");
                Thread.Sleep(2000);
                h = h - r;
            }



if (h <= 0)
            {
                Console.WriteLine($"Adam is the winner with {h2}/50 heatlh left, and is beginning to eat {Name}.\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }



            b = generator.Next(16);

            if (b >= 7)
            {
                Console.WriteLine($"{Name} did {b} damage\nPretty good for a Beginner!\n");
                Thread.Sleep(2000);
                h2 = h2 - b;

            }

            if (b <= 6)
            {
                Console.WriteLine($"{Name} did {b} damage\nLike i thought from a noob.\n");
                Thread.Sleep(2000);
                h2 = h2 - b;

            }

            if (h <= 0)
            {
                Console.WriteLine($"Adam is the winner with {h2}/50 heatlh left, and is beginning to eat {Name}.\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }

            if (h2 <= 0)
            {
                Console.WriteLine($"{Name} is suprisingly the winner with {h}/55 heatlh left.\nMaybe a new champion?\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }
        }
}



if (Fighter == 3) {   //fighting för tredje "bossen"

h=100;
h2=150;

        while (h >= 0 && h2 >= 0)
        {
            r = generator.Next(5,36);



            if (r >= 7)
            {
                Console.WriteLine($"ADAM did {r} damage\nMust be all the food!\n");
                Thread.Sleep(2000);
                h = h - r;
            }

            if (r <= 6)
            {
                Console.WriteLine($"ADAM did {r} damage\nI thought all the food would give him strength.\n");
                Thread.Sleep(2000);
                h = h - r;
            }



if (h <= 0)
            {
                Console.WriteLine($"Adam is the winner with {h2}/150 heatlh left, and is beginning to eat {Name}.\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }



            b = generator.Next(36);

            if (b >= 7)
            {
                Console.WriteLine($"{Name} did {b} damage\nPretty good for a Beginner!\n");
                Thread.Sleep(2000);
                h2 = h2 - b;

            }

            if (b <= 6)
            {
                Console.WriteLine($"{Name} did {b} damage\nLike i thought from a noob.\n");
                Thread.Sleep(2000);
                h2 = h2 - b;

            }

            if (h <= 0)
            {
                Console.WriteLine($"Adam is the winner with {h2}/200 heatlh left, and is beginning to eat {Name}.\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }

            if (h2 <= 0)
            {
                Console.WriteLine($"{Name} is suprisingly the winner with {h}/55 heatlh left.\nMaybe a new champion?\nPress ANY key to EXIT");
                Console.ReadLine();
                break;
            }
        }
}