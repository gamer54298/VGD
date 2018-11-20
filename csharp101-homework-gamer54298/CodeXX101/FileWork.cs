using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //We have to add this line!

namespace CodeXX101
{
    public static class FileWork
    {
        public static void WriteText()
        {
            string path = "c:\\vgd\\poem.txt";
            string poemText = "\rThis is my poem. I hope you like it.";
            poemText += "\r\n\tIf not, you can take a hike it.";
            poemText += "\r\n\tMore text. More, more more!";

            if (File.Exists(path))
            {
                Console.WriteLine("File already exists.");
            } else
            {
                try
                {
                    File.WriteAllText(path, poemText);
                    Console.WriteLine("File written " + path);
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }


        }

        public static void AppendText()
        {
            string path = "c:\\vgd\\poem.txt";
            DateTime timestamp = DateTime.Now;
            string textTimeStamp = "\r\n\t" + timestamp.ToString() + "\r\n\t";
            try
            {
                File.AppendAllText(path, textTimeStamp);
                Console.WriteLine("File appended with {0}", textTimeStamp);
            } 
            catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
          
        }


        public static void ReadText()
        {
            string path = "c:\\vgd\\poem.txt";
            if (File.Exists(path))
            {
                try
                {
                    //Read the entire file at once
                    string text = File.ReadAllText(path);
                    Console.WriteLine(text);

                    //or... read line by line
                    string[] lines = File.ReadAllLines(path);
                    int n = 1;
                    foreach(string line in lines)
                    {
                        Console.WriteLine(n + ":  " + line);
                        n++;
                    }


                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } else
            {
                Console.WriteLine("File not found.");
            }

        }

        public static void Streaming()
        {
            //It's also possible to use the StreamWriter object to do all of this
            string path = "c:\\vgd\\demo.txt";
            string text = "Foobar, foobar.";
            string time = DateTime.Now.ToString();
            try
            {
                //Using "true" for second argument allows appending
                using (StreamWriter writer = new StreamWriter(path,true))
                {
                    writer.WriteLine(text + time + "\n\r");
                    writer.Close();
                }

                //Now, let's read the contents of the full file back.
                using (StreamReader reader = new StreamReader(path))
                   
                {
                    string line;
                    int n = 1;
                    while ( (line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(n+": " + line);
                        n++;
                    }
                }
                


            } catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }


    }
}
