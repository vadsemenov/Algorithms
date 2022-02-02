using System;

namespace Algorithms
{
    class TreeNode
    {
        int value;
        Tree left;
        Tree right;

        public TreeNode(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

        public TreeNode(int value, TreeNode left, TreeNode right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
}