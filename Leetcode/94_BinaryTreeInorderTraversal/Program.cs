TreeNode root =
        new TreeNode(1,
                new TreeNode(2,
                        new TreeNode(4),
                        new TreeNode(5,
                                new TreeNode(6),
                                new TreeNode(7, null, new TreeNode(9)))
                ),
                new TreeNode(3,
                        null,
                        new TreeNode(8)
                )
        );

var result = InorderTraversal(root);

foreach (var item in result)
{
        Console.Write($"{item} ");
}

IList<int> InorderTraversal(TreeNode root)
{
        IList<int> res = new List<int>();

        if (root is null)
                return res;

        Stack<TreeNode> stack = new Stack<TreeNode>();

        var curr = root;
        
        while (stack.Count > 0 || curr != null)
        {
                while (curr != null)
                {
                        stack.Push(curr);
                        curr = curr.left;
                }

                curr = stack.Pop();
                res.Add(curr.val);
                curr = curr.right;
        }
        
        return res;
}

public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
        }
}