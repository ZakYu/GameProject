namespace GameProject.Framework.Managers
{
    /// <summary>
    /// 事件消息数据类
    /// </summary>
    public class EventData
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public EEventType Type;

        /// <summary>
        /// 事件数据
        /// </summary>
        public object[] Data;

        /// <summary>
        /// 获取事件数据
        /// </summary>
        /// <param name="index"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetData<T>(int index)
        {
            if (Data is null || Data.Length - 1 < index)
            {
                return default;
            }
            return (T)Data[index];
        }
    }
}