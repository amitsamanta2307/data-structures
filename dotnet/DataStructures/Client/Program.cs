using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinaryTree.BinarySearchTree searchTree = new BinaryTree.BinarySearchTree();

            searchTree.Display();

            searchTree.Add(5);
            searchTree.Add(2);
            searchTree.Add(3);
            searchTree.Add(6);

            searchTree.Display();
        }
    }
}
