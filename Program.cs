namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                int[] ints = new int[args.Length];
                for(int i = 0; i < args.Length; i++)
                {
                    ints[i] = Convert.ToInt32(args[i]);
                }
                Console.WriteLine(IsIndividuallyUnique(ints));
            }
        }
        static bool IsIndividuallyUnique(int[] ints)
        {
            HashSet<int> elements = new();

            foreach (int i in ints)
            {
                if(elements.Contains(i))
                {
                    return false;
                }
                else
                {
                    elements.Add(i);
                }
            }

            return true;
        }
    }
}
