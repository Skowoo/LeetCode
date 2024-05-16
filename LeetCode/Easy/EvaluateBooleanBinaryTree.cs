using LeetCode.CommonClasses;

namespace LeetCode.Easy
{
    internal class EvaluateBooleanBinaryTree
    {
        // 78 ms - OK
        public static bool EvaluateTree(TreeNode root)
        {
            static bool Recurse(TreeNode node)
            {
                if (node.val == 0)
                    return false;
                if (node.val == 1)
                    return true;
                if (node.val == 2)
                    return Recurse(node.left) || Recurse(node.right);
                else
                    return Recurse(node.left) && Recurse(node.right);
            }
            return Recurse(root);
        }

        // Switch ~~90 ms
        public static bool EvaluateTree_Switch(TreeNode root)
        {
            static bool Recurse(TreeNode node)
            {
                switch (node.val)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    case 2:
                        return Recurse(node.left) || Recurse(node.right);
                    case 3:
                        return Recurse(node.left) && Recurse(node.right);
                    default:
                        goto case 0;
                }
            }
            return Recurse(root);
        }
    }
}
