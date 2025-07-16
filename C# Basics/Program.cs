using System;



namespace Test
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //int i = 42;
            //int j = (int)5.7;
            //double dl = i;

            //Console.WriteLine(i / 5);
            //Console.WriteLine(dl / 5);
            //Console.WriteLine(i / 5.0);
            //Console.WriteLine(j);

            // ============ String Interpolation ================== //

            //String message = $"It's been about {i} years since it happened last.";

            //double width = 3, height = 4;
            //string info = $"Hypotenuse: {Math.Sqrt(width * width + height * height)}";

            //Console.WriteLine(info);
            //Console.WriteLine(message);

            // Tuples
            //(int x, int y) point = (10, 5); // or var point = (x:10,y:5)

            //Console.WriteLine($"X: {point.x}, Y: {point.y}");

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Number {i+1}");
            //}

            //  ================= Type casting ================== //
            //double a = 3.14;
            //int b = Convert.ToInt32(a);

            //int c = 123;
            //double d = Convert.ToDouble(c)+ 0.1;

            //Console.WriteLine(b.GetType());
            //Console.WriteLine(d.GetType());

            //int e = 321;
            //String f = Convert.ToString(e);

            //Console.WriteLine(f.GetType());

            //String g = "$";
            //char h = Convert.ToChar(g);

            //Console.WriteLine(h.GetType());

            //String i = "true";
            //bool j = Convert.ToBoolean(i);

            //Console.WriteLine(j.GetType());


            // Reading input
            //Console.WriteLine("Please enter your name: ");

            //String name = Console.ReadLine();

            //Console.WriteLine("Please enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Hello {name}, you're {age} years old");


            // ============= Random numbers
            //Random random = new Random();

            ////int num = random.Next(1, 7);
            //double num = random.NextDouble();

            //Console.WriteLine(num);

            //  ===============  Calculate Hypotenuse of a triangle
            // hyp = sqrt(opp2 + adj2);
            //Console.WriteLine("Enter Adjacent: ");
            //double adj = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Opposite: ");
            //double opp = Convert.ToDouble(Console.ReadLine());

            //double hyp = Math.Sqrt((adj*adj) + (opp*opp));

            //Console.WriteLine($"Hypotenuse: {hyp}");

            // ============  Rock, paper scissors game =============== //
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!!!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!!!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!!!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw.");
                        }
                        break;
                }

                Console.Write("Play again? (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if(answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }
            Console.WriteLine("Thanks for playing");

        }
    }

}

