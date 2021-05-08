using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker_Rank_Day_22_BinarySearchTree
{
    class Program
    {
        static void Main(String[] args)
        {
            //Given code
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
            Console.ReadKey();
        }

        static int getHeight(Node root)
        {
            //Write your code here

            // Check if root exist, if not subtract 1
            if (root == null)
            {
                return -1;
            }

            // If root exists, call method recursively while adding one(per recursion) and then comparing max values
            else
            {
                return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
            }
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }

    // Given Node Class
    class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}

//public static int getHeight(Node root)
//{
//    return root == null ? -1 : 1 + Math.max(getHeight(root.left), getHeight(root.right));
//}