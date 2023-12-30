using Sana05;

internal class Program
{
    private static void Main(string[] args)
    {
        Airplane fligt = new Airplane("Zhytomyr", "Kiyv", new MyDate(), new MyDate(2023, 12, 31));
        Product product = new Product("Laprop", 1000, new Currency("USA", 38.76M), 10, 3.3f);
    }
}