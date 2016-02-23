using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab7_ind
{
    class Printer {

        public void printList(String[] list)
        {
            //Console.WriteLine(list.Length);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine("Tag #" + (i+1) + ": " + list[i]);                
            }
        }
    }



    class Program
    {        
        static void Main(string[] args)
        {
            // helper object for printing
            Printer printer = new Printer();           

            // read from file
            try 
            {
                using (StreamReader sr = new StreamReader("input.html"))
                { 
                    // read whole data
                    String data = sr.ReadToEnd();                    

                    Regex regex = new Regex(@"<\s*\w.*?>|(<\s*\/\s*\w\s*.*?>|<\s*br\s*>)");
                    Match match = regex.Match(data);

                    StreamWriter sw = new StreamWriter("out.txt", false, Encoding.GetEncoding(1251));

                    while (match.Success)
                    {
                        Console.WriteLine(match.Groups[0].Value);
                        sw.WriteLine(match.Groups[0].Value);
                        match = match.NextMatch();
                    }
                    
                    
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error while reading from file");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
