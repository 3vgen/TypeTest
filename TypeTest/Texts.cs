using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace TypeTest
{
    class Texts
    {
        Random random = new Random();
        string texsts;
        StreamReader read;
        public Texts()
        {
            read = new StreamReader(@"/Users/evgenijsemin/Desktop/GIT/TypeTest/TypeTest/TextSamples.txt");
            texsts = read.ReadToEnd();
        }
        public string GetText()
        {
            string text;
            text = texsts;
            text.Replace(Environment.NewLine, " ");
            return text;
        }


    }
}
