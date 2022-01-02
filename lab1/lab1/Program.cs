// See https://aka.ms/new-console-template for more information

using lab1;

string path = "C:\\Users\\mrmel\\source\\repos\\inf_sec\\lab1\\lab1\\input.txt";
FileInfo file = new FileInfo(path);

Seq seq = new Seq();
Test1 test1 = new Test1();
Test2 test2 = new Test2();
string res = "";

if (!file.Exists)
{
    StreamWriter sw = new StreamWriter(path);
    Console.WriteLine("Введите длину");
    seq.len = int.Parse(Console.ReadLine());
    seq.generateSeq();
    for (int i = 0; i < seq.len; i++)
    {
        res += seq.sequence[i];
    }
    sw.WriteLine(res);
    sw.Close();
}
else
{
    Console.WriteLine("Чтение из файла...");
    StreamReader sr = new StreamReader(path);
    string seqstr = sr.ReadLine();
    char[] seqstrarr = seqstr.ToCharArray();
    seq.len = seqstrarr.Length;
    for (int i = 0; i < seq.len; i++)
    {
        seq.sequence[i] = (int)seqstrarr[i] - 48;
    }
    res = seqstr;
    sr.Close();
}
Console.WriteLine(res);
test1.freqTest(seq.sequence, seq.len);
test2.identicalBitsTest(seq.sequence, seq.len); 