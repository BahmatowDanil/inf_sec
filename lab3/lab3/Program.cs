// See https://aka.ms/new-console-template for more information
using System.Text;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Режим работы: чтение из файла - 0, генерация случайных битов - 1");
            switch (Console.ReadLine())
            {
                case "0":
                    FromFile();
                    break;
                case "1":
                    FromBin();
                    break;
                default:
                    Console.WriteLine("Введено недопустимое значение");
                    break;
            }
        }

        static void FromFile()
        {
            MaHash2 maHash2 = new MaHash2();
            CubeConGen gen = new CubeConGen();
            string path = "C:\\Users\\mrmel\\source\\repos\\inf_sec\\lab3\\lab3\\";
            string alph = "abcdefghijklmnopqrstuvwxyzабвгдежзийклмнопрстуфхцчшыьэюя" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЫЬЭЮЯ" +
                " .!,?0123456789-+=)(*";
            Console.WriteLine("Чтение...");
            StreamReader sr = new StreamReader(path + "input.txt");
            string text = sr.ReadLine();
            sr.Close();
            Console.WriteLine("Оригинал: " + text);
            Console.WriteLine("Введите пароль:");                 
            string key = "" + gen.generateElem(maHash2.calculate(Console.ReadLine()));
            var pad = new Vernam(alph);
            string encrypt = pad.Crypt(text, key);
            Console.WriteLine("Шифротекст: " + encrypt);
            StreamWriter sw = new StreamWriter(path + "output.txt");
            sw.WriteLine(encrypt);
            sw.Close();
            Console.WriteLine("Введите пароль для расшивровки");
            key = "" + gen.generateElem(maHash2.calculate(Console.ReadLine()));
            string decrypt = pad.Crypt(encrypt, key);         
            Console.WriteLine("Расшифровка: " + decrypt);
        }

        static void FromBin()
        {
            string path = "C:\\Users\\mrmel\\source\\repos\\inf_sec\\lab3\\lab3\\";
            MaHash2 maHash2 = new MaHash2();
            AddGen ag = new AddGen();
            ag.len = 100;
            string text = ag.generateSeq();
            string alph = "01";
            Console.WriteLine("Оригинал: " + text);
            Console.WriteLine("Введите пароль:");
            string key = Convert.ToString(maHash2.calculate(Console.ReadLine()), 2);
            var pad = new Vernam(alph);
            string encrypt = pad.Crypt(text, key);
            Console.WriteLine("Шифротекст: " + encrypt);
            StreamWriter sw = new StreamWriter(path + "outputBin.txt");
            sw.WriteLine(encrypt);
            sw.Close();
            Console.WriteLine("Введите пароль для расшивровки");
            key = Convert.ToString(maHash2.calculate(Console.ReadLine()), 2);
            string decrypt = pad.Crypt(encrypt, key);
            Console.WriteLine("Расшифровка: " + decrypt);
        }
    }

    
}

