TreeNode root =
    new TreeNode(5,
        new TreeNode(4,
            new TreeNode(11,
                new TreeNode(7),
                new TreeNode(2)
            ),
            null
        ),
        new TreeNode(8,
            new TreeNode(13),
            new TreeNode(4,
                null,
                new TreeNode(1)
            )
        )
    );

int targetSum = 22;

Console.WriteLine(HasPathSum(root, targetSum));


bool HasPathSum(TreeNode root, int targetSum)
{
    if (root is null)
    {
        return false;
    }
    
    targetSum -= root.val;

    if (root.left is null && root.right is null)
    {
        return targetSum == 0;
    }

    return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
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