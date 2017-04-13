using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static int leftSum,rightSum,total;


        static void Main(string[] args)
        {
            CreateMyBinaryTree();
        }

        private static void CreateMyBinaryTree()
        {
            int[] items = new int[8] {6,13,2,3,9,10,4,5};
            Node addItems = new Node(7);
            foreach(int no in items)
            {
                addItems.addBinaryNodes(no);
            }
            int sum = getSumOfNodes(addItems);
            Console.WriteLine(sum);
            Console.ReadLine();   
        }

        private static int getSumOfNodes(Node currentNode)
        {
            if (currentNode == null)
            {
                return 0;
            }
            //else if(currentNode.left==null && currentNode.right == null)
            //{
            //    return 0;
            //}
            else
            {
                leftSum = getSumOfNodes(currentNode.left);
                rightSum = getSumOfNodes(currentNode.right);
                total = currentNode.value + leftSum + rightSum;
                return total;
            }
        }
    }


    class Node
    {
        public Node left;
        public Node right;
        public int value;

        public Node()
        {

        }
        public Node(int num)
        {
            this.value = num;
            this.left = null;
            this.right = null;

        }

        public void addBinaryNodes(int num)
        {
            // Left Section
            if(num< this.value)
            {
                if (this.left != null)
                {
                    this.left.addBinaryNodes(num);
                }
                else
                {
                    this.left = new Node(num);
                }
            }
            // Right Section
            else if(num>this.value)
            {
                if (this.right != null)
                {
                    this.right.addBinaryNodes(num);
                }
                else
                {
                    this.right = new Node(num);
                }
            }
        }

    }

}
