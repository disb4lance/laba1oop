namespace ClassLibrary1
{
    public class TreeNode
    {
        public int Value { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }

        public List<int> PrintChildren()
        {
            var mas = new List<int>();
            mas.Add(Value);

            if (Children == null)
                return mas;

            foreach (var child in Children)
            {
                mas.AddRange(child.PrintChildren());
            }

            return mas;
        }
    }
}
