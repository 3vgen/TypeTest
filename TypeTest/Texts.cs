using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TypeTest
{
    class Texts
    {
        Random random = new Random();
        string[] texsts;
        StreamReader read;
        public Texts()
        {
            read = new StreamReader(@"C:\Users\МБОУ ЦО 2\source\repos\TypeTest\TypeTest\TextSamples.txt");
            texsts = read.ReadToEnd().Split('#');
        }
        public string GetText()
        {
            string text;
            text = texsts[random.Next(texsts.Length)];
            return text;
        }


    }
}
