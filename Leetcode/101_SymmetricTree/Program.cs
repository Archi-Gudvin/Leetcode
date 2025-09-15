TreeNode root =
    new TreeNode(1,
        new TreeNode(2,
            null,
            new TreeNode(3)
        ),
        new TreeNode(2,
            null,
            new TreeNode(3)
        )
    );

// TreeNode root =
//     new TreeNode(1,
//         new TreeNode(2,
//             new TreeNode(3),
//             new TreeNode(4)
//         ),
//         new TreeNode(2,
//             new TreeNode(4),
//             new TreeNode(3)
//         )
//     );



Console.WriteLine(IsSymmetric(root));

bool IsSymmetric(TreeNode root)
{
    return IsSymmetricHelper(root.left, root.right);
}

bool IsSymmetricHelper(TreeNode root1, TreeNode root2)
{
    if (root1 is null && root2 is null)
    {
        return true;
    }
    
    if (root1 is null || root2 is null)
    {
        return false;
    }

    if (root1.val != root2.val)
    {
        return false;
    }

    bool left = IsSymmetricHelper(root1.left, root2.right);
    bool right = IsSymmetricHelper(root1.right, root2.left);
    
    return left && right;
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