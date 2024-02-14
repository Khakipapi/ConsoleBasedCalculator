using System.Numerics;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
 
    public int mul(int a, int b)
    {
        return a * b;
    }
  
    public int subtract(int a, int b)
    {
        return a - b;
    }

    public int div(int a, int b)
    {
        return a / b;
    }
 
    public int mod(int a, int b)
    {
        return a % b;
    }

    static void Main(string[] args)
    {
        bool co = true;
        while (co)
        {
            try{
                Console.WriteLine("Enter the operation being done(+,-,*,/,%): ");
                string op = Console.ReadLine();
                Console.WriteLine("Enter the First number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Calculator c = new Calculator();
                switch (op)
                {
                    case "+":
                        Console.WriteLine("The answer is " + c.Add(a, b));
                        break;
                    case "-":
                        Console.WriteLine("The answer is " + c.subtract(a, b));
                        break;
                    case "*":
                        Console.WriteLine("The answer is " + c.mul(a, b));
                        break;
                    case "/":
                        Console.WriteLine("The answer is " + c.div(a, b));
                        break;
                    case "%":
                        Console.WriteLine("The answer is " + c.mod(a, b));
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine("Do you want to continue? (Y/N)");
                string cont = Console.ReadLine();
                if (cont == "N" || cont =="n")
                {
                    co = false;  
                    break;
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Invalid input");
            }
    }
    }
    }
