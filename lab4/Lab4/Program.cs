namespace lab4
{
    class Program
    {
        public static byte[] bt;
        private static string pathOut = "..\\..\\..\\output.txt";
        private static string pathIn = "..\\..\\..\\input.txt";


        static void Main(string[] args)
        {
           
            byte[] bRepTab = {
                0x4A,0x92,0xD8,0x0E,0x6B,0x1C,0x7F,0x53,
                0xEB,0x4C,0x6D,0xFA,0x23,0x81,0x07,0x59,
                0x58,0x1D,0xA3,0x42,0xEF,0xC7,0x60,0x9B,
                0x7D,0xA1,0x08,0x9F,0xE4,0x6C,0xB2,0x53,
                0x6C,0x71,0x5F,0xD8,0x4A,0x9E,0x03,0xB2,
                0x4B,0xA0,0x72,0x1D,0x36,0x85,0x9C,0xFE,
                0xDB,0x41,0x3F,0x59,0x0A,0xE7,0x68,0x2C,
                0x1F,0xD0,0x57,0xA4,0x92,0x3E,0x6B,0x8C
            };
            FileInfo file = new FileInfo(pathIn);
            string pass;
            if (!file.Exists) bt = textReader();
            else bt = fileReader();

            Coder cd = new Coder();
            
            Console.WriteLine("Введите пароль");
            pass = Console.ReadLine();
            cd.generateKey(pass); cd.SetReplaceTable(bRepTab);

            StreamWriter sw = new StreamWriter(pathOut);
            Console.WriteLine("\n");
            byte[] prvst = cd.SimpleEncoding(bt);  //кодирование простой вставкой 
            Console.WriteLine("{0} - кодирование простой заменой", System.Text.Encoding.ASCII.GetString(prvst));
            Console.WriteLine("Введите пароль");
            pass = Console.ReadLine();
            cd.generateKey(pass);
            Console.WriteLine("{0} - декодирование простой заменой\n", System.Text.Encoding.ASCII.GetString(cd.SimpleDecoding(prvst)));   //декодирование
            sw.WriteLine("Исходный текст: " + System.Text.Encoding.ASCII.GetString(bt));
            sw.WriteLine("Зашифрованный текст: " + System.Text.Encoding.ASCII.GetString(prvst));
            sw.WriteLine("Пароль: " + pass);
            sw.Close();
            Console.WriteLine("Результат записан в файл");
        }


        static byte[] textReader()
        {
            string str;

            do
            {
                Console.Write("введите текст кратный 8\n");
                str = Console.ReadLine();
            }
            while (str.Length % 8 != 0);
            byte[] tex1 = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                tex1[i] += Convert.ToByte(str[i]);
            }
            bt = tex1;
            return tex1;

        }
        static byte[] fileReader()
        {
            string str;
            StreamReader sr = new StreamReader(pathIn);
            str = sr.ReadLine();
            Console.WriteLine("Исходный текст: " + str);
            sr.Close();
            byte[] tex1 = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                tex1[i] += Convert.ToByte(str[i]);
            }
            bt = tex1;
            return tex1;

        }


    }
}