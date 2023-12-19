namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pettingZoo =
            {
                "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
                "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
                "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
            };

            Char[] characterLoop = {'/','?','@','!','_','_','_'};

            DisplayZooMaster();

            PlanSchoolVisit("School A");
            PlanSchoolVisit("School B", 3);
            PlanSchoolVisit("School C", 2);

            void PlanSchoolVisit(string schoolName, int groups = 6)
            {
                RandomizeAnimals(pettingZoo);
                string[,] group = AssignGroups(animals: pettingZoo, groups);
                Console.WriteLine($"\n{schoolName}");             

                DisplayGroups(group);
                Console.WriteLine();
            }

            void RandomizeAnimals(string[] animals)
            {
                Random random = new Random();

                for (int i = 0; i < animals.Length; i++)
                {
                    int r = random.Next(i, animals.Length);

                    string temp = animals[i];
                    animals[i] = animals[r];
                    animals[r] = temp;
                }
            }

            string[,] AssignGroups(string[] animals, int groups = 6)
            {
                string[,] result = new string[groups, animals.Length / groups];
                int start = 0;

                for (int i = 0; i < groups; i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = animals[start];
                        start++;
                    }
                }
                return result;
            }

            void DisplayGroups(string[,] groups)
            {
                for (int i = 0; i < groups.GetLength(0); i++)
                {
                    Console.Write($"\nGroup No.{i} - ");

                    for (int j = 0; j < groups.GetLength(1); j++)
                    {
                        Console.Write($"{groups[i, j]}");

                        if (j < groups.GetLength(1) - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }

            void DisplayZooMaster()
            {
                string zooMasterArt = @"                                                                                               
@@@@@@@@   @@@@@@    @@@@@@      @@@@@@@@@@    @@@@@@    @@@@@@   @@@@@@@  @@@@@@@@  @@@@@@@   
@@@@@@@@  @@@@@@@@  @@@@@@@@     @@@@@@@@@@@  @@@@@@@@  @@@@@@@   @@@@@@@  @@@@@@@@  @@@@@@@@  
     @@!  @@!  @@@  @@!  @@@     @@! @@! @@!  @@!  @@@  !@@         @@!    @@!       @@!  @@@  
    !@!   !@!  @!@  !@!  @!@     !@! !@! !@!  !@!  @!@  !@!         !@!    !@!       !@!  @!@  
   @!!    @!@  !@!  @!@  !@!     @!! !!@ @!@  @!@!@!@!  !!@@!!      @!!    @!!!:!    @!@!!@!   
  !!!     !@!  !!!  !@!  !!!     !@!   ! !@!  !!!@!!!!   !!@!!!     !!!    !!!!!:    !!@!@!    
 !!:      !!:  !!!  !!:  !!!     !!:     !!:  !!:  !!!       !:!    !!:    !!:       !!: :!!   
:!:       :!:  !:!  :!:  !:!     :!:     :!:  :!:  !:!      !:!     :!:    :!:       :!:  !:!  
 :: ::::  ::::: ::  ::::: ::     :::     ::   ::   :::  :::: ::      ::     :: ::::  ::   :::  
: :: : :   : :  :    : :  :       :      :     :   : :  :: : :       :     : :: ::    :   : :  
                                                                                               ";

                Console.WriteLine(zooMasterArt);
            }           

        }
    }
}