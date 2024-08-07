namespace LeetCode.Hard
{
    internal class RemoveMaxNumberOfEdgesToKeepGraphFullyTraversable
    {
        public static int MaxNumEdgesToRemove(int n, int[][] edges)
        {
            int[] alice = new int[n];
            int[] bob = new int[n];

            for (int i = 0; i < n; i++)
                alice[i] = i;

            Array.Copy(alice, bob, n);

            int used = 0;

            for (int i = 0; i < edges.Length; i++)
            {
                int[] edge = edges[i];
                if (edge[0] != 3)
                    continue;
                int u = edge[1] - 1;
                int v = edge[2] - 1;

                if (Find(alice, u) != Find(alice, v) || Find(bob, u) != Find(bob, v))
                {
                    Join(alice, u, v);
                    Join(bob, u, v);
                    used++;
                }
            }
            for (int i = 0; i < edges.Length; i++)
            {
                int[] edge = edges[i];
                if (edge[0] == 3) continue;
                int u = edge[1] - 1;
                int v = edge[2] - 1;
                if (edge[0] == 1 && Find(alice, u) != Find(alice, v))
                {
                    Join(alice, u, v);
                    used++;
                }
                if (edge[0] == 2 && Find(bob, u) != Find(bob, v))
                {
                    Join(bob, u, v);
                    used++;
                }
            }


            return IsNetwork(alice) && IsNetwork(bob) ? edges.Length - used : -1;
        }

        static void Join(int[] union, int u, int v)
        {
            u = Find(union, u);
            v = Find(union, v);
            union[u] = v;
        }

        static int Find(int[] union, int u)
        {
            if (union[u] == u) return u;
            union[u] = Find(union, union[u]);
            return union[u];
        }

        static bool IsNetwork(int[] union)
        {
            int target = Find(union, union[0]);
            foreach (var el in union)
                if (target != Find(union, el))
                    return false;

            return true;
        }
    }
}
