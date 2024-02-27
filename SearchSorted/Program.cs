namespace SearchSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int element = int.Parse(Console.ReadLine());
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                if (element == list[i])
                {
                    Console.WriteLine("Yes");
                    break;
                }
                else if(element != list[i])
                {
                }
                else 
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
