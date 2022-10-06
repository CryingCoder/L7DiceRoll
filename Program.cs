namespace L7DiceRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GREETING MESSAGE AND ASK THE USER TO INPUT SIZE OF DIE, BOTH DICE WILL BE SAME
            Console.WriteLine($"*************************************************************");
            Console.WriteLine($"\nWelcome to the Grand Circus Casino! Let's roll some dice!");
            
            
            //THIS IS BIG POPPA WHILE LOOP DOES ALL THE WHILES
            bool runAgain = true;
            while (runAgain)
                {

                    //GREETING MESSAGE AND ASK THE USER TO INPUT SIZE OF DIE, BOTH DICE WILL BE SAME
                    Console.WriteLine($"\nHow many sides should the 2 dice have?");
                    string input = Console.ReadLine();
                    int numSides = int.Parse(input);
                    Console.WriteLine($"\nAlright! You want to roll some {numSides} sided dice!\n*\n*\n*\n*\n*\n*");

                    //INITIALIZE THESE 2 VARIABLES WITH numSides TO GET YOUR 2 DICE ROLLS
                    int dieUno = RandomGenerator(numSides);
                    int dieDos = RandomGenerator(numSides);
                    int totalDie = dieUno + dieDos;

                    //CONDITIONALLLY PLAY THE DICE DEPENDING ON IF THEY'RE BETWEEN LESS THAN OR GREATER THAN 6 SIDED
                    if (numSides >= 1 && numSides <= 6)
                    {
                        Console.WriteLine($"\nYou rolled a {dieUno} & {dieDos} ({totalDie} total)");
                        RollSix(dieDos, dieUno);
                        Console.WriteLine();//FORMATTING
                    }
                    else
                    {
                        Console.WriteLine($"\nYou rolled a {dieUno} & {dieDos} ({totalDie} total)\n");
                        Console.WriteLine();//FORMATTING
                    }
                
                    
                //ASK TO GO AGAIN
                runAgain = RunAgain();
                }
            }



        //METHOD WITH CONDITIONAL FOR DETERMINING PLAY FOR 6 SIDED DICE
        public static void RollSix(int d1, int d2)
        {
            if (d1 == 1 && d2 == 1)
            {
                Console.WriteLine("SNAKE EYES");
            }
            else if (d1 + d2 == 3)
            {
                Console.WriteLine("ACE DUECE");
            }
            else if (d1 == 6 && d2 == 6)
            {
                Console.WriteLine("BOX CARS");
            }
            else if (d1 + d2 == 7 || d1+ d2 == 11)
            {
                Console.WriteLine("WINNER");
            }
            else if (d1 + d2 == 2 || d1 + d2 == 3 || d1 + d2 == 12)

            {
                Console.WriteLine("CRAPS");
            }
        }


        //METHOD TO GENERATE RANDOM NUMBERS - IN THIS CASE A DICE ROLL
        public static int RandomGenerator(int sides)
        {
            
            Random r = new Random();
            int roll = r.Next(1, sides + 1);

            return roll;
        }



        //METHOD TO LOOP THROUGH THE PROGRAM WHEN PROMPTED
        public static bool RunAgain()
        {
            while (true)
            {
                Console.WriteLine("Roll again? y/n");
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "y" || input == "yes")
                {
                    return true;
                }
                else if (input == "n" || input == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    return false;
                }
                else
                {
                    Console.WriteLine("I didn't get that. Please enter y/n.");
                    return RunAgain();
                }
            }
        }
    }
}