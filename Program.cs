namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Firstname, Lastname;
            char ChoiceOfDifficulty;
            String[] easyquestions = { "" };
            String[] mediumquestions = { "" };
            String[] hardquestions = { "" };

            Console.WriteLine("Hello please enter your first name");
            Firstname = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            Lastname = Console.ReadLine();
            Console.WriteLine("Hello " + Firstname + " " + Lastname + "!");



            do
            {
                ChoiceOfDifficulty = DifficultyChoiceLevel();
                switch (ChoiceOfDifficulty)
                {
                    case 'E':
                        Console.WriteLine("you have chosen easy difficulty");
                        break;
                    case 'M':
                        Console.WriteLine("you have chosen medium difficulty");
                        break;
                    case 'H':
                        Console.WriteLine("you have chosen hard difficulty");
                        break;
                    default:
                        Console.WriteLine("invalid choice, please try again");
                        break;
                }
                Console.WriteLine("Y for yes N for no");
                ChoiceOfDifficulty = Console.ReadLine().ToUpper()[0];
            } while (ChoiceOfDifficulty == 'Y');
            case 'E':
                Console.WriteLine("you have chosen easy difficulty");

                for (int i = 0; i < easyquestions.Length; i++)
                {
                    Console.WriteLine(easyquestions[i]);
                    Console.ReadLine(); 
                }
                break;

            }

            Console.WriteLine("Thank you for playing the Maori quiz, goodbye!");


            static char DifficultyChoiceLevel()
            {
                char choice;

                Console.WriteLine("what difficulty level would you like to play? (E for easy, M for medium, H for hard)");
                choice = Console.ReadLine().ToUpper()[0];
                return choice;

            }
        }     }  } 
        
    

    



