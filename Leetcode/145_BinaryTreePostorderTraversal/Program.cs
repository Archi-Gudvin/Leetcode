
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

var result = PostorderTraversal(root);

foreach (var item in result)
{
    Console.Write($"{item} ");
}

IList<int> PostorderTraversal(TreeNode root)
{
    IList<int> res = new List<int>();

    PostorderTraversalHelper(root, res);

    return res;
}

void PostorderTraversalHelper(TreeNode curr, IList<int> result)
{
    if (curr is null)
        return;

    PostorderTraversalHelper(curr.left, result);
    PostorderTraversalHelper(curr.right, result);
    
    result.Add(curr.val);
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