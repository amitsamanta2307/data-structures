using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        private TreeNode root;

        public void Add(int data)
        {
            bool found = false;
            TreeNode current = root;
            TreeNode previous = root;

            while (current != null && !found)
            {
                previous = current;

                if (data == current.Value)
                    found = true;
                else if (data < current.Value)
                    current = current.Left;
                else
                    current = current.Right;
            }

            if (!found)
            {
                current = new TreeNode(data);

                if (root != null)
                {
                    if (data < previous.Value)
                        previous.Left = current;
                    else
                        previous.Right = current;
                }
                else
                {
                    root = current;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine(root);
        }
    }
}
