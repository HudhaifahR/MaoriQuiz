namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Firstname, Lastname;
            char ChoiceOfDifficulty,replay ;
            String[] easyquestions =
    {
            "What does 'Kia Ora' mean?\nA. Goodbye\nB. Hello\nC. Food\nD. Family",
            "What does 'Whānau' mean?\nA. Ocean\nB. School\nC. Family\nD. Mountain",
            "What does 'Kai' mean?\nA. Food\nB. Water\nC. House\nD. Tree",
            "What does 'Moana' mean?\nA. River\nB. Forest\nC. Family\nD. Ocean",
            "What does 'Ka Pai' mean?\nA. Bad\nB. Slow\nC. Good\nD. Fast"
    };
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
                        ShowQuestions(easyquestions);
                        break;

                    case 'M':
                        ShowQuestions(mediumquestions);
                        break;

                    case 'H':
                        ShowQuestions(hardquestions);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }


                Console.WriteLine("Thank you for playing the Maori quiz, goodbye!");
                Console.WriteLine("Would you lie to play the quiz again");
                replay = Console.ReadLine()[0];
                Console.ReadLine();
            } while (replay == 'Y');
        }
        static char DifficultyChoiceLevel()
        {
            Console.WriteLine("What difficulty level would you like to play?");
            Console.WriteLine("E = Easy");
            Console.WriteLine("M = Medium");
            Console.WriteLine("H = Hard");

            char choice = Console.ReadLine().ToUpper()[0];

            return choice;
        }
        static void ShowQuestions(string[] questions)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(questions[i]);

            }
        } } }
    



    



