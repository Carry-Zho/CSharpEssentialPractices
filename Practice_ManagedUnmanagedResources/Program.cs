namespace Practice_ManagedUnmanagedResources
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ResourceHolder handlerUsing = new ResourceHolder(123, "D:\\unmanaged.txt"))
            {

            }
            ResourceHolder handlerManual = null;
            try
            {
                handlerManual = new ResourceHolder(123, "D:\\unmanaged.txt");
            }
            finally
            {
                if (handlerManual != null) 
                {
                    handlerManual.Dispose();
                }
            }
            

        }
    }
}