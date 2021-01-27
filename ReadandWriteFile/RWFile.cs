using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadandWriteFile
{
    class RWFile
    {
        static void Main()
        {
            Console.WriteLine("Createing a File and Reading a FIle");
            Console.WriteLine("press 1 to enter the data into file");
            Console.WriteLine("press2 to read the data from the file");
            int r = 0;
            r = Convert.ToInt32(Console.ReadLine());
            if (r == 1)
            {
                Console.WriteLine("Please enter trhe data \n and press 'E' to stop to write into file ");

               // WriteToFile();
                Main();
            }
            else if (r == 2)
            {
                Main();
            }
            else
                Console.WriteLine("invalid input");

        }
    }
}
