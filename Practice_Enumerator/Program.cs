namespace Practice_Enumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 8, 6, 10,1, 2,5,4,2};
            Array.Sort(nums);
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
