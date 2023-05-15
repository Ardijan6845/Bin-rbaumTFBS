using Binärbaum;


namespace BinaryTree.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinärbaumCode binärbaumCode = new();

            int[] Zahlen = {4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90};

            binärbaumCode.CreateBinaryTree(Zahlen);

            var result = binärbaumCode.Root;

            Console.WriteLine(Zahlen.Max());
            Console.WriteLine(Zahlen.Min());

            Console.ReadKey();
        }
    }
}