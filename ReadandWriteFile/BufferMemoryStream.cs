using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReadandWriteFile
{
    class BufferMemoryStream
    {
        static void Main()
        {
            FileStream fs = new FileStream("Hoo.txt", FileMode.Create, FileAccess.ReadWrite);
            BufferedStream bs = new BufferedStream(fs);
            Console.WriteLine("Length: {0}\tPosition: {1}", bs.Length, bs.Position);

            for (int i = 0; i < 64; i++)
            {
                bs.WriteByte((byte)i);
            }
            Console.WriteLine("Length: {0}\tPosition: {1}", bs.Length, bs.Position);
            byte[] ba = new byte[bs.Length];
            bs.Position = 0;
            bs.Read(ba, 0, (int)bs.Length);
            foreach (byte b in ba)
            {
                Console.Write("{0,-3}", b);
            }

            string s = "Foo";
            for (int i = 0; i < 3; i++)
            {
                bs.WriteByte((byte)s[i]);
            }
            Console.WriteLine("\nLength: {0}\tPosition: {1}\t", bs.Length, bs.Position);

            for (int i = 0; i < (256 - 67) + 1; i++)
            {
                bs.WriteByte((byte)i);
            }
            Console.WriteLine("\nLength: {0}\tPosition: {1}\t", bs.Length, bs.Position);
            bs.Close();

            byte[] file = File.ReadAllBytes(@"C:\Dotnet2021\dp.jpeg");
            using(MemoryStream me=new MemoryStream(file))
            {
               using (BinaryReader br = new BinaryReader(me))
                {
                    for (int i = 0; i < file.Length; i++)
                   {
                       byte res = br.ReadByte();
                       Console.WriteLine(res);
                    }
                    Console.WriteLine("end");
                    Console.WriteLine("no.of charchter={0}\n",me.Length.ToString());
                }
            }

            

        }
    }
}
