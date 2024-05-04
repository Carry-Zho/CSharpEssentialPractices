namespace Practice_15._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{ 1, 2, 3, 4, 5, 6 };

            //语法糖
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            //编译器创建的等价for循环
            int[] tempArray;
            tempArray = array;
            for(int counter = 0; (counter < array.Length); counter++) 
            {
                int item = tempArray[counter];
                Console.WriteLine(item);
            }
        }
    }
}