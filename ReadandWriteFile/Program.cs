using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadandWriteFile
{
    class Program
    {

        static void WriteToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Dotnet2021\ConsoleAssig(hw)\Assign(jan25)\assign.txt"))
                {
                   // string r = "";
                    do
                    {
                        ;sw.WriteLine(Console.ReadLine());
                        //r=Console.Readkey();
                    } while (Console.ReadKey(true).Key != ConsoleKey.E);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nThe data was written into the file");
                Console.WriteLine("-------------------------------------");
            }

        }
        static void ReadfromFile()
        {
            string line="";
            try
            {
                using(StreamReader sr=new StreamReader(@"C:\Dotnet2021\ConsoleAssig(hw)\Assign(jan25)\assign.txt"))
                {
                    while((line=sr.ReadLine())!=null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The END of File");
                Console.WriteLine("------------------");

            }
        }

        static void Main()
        {
            Console.WriteLine("$Creating a File and Reading a FIle$");
            Console.WriteLine("press 1 to enter the data into file");
            Console.WriteLine("press2 to read the data from the file");
            int r = 0;
            r=Convert.ToInt32(Console.ReadLine());
            if(r==1)
            {
                Console.WriteLine("Please enter the data:\nand press 'E' to stop writing into file ");

                WriteToFile();
                Main();
            }
            else if(r==2)
            {
                ReadfromFile();
                Main();
            }
            else
                Console.WriteLine("invalid input\nThank you.");
            
        }
    }
}
