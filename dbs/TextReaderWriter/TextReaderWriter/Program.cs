using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextReaderWriter
{
    class Program
    {
        static readonly int MAGIC_NUMBER = 42;
        static readonly string FILE_PATH = @"C:\Users\iv\Documents\1VS2017_Exercises\DOOHT\helloworld.txt";
        static readonly string FILE_PATH2 = @"C:\Users\iv\Documents\1VS2017_Exercises\DOOHT\helloworld2.txt";

        /*
        Note that when it comes to streams we must be aware that they are inherently
        binary--they only understand and work with byte data. The interpretation of
        a given byte must be agreed between a producer and a consumer. When we come
        to writing out text, we are faced with an encoding choice--are we encoding
        ASCII or Unicode and, if the latter, what exact encoding scheme are we using
        (predominately either UTF8 or UTF16). By default, TextWriter/TextReader
        classes make use of the UTF8 encoding scheme.
        */
        static void Main(string[] args)
        {
            using (FileStream fstream = File.Create(FILE_PATH))
            /*
            Observe the explicit use of the encoding enum value set to UTF8--it is 
            always best to be explicit in your code and not rely on default class
            values/behaviours.
            */
            using (TextWriter txtWriter = new StreamWriter(fstream, Encoding.UTF8))
            {
                txtWriter.Write('A');
                txtWriter.WriteLine(" short story...");
                txtWriter.Write("Hello ");
                txtWriter.WriteLine("World!");
                /*
                Recall that WriteLine puts out the \r\n combination--we can emulate this
                in a platform independent way by using Write along with Environment.NewLine
                */
                txtWriter.Write("The end" + Environment.NewLine);

                /*
                We can also output numbers, but these will be converted to text values,
                so we will have to "reconstitute" these back to numbers ourselves when
                we come to reading them--see code below.
                */
                txtWriter.Write(MAGIC_NUMBER);
            }

            using (FileStream fStream = File.OpenRead(FILE_PATH))
            using(TextReader txtReader = new StreamReader(fStream, Encoding.UTF8))
            {
                while (txtReader.Peek() > -1)
                {
                    string line = txtReader.ReadLine();
                    if (line.Equals(MAGIC_NUMBER.ToString()))
                    {
                        /*
                        Here we "reconstitute" back the numerical value from the
                        string version of the number we wrote to the stream.
                        */
                        int magicNum;
                        if(int.TryParse(line, out magicNum))
                        {
                            Console.WriteLine($"Magic number, {magicNum}, multiplied by 2 = {magicNum * 2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            // Shorthand versions of the above code using static File based functions
            CreateSecondFile();

            PrintSecondFile();

            File.Delete(FILE_PATH2);

            CreateSecondFile();

            AppendText();

            PrintSecondFile();

            Console.ReadLine();
        }

        private static void PrintSecondFile()
        {
            using (TextReader txtReader = File.OpenText(FILE_PATH2))
            {
                while (txtReader.Peek() > -1)
                {
                    Console.WriteLine(txtReader.ReadLine());
                }
                /*
                The rough equivalent of the above is:
                string line;
                while((line = txtReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                */
            }
        }

        private static void CreateSecondFile()
        {
            if (!File.Exists(FILE_PATH2))// same as if(File.Exists(FILE_PATH2) == false)
            {
                using (TextWriter txtWriter = File.CreateText(FILE_PATH2))
                {
                    txtWriter.WriteLine("File number 2");
                    txtWriter.Write('A');
                    txtWriter.WriteLine(" short story...");
                }
            }
        }

        private static void AppendText()
        {
            if(File.Exists(FILE_PATH2))
            {
                using (TextWriter txtWriter = File.AppendText(FILE_PATH2))
                {
                    txtWriter.WriteLine("Appended some text here");
                }
            }
        }
    }
}
