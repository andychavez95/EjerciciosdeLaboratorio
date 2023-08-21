namespace Guia_Lab_03_Ejer1
{
    public class Node
    {
        private int element;
        private Node node;

        public Node(int elem)
        {
            this.element = elem;
        }

        public void setElemNode(int elem)
        {
            this.element = elem;
        }

        public int getElemNode()
        {
            return this.element;
        }

        public Node getNextNode()
        {
            return this.node;
        }

        public void setNextNode(Node node)
        {
            this.node = node;
        }
    }
}