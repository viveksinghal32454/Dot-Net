using System;

namespace UserEntry
{
    class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine("Enter Your First Name: ");
            String fName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            String lName = Console.ReadLine();
            Console.WriteLine("My Name is: "+fName+" "+lName);
            Console.WriteLine("My Name is: {0} {1}", fName,lName);
            Console.ReadLine();
            */

            //Addition of two number
            Console.WriteLine("Enter Your First Number: ");
            int fNo = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Your Second Name: ");
            int lNo = Convert.ToInt32(Console.ReadLine());
            int result = fNo + lNo;
            Console.WriteLine("Addition of Two number is: "+result);
            Console.WriteLine("Result of addition of {0} and {1} is: {2}", fNo, lNo, result);
            Console.ReadLine();

}
}
}
