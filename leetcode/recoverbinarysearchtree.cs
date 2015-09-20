// https://leetcode.com/problems/recover-binary-search-tree/
    public class Solution
    {

        public void RecoverTree(TreeNode root)
        {
            var list = new List<int>();

            Traverse(root, list);
            var arr = list.ToArray();
            var list2 = new List<int>();
            int temp = -1;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    if (list2.Count() != 0)
                    {
                        list2.Add(i + 1);
                    }
                    else
                    {
                        list2.Add(i);
                        temp = i + 1;
                    }
                }
            }

            if (list2.Count() == 2)
            {
                var t1 = Search(root, arr[list2[0]]);
                var t2 = Search(root, arr[list2[1]]);
                Exchange(t1, t2);
            }
            else
            {
                var t1 = Search(root, arr[list2[0]]);
                var t2 = Search(root, arr[temp]);
                Exchange(t1, t2);
            }
            
        }

        private void Exchange(TreeNode one, TreeNode two)
        {
            var temp = one.val;
            one.val = two.val;
            two.val = temp;
        }

        private TreeNode Search(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }

            var node = Search(root.left, val);

            if (node != null)
            {
                return node;
            }

            return Search(root.right, val);
        }

        private void Traverse(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.left, list);

            list.Add(root.val);

            Traverse(root.right, list);
        }
    }
