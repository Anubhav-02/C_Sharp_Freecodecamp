namespace firstProject
{
    internal class Program
    {
        string values = "Values all of the variables:";
        internal static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(obj.values);
            int x = 5;
            Console.WriteLine("Value of x: " + x);

            //Calling static and instance method of Practice class
            Practice obj1 = new Practice();
            obj1.fun2();
            Practice.fun1();

            //Calling static and instance method of Practice-1 class
            Practice1 obj2 = new Practice1();
            obj2.fun2();
            Practice.fun1();
        }
    }
}
