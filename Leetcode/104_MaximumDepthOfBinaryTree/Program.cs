TreeNode root =
    new TreeNode(3,
        new TreeNode(9),
        new TreeNode(20,
            new TreeNode(15),
            new TreeNode(7)
        )
    );


Console.WriteLine(MaxDepth(root));

int MaxDepth(TreeNode root)
{
    if (root is null)
        return 0;

    int leftMaxDepth = MaxDepth(root.left);
    int rightMaxDepth = MaxDepth(root.right);
    
    return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
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