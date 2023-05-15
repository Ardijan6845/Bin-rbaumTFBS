namespace Binärbaum
{
    public class Node : IDisposable
    {
        public int ID { get; set; }
        public Node(int ID) { this.ID = ID; }

        public Node? LeftNode { get; set; }

        public Node? RightNode { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}