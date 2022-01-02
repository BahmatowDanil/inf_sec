// See https://aka.ms/new-console-template for more information

using lab2;


string path1 = "..\\..\\..\\input1.txt";
string path2 = "..\\..\\..\\input2.txt";
FileInfo file1 = new FileInfo(path1);
FileInfo file2 = new FileInfo(path2);

ConGen seq1 = new ConGen();
AddGen seq2 = new AddGen();   
Test1 test1 = new Test1();
Test2 test2 = new Test2();

string res = "";
Console.WriteLine("Линейный конгруэнтный генератор:");
if (!file1.Exists)
{
    StreamWriter sw = new StreamWriter(path1);
    Console.WriteLine("Введите длину");
    seq1.len = int.Parse(Console.ReadLine());
    seq1.generateSeq();
    for (int i = 0; i < seq1.len; i++)
    {
        res += seq1.sequence[i];
    }
    sw.WriteLine(res);
    sw.Close();
}
else
{
    Console.WriteLine("Чтение из файла...");
    StreamReader sr = new StreamReader(path1);
    string seqstr = sr.ReadLine();
    char[] seqstrarr = seqstr.ToCharArray();
    seq1.len = seqstrarr.Length;
    for (int i = 0; i < seq1.len; i++)
    {
        seq1.sequence[i] = (int)seqstrarr[i] - 48;
    }
    res = seqstr;
    sr.Close();
}
Console.WriteLine(res);
test1.freqTest(seq1.sequence, seq1.len);
test2.identicalBitsTest(seq1.sequence, seq1.len);

Console.WriteLine("\nАддитивный генератор генератор:");
res = "";
if (!file2.Exists)
{
    StreamWriter sw = new StreamWriter(path2);
    Console.WriteLine("Введите длину");
    seq2.len = int.Parse(Console.ReadLine());
    seq2.generateSeq();
    for (int i = 0; i < seq2.len; i++)
    {
        res += seq2.sequence[i];
    }
    sw.WriteLine(res);
    sw.Close();
}
else
{
    Console.WriteLine("Чтение из файла...");
    StreamReader sr = new StreamReader(path2);
    string seqstr = sr.ReadLine();
    char[] seqstrarr = seqstr.ToCharArray();
    seq2.len = seqstrarr.Length;
    for (int i = 0; i < seq2.len; i++)
    {
        seq2.sequence[i] = (int)seqstrarr[i] - 48;
    }
    res = seqstr;
    sr.Close();
}
Console.WriteLine(res);
test1.freqTest(seq2.sequence, seq2.len);
test2.identicalBitsTest(seq2.sequence, seq2.len);
