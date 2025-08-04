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
                    if (!int.TryParse(args[i], out ints[i]))
                        throw new ArgumentException("Argument must be a valid integer");
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
