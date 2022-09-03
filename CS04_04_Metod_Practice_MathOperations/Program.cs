using System.Threading.Channels;

namespace CS04_04_Metod_Practice_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeAnotherOperation:
            // Variables
            int userSelection;
            decimal num1, num2;
            decimal result = 0;
            
            // Creating
            Math m = new Math();
            
            // Calling menu
            m.FourOperationMenus();
            
            // Save user menu selection
            userSelection = int.Parse(Console.ReadLine());

            // Asking to the user Num1 and Num2
            Console.WriteLine("Enter your first number :");
            num1 = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your second number :");
            num2 = decimal.Parse(Console.ReadLine());
            
            switch (userSelection)
            {
                case 1: // Addition | Toplama İşlemi
                    result = m.Addition(num1, num2);
                    m.resultOutput(num1," + ", num2 , result);
                    break;
                case 2: // Subtraction | Çıkartma İşlemi
                    result = m.Subtraction(num1, num2);
                    m.resultOutput(num1," - ", num2 , result);
                    break;
                case 3: // Multiplication | Çarpma İşlemi
                    result = m.Multiplication(num1, num2);
                    m.resultOutput(num1," * ", num2 , result);
                    break;
                case 4: // Division | Bölme İşlemi
                    result = m.Division(num1, num2);
                    m.resultOutput(num1," / ", num2 , result);
                    break;
                default:
                    Console.WriteLine("Please select between 1-4 in the menu");
                    Console.WriteLine("Please try again!..");
                    Thread.Sleep(2000);
                    goto MakeAnotherOperation;
                    // break;
            }

            Console.WriteLine("Would you like to make another calculation? [Y/N]");
            string newCalculation = Console.ReadLine();

            if (newCalculation.ToUpper() == "Y")
            {
                goto MakeAnotherOperation;
            }
        }
    }
}