namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userName = "Jared";
            int age = 30;
            double avg = 98.7;
            decimal bankAccount = 100.00m;
            char initial = 'J';
            bool isMarried = true;

            Console.WriteLine($"Welcome, {userName}. According to our records, you are {age}. The average of your test scores is {avg}. \nYour most recent gift deposit is {bankAccount}. Your initial being {initial}. And since you are married per our records. Answer: {isMarried}. Your spouse has access as well.");
        }
    }
}
