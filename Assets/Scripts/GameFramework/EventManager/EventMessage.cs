namespace GameProject.Framework.Managers
{
    /// <summary>
    /// 事件消息回调函数类型定义
    /// </summary>
    /// <param name="data">事件消息数据</param>
    public delegate void EventHandler(EventData data);

    /// <summary>
    /// 事件消息类
    /// </summary>
    public class EventMessage
    {
        /// <summary>
        /// 事件回调缓存
        /// </summary>
        public event EventHandler Handler;

        /// <summary>
        /// 执行回调
        /// </summary>
        /// <param name="data"></param>
        public void Handle(EventData data)
        {
            Handler?.Invoke(data);
        }

        /// <summary>
        /// 添加回调
        /// </summary>
        /// <param name="handler"></param>
        public void AddHandler(EventHandler handler)
        {
            Handler += handler;
        }

        /// <summary>
        /// 删除回调
        /// </summary>
        /// <param name="handler"></param>
        public void RemoveHandler(EventHandler handler)
        {
            if (Handler is null)
            {
                return;
            }
            Handler -= handler;
        }

        /// <summary>
        /// 获取监听个数
        /// </summary>
        /// <returns></returns>
        public int GetListenerCount()
        {
            if (Handler is null) return 0;
            return Handler.GetInvocationList().Length;
        }
    }
}