namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Ralph";
            int dogAge = 10;
            char exclamationPoint = '!';
            double investment = 70582.21;
            decimal stockPrice = 100.37m;
            bool marketOpen = true;
            char dollar = '$';
        

            Console.WriteLine($"First thing in the morning, {dogName}, a dog of {dogAge} years, " +
                $"goes to his trading account. \nThe computer pings the market to check if it is open. " +
                $"\nWhen {marketOpen}," +
                $"{dogName} looks at his investment in Dollar Tree. \nHe is surprised to find that his account reads " +
                $"{dollar}{investment}{exclamationPoint}" +
                $" This is because the stock price is {dollar}{stockPrice}. \n{dogName} quickly sells and books a vacation.");

            Console.WriteLine($"Where should {dogName} go on vacation?");

            string vacation = Console.ReadLine();

            Console.WriteLine($"{vacation} is a great destination{exclamationPoint}");
        }
    }
}
