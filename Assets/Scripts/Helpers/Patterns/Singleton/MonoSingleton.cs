using UnityEngine;

namespace GameProject.Helper.Patterns
{
    /// <summary>
    /// 单例类 - 继承于 MonoBehaviour
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
    {
        protected static T _Instance;

        protected virtual void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this as T;

            // 可选
            DontDestroyOnLoad(gameObject);

            Initialize();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        protected virtual void Initialize() { }

        public static T Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = (T)FindObjectOfType(typeof(T));
                }
                return _Instance;
            }
            protected set
            {
                _Instance = value;
            }
        }

        /// <summary>
        /// 是否存在对象实例
        /// </summary>
        public static bool HasInstance
        {
            get { return _Instance != null; }
        }
    }
}