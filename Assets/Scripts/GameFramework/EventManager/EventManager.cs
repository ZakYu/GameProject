using System.Collections.Generic;
using GameProject.Helper.Patterns;

namespace GameProject.Framework.Managers
{
    /// <summary>
    /// 事件消息管理类
    /// </summary>
    public class EventManager : MonoSingleton<EventManager>
    {
        /// <summary>
        /// 监听池
        /// </summary>
        private Dictionary<EEventType, EventMessage> _EventListeners;

        protected override void Initialize()
        {
            _EventListeners = new Dictionary<EEventType, EventMessage>();
        }

        /// <summary>
        /// 添加事件监听
        /// </summary>
        /// <param name="type">事件类型</param>
        /// <param name="handler">事件回调</param>
        public void AddListener(EEventType type, EventHandler handler)
        {
            if (_EventListeners is null)
            {
                _EventListeners = new Dictionary<EEventType, EventMessage>();
            }
            if (!_EventListeners.ContainsKey(type))
            {
                _EventListeners.Add(type, new EventMessage());
            }
            _EventListeners[type].AddHandler(handler);
        }

        /// <summary>
        /// 触发事件
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        public void TriggerEvent(EEventType type, params object[] data)
        {
            if (_EventListeners is null || !_EventListeners.ContainsKey(type))
            {
                return;
            }
            _EventListeners[type].Handle(ParseData(type, data));
        }

        /// <summary>
        /// 删除事件监听
        /// </summary>
        /// <param name="type">事件类型</param>
        /// <param name="handler">事件回调</param>
        public void RemoveListener(EEventType type, EventHandler handler)
        {
            if (_EventListeners is null || !_EventListeners.ContainsKey(type))
            {
                return;
            }
            _EventListeners[type].RemoveHandler(handler);
        }

        /// <summary>
        /// 删除所有事件
        /// </summary>
        public void Clear()
        {
            _EventListeners.Clear();
        }

        /// <summary>
        /// 数据转换 - Object to EventData
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private EventData ParseData(EEventType type, object[] data)
        {
            return new EventData()
            {
                Type = type,
                Data = data
            };
        }
    }
}