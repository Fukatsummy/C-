﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Morse;
using System.Windows.Forms;


//namespace Morze
/*{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startText;
            Console.WriteLine("Введите текст для перевода в азбуку Морзе");
            startText = Console.ReadLine();
            startText = ConvertToMorse.TextToMorse(startText);
            Console.WriteLine("Ваш текст в виде азбуки Морзе" + startText);
        }
    }
}*/
//Создайте приложение для перевода обычного текст в азбуку Морзе.Пользователь вводит текст.Приложение
//отображает введенный текст азбукой Морзе.Используйте механизмы пространств имён.
namespace HomeWork_4
{
    public partial class Form_1 : Form
    {
       
        public Form_1()
        {
            InitializeComponent();
        }
        
    }
    
    internal class Morze
    {
        char[] Alfavit = new char[]
        {
                'А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р',
            'С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я','1','2','3','4',
            '5','6','7','8','9','0'
        };
        string[] Morse = new string[]
        {
                 "*-", "-***", "*--", "--*", "-**", "*", "*", "***-", "--**", "**", "*---", "-*-",
            "*-**", "--" ,"-*", "---", "*--*", "*-*", "***", "-", "**-", "**-*", "****", "-*-*",
            "---*", "----", "--*-", "--*--", "-*--", "-**-", "**-**", "**--", "*-*-", "*----",
            "**---", "***--", "****-", "*****", "-****", "--***", "---**", "----*", "-----"
        };
        public Morze()
        {
            WriteLine("Введите строку для зашифровки: ");
            string stroca = ReadLine();
            Encrypt(stroca);
            WriteLine();
            WriteLine("Ведите строку для расшифровки: ");
            string str = ReadLine();
            Decrypt(str);
        }
        private void Encrypt(string stroca)
        {
            stroca = stroca.ToUpper();
            string buffer = "";
            int index;
            foreach (char c in stroca)// поиск нужного элемента
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(Morse, c);//сохраняем символ в переменную index
                    buffer += Alfavit[index]+ " ";
                }
                //Write($"{buffer}");
                buffer = buffer.Remove(buffer.Length -1);//удаляет последний символ в стоке
                //return buffer;
            }
        }
        private string Decrypt(string stroca)
        {
            string[] sumb = stroca.Split(' ');//разбивает строку sumb на массив строк
            string buffer = "";
            int index;
            foreach (string s in sumb)
            {
                index = Array.IndexOf(Morse, s);
                buffer += Alfavit[index]+" ";
            }
            //Write($"{buffer}");
            buffer = buffer.Remove(buffer.Length -1);
            return buffer;
        }
    }
}
/*namespace Morse
{
    class ConvertToMorse
    {
        public static string TextToMorse(string alphaText)
        {
            char[] chars = alphaText.ToLower().ToCharArray();
            string[] massiveMorse = new string[] { "*-", "-***", "*--", "--*", "-**", "*", "*", "***-", "--**", "**", "*---", "-*-",
            "*-**", "--" ,"-*", "---", "*--*", "*-*", "***", "-", "**-", "**-*", "****", "-*-*",
            "---*", "----", "--*-", "--*--", "-*--", "-**-", "**-**", "**--", "*-*-", "*----",
            "**---", "***--", "****-", "*****", "-****", "--***", "---**", "----*", "-----" };
            string[] massiveAplhabet = new string[] { "а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н","о","п","р",
            "с","т","у","ф","х","ц","ч","ш","щ","ъ","ы","ь","э","ю","я","1","2","3","4","5","6","7","8","9","0" };
            string betaText;
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                foreach (string str in massiveAplhabet)
                {

                    if (chars[i] == str[0])
                    {
                        sb.Append(massiveMorse[count]);
                    }
                    count++;
                }
                count = 0;
            }
            return betaText = sb.ToString();

        }
        static string MorseToText()
        {
            return "";
        }
    }
}*/

