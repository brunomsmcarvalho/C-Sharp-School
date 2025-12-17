internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;        
        int b = a++;
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);

        int a1 = 10;
        int b1 = ++a1;
        System.Console.WriteLine(a1);
        System.Console.WriteLine(b1);
        //ha diferenca na p+osicao do ++ antes ou depois da variavel
    }
}