namespace GameProject.Framework.Managers {

    /// <summary>
    /// 事件消息回调函数类型定义
    /// </summary>
    /// <param name="data">事件消息数据</param>
    public delegate void EventCallback(EventData data);

    /// <summary>
    /// 事件消息类
    /// </summary>
    public class EventMessage {

        /// <summary>
        /// 事件回调缓存 
        /// </summary>
        public event EventCallback EventHandler;

        /// <summary>
        /// 触发
        /// </summary>
        /// <param name="data"></param>
        public void Handle(EventData data) {
            EventHandler?.Invoke(data);
        }


    }

}