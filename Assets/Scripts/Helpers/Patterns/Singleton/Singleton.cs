namespace GameProject.Helper.Patterns
{
    /// <summary>
    /// 单例类
    /// </summary>
    public abstract class Singleton<T> where T : new()
    {
        public static T Instance
        {
            get
            {
                return Nested._Instance;
            }
        }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly T _Instance = new T();
        }

        protected Singleton()
        {
            Initialize();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        protected virtual void Initialize() { }
    }
}