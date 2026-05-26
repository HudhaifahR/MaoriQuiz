namespace MaoriQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Firstname, Lastname;

            Console.WriteLine("Hello please enter your first name");
            Firstname = Console.ReadLine();
            Console.WriteLine("please enter your last name");
            Lastname = Console.ReadLine();  
            Console.WriteLine("Hello " + Firstname + " " + Lastname + "!");

        }
    }
}
