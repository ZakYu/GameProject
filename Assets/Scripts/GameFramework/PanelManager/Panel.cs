using System;
using UnityEngine;

namespace GameProject.Framework.Managers
{
    [RequireComponent(typeof(RectTransform))]
    public class Panel : View
    {
        #region -- 面板常用的生命周期函数

        protected virtual void Awake()
        {
            this.gameObject.SetActive(false);
            Initial();
        }

        protected virtual void OnEnable()
        {
        }

        protected virtual void Start()
        {
        }

        protected virtual void OnDisable()
        {
        }

        protected virtual void OnDestroy()
        {
        }

        #endregion -- 面板常用的生命周期函数

        /// <summary>
        /// 面板实例化时进行初始化
        /// </summary>
        public virtual void Initial()
        {
        }

        /// <summary>
        /// 显示面板
        /// </summary>
        /// <param name="action"></param>
        public virtual void Display(Action action = null)
        {
            action?.Invoke();
            this.gameObject.SetActive(true);
        }

        /// <summary>
        /// 隐藏面板
        /// </summary>
        /// <param name="action"></param>
        public virtual void Hide(Action action = null)
        {
            action?.Invoke();
            this.gameObject.SetActive(false);
        }

        /// <summary>
        /// 销毁面板
        /// </summary>
        /// <param name="action"></param>
        public virtual void Destroy(Action action = null)
        {
            action?.Invoke();
            Destroy(this);
        }

        /// <summary>
        /// 设置面板节点
        /// </summary>
        /// <param name="node"></param>
        public virtual void SetNode(Transform node)
        {
            this.transform.SetParent(node);
            var rt = this.gameObject.GetComponent<RectTransform>();
            rt.anchoredPosition3D = Vector3.zero;
            rt.sizeDelta = Vector3.zero;
            rt.localScale = Vector3.one;
        }
    }
}