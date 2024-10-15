namespace Practice_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArr = { "The", "quick", "brown", "fox" };
            lock(myArr.SyncRoot)
            {
                int index = 0;
                foreach (var item in myArr)
                {
                    Console.WriteLine("[{0}]:{1}",index++, item);

                }
            }

            IList<string> myLis = Array.AsReadOnly(myArr);
            try
            {
                myLis[3] = "cat";
            }
            catch(NotSupportedException ex) 
            {
                Console.WriteLine("{0}-{1}",ex.GetType(),ex.Message);
            }
        }
    }
}
