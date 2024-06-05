namespace Practice_ManagedUnmanagedResources
{
    internal class ResourceHolder : IDisposable
    {
        private IntPtr unmanagedResource;  // 非托管资源
        private StreamReader managedResource; // 托管资源
        private bool disposed = false;

        public ResourceHolder(int number, string filePath)
        { 
            // 分配非托管资源
            unmanagedResource = new IntPtr(number);

            // 分配托管资源
            managedResource = new StreamReader(filePath);
        }

        // 实现 IDisposable 接口的 Dispose 方法
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // 受保护的虚方法，以便子类可以重写
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                // 释放托管资源
                if (disposing) 
                {
                    if (managedResource != null)
                    {
                        managedResource.Dispose();
                        managedResource = null;
                    }
                }
                // 释放非托管资源
                if (unmanagedResource != IntPtr.Zero)
                {
                    unmanagedResource = IntPtr.Zero;
                }
                disposed = true;
            }
        }

        // 析构函数，确保资源在未显式调用 Dispose 方法时也能释放
        ~ResourceHolder()
        {
            Dispose(false);
        }
    }
}
