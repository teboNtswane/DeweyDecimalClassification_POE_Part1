using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyDecimalClassification_POE_Part1.Tree
{
    public class MyTree
    {
        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Continued chat result, Geeks for Geeks
        /// URL: https://www.geeksforgeeks.org/binary-tree-data-structure/
        /// Use: This BinaryTreeNode class represents a single node in the binary tree
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class BinaryTreeNode<T>
        {
            public T Value { get; set; }
            public BinaryTreeNode<T> Left { get; set; }
            public BinaryTreeNode<T> Right { get; set; }

            public BinaryTreeNode(T value)
            {
                Value = value;
            }
        }

        //---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Reference: Continued chat result
        /// Use: This binary tree will be used to store data from the DeweyDataNew text file.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class BinaryTree<T>
        {
            private BinaryTreeNode<T> root;


            //---------------------------------------------------------------------------------------------------------------
            /// <summary>
            /// These methods will be used to insert the BinaryTreeNode into the binary tree
            /// </summary>
            /// <param name="value"></param>
            public void Insert(T value)
            {
                var node = new BinaryTreeNode<T>(value);

                if (root == null)
                {
                    root = node;
                }
                else
                {
                    InsertRecursively(root, node);
                }
            }


            private void InsertRecursively(BinaryTreeNode<T> current, BinaryTreeNode<T> newNode)
            {
                if (newNode.Value.GetHashCode() < current.Value.GetHashCode())
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                    }
                    else
                    {
                        InsertRecursively(current.Left, newNode);
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                    }
                    else
                    {
                        InsertRecursively(current.Right, newNode);
                    }
                }
            }

            //---------------------------------------------------------------------------------------------------------------
            /// <summary>
            /// 
            /// Use: Traverse the binary tree and collect all third level nodes and selects a random level node as the current question.
            /// </summary>
            /// <param name="level"></param>
            /// <returns></returns>
            public BinaryTreeNode<T> GetRandomNodeAtLevel(int level)
            {

                List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
                GetNodesAtLevelRecursively(root, level, nodes);
                int randomNumber = new Random().Next(nodes.Count);
                return nodes[randomNumber];
            }

            //---------------------------------------------------------------------------------------------------------------
            /// <summary>
            /// 
            /// Use: Add the level node to the list and recursively collects level nodes from the child nodes
            /// </summary>
            /// <param name="current"></param>
            /// <param name="level"></param>
            /// <param name="nodes"></param>
            private void GetNodesAtLevelRecursively(BinaryTreeNode<T> current, int level, List<BinaryTreeNode<T>> nodes)
            {
                if (current != null)
                {
                    if (level == 0)
                    {
                        
                        nodes.Add(current);
                    }
                    else
                    {
                        
                        GetNodesAtLevelRecursively(current.Left, level - 1, nodes);
                        GetNodesAtLevelRecursively(current.Right, level - 1, nodes);
                    }
                }
            }
        }
    }
}
///-------------------------------------------->000ooo...END OF FILE...ooo000<---------------------------------------------