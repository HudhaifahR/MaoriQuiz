namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Firstname, Lastname;
            char ChoiceOfDifficulty;
            String[] easyquestions = { "What is the Maori word for 'hello'?\n A> kia orer B> kia ora C D", "What is the Maori word for 'thank you'?", "What is the Maori word for 'goodbye'?" };

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
                switch (ChoiceOfDifficulty)
                {
                    case 'E':
                        Console.WriteLine("you have chosen easy difficulty");

                        Console.WriteLine(easyquestions[0]);
                        Console.WriteLine(easyquestions[1]);
                        Console.WriteLine(easyquestions[2]);

                        break;
                    } 
                } while (ChoiceOfDifficulty == 'N') ;



                Console.WriteLine("Thank you for playing the Maori quiz, goodbye!");


                static char DifficultyChoiceLevel()
                {
                    char choice;

                    Console.WriteLine("what difficulty level would you like to play? (E for easy, M for medium, H for hard)");
                    choice = Console.ReadLine().ToUpper()[0];
                    return choice;

                }
            }
        }
    }

    



