namespace Binärbaum
{
    public class Node : IDisposable
    {
        public int ID { get; set; }  // Die ID des Knotens im binären Baum.
        public Node? LeftNode { get; set; }  
        public Node? RightNode { get; set; } 
        public Node Root { get; set; } 

        public Node(int ID)
        {
            this.ID = ID;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Node()
        {
            // Leerer Konstruktor.
        }

        public void CreateBinaryTree(int[] values)
        {
            // Erstellt einen binären Baum aus einem Array von Werten.
            Root = CreateBinaryTreeRecursive(values, 0, values.Length - 1);
        }

        // Erstellt den binären Baum rekursiv.
        private Node CreateBinaryTreeRecursive(int[] values, int start, int end)
        {
            if (start > end)
            {
                return null;  // Basisfall: Wenn der Startindex größer als der Endindex ist, wird null zurückgegeben.
            }

            // Finde die Mitte des Arrays.
            int mid = (start + end) / 2;

            // Erstelle den Knoten für den Wert in der Mitte.
            Node node = new Node(values[mid]);

            // Setze die Verbindungen zu den linken und rechten Teilbäumen.
            node.LeftNode = CreateBinaryTreeRecursive(values, start, mid - 1);
            node.RightNode = CreateBinaryTreeRecursive(values, mid + 1, end);

            return node;
        }

        // Rekursive Methode, um den minimalen Wert im binären Baum zu finden.
        public int FindMinimumValue(Node node)
        {
            if (node.LeftNode == null)
            {
                return node.ID;  // Basisfall: Wenn der linke Kindknoten null ist, ist der aktuelle Knoten der kleinste Wert.
            }

            return FindMinimumValue(node.LeftNode);  // Rekursiver Aufruf mit dem linken Kindknoten.
        }

        // Rekursive Methode, um den maximalen Wert im binären Baum zu finden.
        public int FindMaximumValue(Node node)
        {
            if (node.RightNode == null)
            {
                return node.ID;  // Basisfall: Wenn der rechte Kindknoten null ist, ist der aktuelle Knoten der größte Wert.
            }

            return FindMaximumValue(node.RightNode);  // Rekursiver Aufruf mit dem rechten Kindknoten.
        }

        // Gibt die Knotenwerte des Baums in aufsteigender Reihenfolge aus.
        public void PrintAscending()
        {
            if (this == null)
            {
                return;  // Basisfall: Wenn der aktuelle Knoten null ist, wird die Methode beendet.
            }

            this.LeftNode?.PrintAscending();  // Rekursiver Aufruf mit dem linken Kindknoten.
            Console.Write(this.ID + " ");  // Gib den Wert des aktuellen Knotens aus.
            this.RightNode?.PrintAscending();  // Rekursiver Aufruf mit dem rechten Kindknoten.
        }

        // Gibt die Knotenwerte des Baums in absteigender Reihenfolge aus.
        public void PrintDescending()
        {
            if (this == null)
            {
                return;  // Basisfall: Wenn der aktuelle Knoten null ist, wird die Methode beendet.
            }

            RightNode?.PrintDescending();  // Rekursiver Aufruf mit dem rechten Kindknoten.
            Console.Write(ID + " ");  // Gib den Wert des aktuellen Knotens aus.
            LeftNode?.PrintDescending();  // Rekursiver Aufruf mit dem linken Kindknoten.
        }

        // Fügt eine Zahl zum Baum hinzu.
        public void AddNumberToTree(int number)
        {
            if (Root == null)
            {
                Root = new Node(number);  // Wenn der Baum leer ist, wird die Zahl als Wurzel des Baums hinzugefügt.
            }
            else
            {
                AddNumberToTreeRecursive(Root, number);
            }
        }

        // Rekursive Methode, um eine Zahl zum Baum hinzuzufügen.
        private void AddNumberToTreeRecursive(Node node, int number)
        {
            if (number < node.ID)
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = new Node(number);  // Wenn die Zahl kleiner als der aktuelle Knoten ist und der linke Kindknoten null ist, wird die Zahl als linker Kindknoten hinzugefügt.
                }
                else
                {
                    AddNumberToTreeRecursive(node.LeftNode, number);  // Rekursiver Aufruf mit dem linken Kindknoten.
                }
            }
            else if (number > node.ID)
            {
                if (node.RightNode == null)
                {
                    node.RightNode = new Node(number);  // Wenn die Zahl größer als der aktuelle Knoten ist und der rechte Kindknoten null ist, wird die Zahl als rechter Kindknoten hinzugefügt.
                }
                else
                {
                    AddNumberToTreeRecursive(node.RightNode, number);  // Rekursiver Aufruf mit dem rechten Kindknoten.
                }
            }
        }
    }
}
