namespace Day19_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Binary Search Tree Problem");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();

            ///UC1: Add the node in the tree and it doesnot have any output just display welcome message

            BinaryTree.AddNode(56);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(70);
            BinaryTree.AddNode(22);
            BinaryTree.AddNode(40);
            BinaryTree.AddNode(11);
            BinaryTree.AddNode(63);
            BinaryTree.AddNode(67);
            BinaryTree.AddNode(16);
            BinaryTree.AddNode(60);
            BinaryTree.AddNode(95);
            BinaryTree.AddNode(65);
            BinaryTree.AddNode(3);
            //UC2:create the bst as shown and find the size of tree

            int Size = BinaryTree.GetSize();
            Console.WriteLine(Size);
            //uc3:Ability to search the given node
            bool result = BinaryTree.SearchKey(63);
            Console.WriteLine(result);
            //output
            //Welcome To Binary Search Tree Problem
            //13
            //True


        }
    }
}