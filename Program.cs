namespace ConsoleApp
{
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        public abstract void animalLimbs();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalLimbs()
        {
            throw new NotImplementedException();
        }

        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    public class xyz
    {
        public static int a;
        static xyz()
        {
            a = 10;

        }
        public xyz()
        {
            Console.WriteLine("done {0}", xyz.a);
            a++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A aa = new A();
            C cc = new A();

            //PassByRef ob = new PassByRef();
            int x;
            int y = 10;

            // Pass variable i to the method
            // using out keyword
            PassByRef.Addition(out x);   
            // Display the value i
            Console.WriteLine("The addition of the value is: {0}", x);

            PassByRef.Addition1(ref y);
            Console.WriteLine("The addition1 of the value is: {0}", y);

            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method

            int a = 10;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(++a);
            Console.WriteLine(a);
            ++a;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine(resultString);
            Console.ReadKey();

            Console.WriteLine("Hello, World!");
            xyz obj = new xyz();
            Console.WriteLine("done {0}", xyz.a);
            xyz obj1 = new xyz();
            Console.WriteLine("done {0}", xyz.a);
        }
    }
}
