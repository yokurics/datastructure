using DataStructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Extentions
{
    public static class MyBinaryTreeNodeExtensions
    {
        public static void AddChildNodes<T>(this MyBinaryTreeNode<T> node, T leftValue, T rightValue)
        {
            node.Left = new MyBinaryTreeNode<T>(leftValue);
            node.Right = new MyBinaryTreeNode<T>(rightValue);
        }
    }
}
