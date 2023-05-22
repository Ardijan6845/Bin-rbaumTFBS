using Binärbaum;

namespace BinaryTree.UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new();  // Erzeugt eine Instanz der Node-Klasse, die den binären Baum repräsentiert.

            int[] numbers = { 4, 9, 24, 27, 30, 35, 39, 46, 47, 51, 64, 68, 75, 82, 90 };
            node.CreateBinaryTree(numbers);  // Erstellt den binären Baum aus dem gegebenen Array von Zahlen.

            // Fügt 100 Zahlen zum binären Baum hinzu.
            for (int i = 3; i <= 8; i++)
            {
                node.AddNumberToTree(i);
            }

            Console.WriteLine(node.FindMaximumValue(node.Root));  // Gibt den maximalen Wert im binären Baum aus.
            Console.WriteLine(node.FindMinimumValue(node.Root));  // Gibt den minimalen Wert im binären Baum aus.

            node.Root.PrintAscending();  // Gibt die Knotenwerte des Baums in aufsteigender Reihenfolge aus.
            Console.WriteLine();
            node.Root.PrintDescending();  // Gibt die Knotenwerte des Baums in absteigender Reihenfolge aus.

            Console.ReadKey();
        }
    }
}
