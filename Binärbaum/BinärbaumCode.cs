using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binärbaum;

public class BinärbaumCode
{
        public Node Root { get; set; }

        public void CreateBinaryTree(int[] values)
        {
            Root = CreateBinaryTreeRecursive(values, 0, values.Length - 1);
        }

        private Node CreateBinaryTreeRecursive(int[] values, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            // Finde die Mitte des Arrays
            int mid = (start + end) / 2;

            // Erstelle den Node für den Wert in der Mitte
            Node node = new Node(values[mid]);

            // Setze die Verbindungen zu den linken und rechten Subtrees
            node.LeftNode = CreateBinaryTreeRecursive(values, start, mid - 1);
            node.RightNode = CreateBinaryTreeRecursive(values, mid + 1, end);

            return node;
        }
 }
