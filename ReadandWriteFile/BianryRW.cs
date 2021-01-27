using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadandWriteFile
{
    class BianryRW
    {
        static void Main()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(@"C:\Dotnet2021\ConsoleAssig(hw)\Assign(jan25)\BinaryRW.txt", FileMode.Create)))
            {
                bw.Write(36.66);
                bw.Write("Binary string test");
                //bw.Write(@"C:\Dotnet2021\ConsoleAssig(hw)\Assign(jan25)\assign.txt");
                bw.Write(true);
            }
            Console.WriteLine("-----------------------------------");
            using(BinaryReader br=new BinaryReader(File.Open(@"C:\Dotnet2021\ConsoleAssig(hw)\Assign(jan25)\BinaryRW.txt",FileMode.Open)))
            {
                Console.WriteLine($"DOuble value:{br.ReadDouble()}");
                Console.WriteLine($"String value:{br.ReadString()}");
                //Console.WriteLine($"read form file:{br.ReadString()}");
                Console.WriteLine($"read Bool value:{br.ReadBoolean()}");
            }
        }
    }
}
