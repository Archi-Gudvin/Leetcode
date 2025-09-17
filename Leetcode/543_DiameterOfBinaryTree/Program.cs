TreeNode root =
    new TreeNode(1,
        new TreeNode(2,
            new TreeNode(4),
            new TreeNode(5)
        ),
        new TreeNode(3)
    );

Console.WriteLine(DiameterOfBinaryTree(root));

int DiameterOfBinaryTree(TreeNode root)
{
    int diameter = 0;
    DFS(root, ref diameter);
    return diameter;
}

int DFS(TreeNode root, ref int diameter)
{
    if (root == null)
    {
        return 0;
    }

    int leftValue = DFS(root.left, ref diameter);

    int rightValue = DFS(root.right, ref diameter);

    diameter = Math.Max(diameter, leftValue + rightValue);

    return Math.Max(leftValue, rightValue) + 1;
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
