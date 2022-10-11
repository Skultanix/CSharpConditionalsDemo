namespace ConditionalsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;
           /* float price;

            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;*/


            //Conditional Operator used for brevity instead of the if statement commented out above.
            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}