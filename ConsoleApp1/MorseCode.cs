using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MorseCode
    {


        private readonly Dictionary<string, string> _encodeDictionary = new Dictionary<string, string>
    {
            //pismena
            { "A", ".-" }, 
            { "B", "-..." },
            { "C", "-.-." }, 
            { "D", "-.." },
            { "E", "." }, 
            { "F", "..-." }, 
            { "G", "--." }, 
            { "H", "...." },
            { "CH", "----" },
            { "I", ".." },
            { "J", ".---" }, 
            { "K", "-.-" }, 
            { "L", ".-.." },
            { "M", "--" }, 
            { "N", "-." }, 
            { "O", "---" }, 
            { "P", ".--." },
            { "Q", "--.-" }, 
            { "R", ".-." }, 
            { "S", "..." }, 
            { "T", "-" },
            { "U", "..-" }, 
            { "V", "...-" }, 
            { "W", ".--" }, 
            { "X", "-..-" },
            { "Y", "-.--" }, 
            { "Z", "--.." },
            //cisla
            { "1", ".----" }, 
            { "2", "..---" }, 
            { "3", "...--" },
            { "4", "....-" }, 
            { "5", "....." }, 
            { "6", "-...." }, 
            { "7", "--..." },
            { "8", "---.." }, 
            { "9", "----." },
            { "0", "-----" },
            //znaky
            { ":", "---..." },
            { ";", "-.-.-." },
            { "=", "-...-" },
            { "+", ".-.-." },
            { ".", ".-.-.-" }, 
            { ",", "--..--" }, 
            { "?", "..--.." },
            { "!", "-.-.--" }, 
            { "/", "-..-." }, 
            { "(", "-.--." }, 
            { ")", "-.--.-" },
            { "&", ".-..." }, 
            { "-", "-....-" },
            { "_", "..--.-" }, 
            { @"\", ".-..-." },
            { "$", "...-..-" }, 
            { "@", ".--.-." }, 
            { " ", " " }, 
            
    };

        public string Encode(string text)
        {
            text = text.ToUpper();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'C' && i + 1 < text.Length && text[i + 1] == 'H')
                {
                    sb.Append(_encodeDictionary["CH"] + "/");
                    i++;
                }
                else if (_encodeDictionary.ContainsKey(text[i].ToString()))
                {
                    sb.Append(_encodeDictionary[text[i].ToString()] + "/");
                }
            }
            return sb.ToString().Trim();
        }

        public string Decode(string code)
        {
            string[] words = code.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (string word in words)
            {
                if (_encodeDictionary.ContainsValue(word))
                {
                    sb.Append(_encodeDictionary.FirstOrDefault(x => x.Value == word).Key);
                }
            }
            return sb.ToString();
        }
    } 
}