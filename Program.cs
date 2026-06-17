using System.Threading.Channels;

namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // these are the variables for my program
            string Firstname, Lastname;
            char ChoiceOfDifficulty,replay ;
            // these are the questions and answers for my program
            String[] easyquestions =
    {
            "What does 'Kia Ora' mean?\nA. Goodbye\nB. Hello\nC. Food\nD. Family",
            "What does 'Whānau' mean?\nA. Ocean\nB. School\nC. Family\nD. Mountain",
            "What does 'Kai' mean?\nA. Food\nB. Water\nC. House\nD. Tree",
            "What does 'Moana' mean?\nA. River\nB. Forest\nC. Family\nD. Ocean",
            "What does 'Ka Pai' mean?\nA. Bad\nB. Slow\nC. Good\nD. Fast"
    };
            char[] easyanswers = { 'B', 'C', 'A', 'D', 'C' };
            String[] mediumquestions =
{
            "What is the Māori name for New Zealand?\nA. Aotearoa\nB. Moana\nC. Whānau\nD. Kai",
            "What does 'Aroha' mean?\nA. Water\nB. Love\nC. Mountain\nD. House",
            "What does 'Wai' mean?\nA. Food\nB. Tree\nC. Water\nD. Bird",
            "What does 'Haere Mai' mean?\nA. Welcome\nB. Goodbye\nC. Family\nD. Ocean",
            "What does 'Tamariki' mean?\nA. Adults\nB. Children\nC. Teachers\nD. Parents"
};
            char[] mediumanswers = { 'A', 'B', 'C', 'A', 'B' };
            String[] hardquestions =
{
            
            "What does 'Haere Rā' mean?\nA. Good morning\nB. Thank you\nC. Goodbye\nD. Welcome",
            "What does 'Mana' mean?\nA. Prestige and respect\nB. Food\nC. Water\nD. School",
            "What does 'Kōrero' mean?\nA. Walk\nB. Talk or speak\nC. Swim\nD. Run",
            "What does 'Whare' mean?\nA. House\nB. Tree\nC. River\nD. Bird",
            "What does 'Marae' refer to?\nA. A sports field\nB. A shopping centre\nC. A Māori meeting ground\nD. A mountain",
};
            char[] hardanswers = { 'C', 'A', 'B', 'A', 'C' };
            // this is the start for my program where the user will enter their name`
            Console.WriteLine("Hello please enter your first name");
            Firstname = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            Lastname = Console.ReadLine();
            Console.WriteLine("Hello " + Firstname + " " + Lastname + "!");
            Console.WriteLine("************************************************");


            // this is the part where the user will choose the difficulty level and play the quiz
            do
            {

                ChoiceOfDifficulty = DifficultyChoiceLevel();
                switch (ChoiceOfDifficulty)
                {
                    case 'E':
                        ShowQuestions(easyquestions, easyanswers);
                        break;

                    case 'M':
                        ShowQuestions(mediumquestions, mediumanswers);
                        break;

                    case 'H':
                        ShowQuestions(hardquestions, hardanswers);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                // this is the part where the user will choose to play the quiz again or not
                Console.WriteLine("************************************************");
                Console.WriteLine("Would you like to play the quiz again? (Y/N)");
                replay = Console.ReadLine()[0];
                Console.ReadLine();
            } while (replay == 'Y');
            Console.WriteLine("Thank you for palying my maori quiz bye");
            Console.WriteLine("************************************************");
            Console.ReadLine();
        }
        // this is the method for the user to choose the difficulty level
        static char DifficultyChoiceLevel()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("What difficulty level would you like to play?");
            Console.WriteLine("E = Easy");
            Console.WriteLine("M = Medium");
            Console.WriteLine("H = Hard");
            Console.WriteLine("************************************************");
            char choice = Console.ReadLine().ToUpper()[0];

            return choice;
        }
        // this is the method for showing the questions and calculating the score
        static void ShowQuestions(string[] questions, char[] answers)
        {
            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(questions[i]);

                char userAnswer = Console.ReadLine().ToUpper()[0];

                if (userAnswer == answers[i])
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }
            // this is the part where the user will see their score after answering all the questions
            Console.WriteLine();
            Console.WriteLine("Your score is " + score + "/" + questions.Length);
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");

        }
    }
}








