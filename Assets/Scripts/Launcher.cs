using UnityEngine;

namespace GameProject
{
    /// <summary>
    /// 启动器 - 入口程序
    /// </summary>
    public class Launcher : MonoBehaviour
    {
        private void Awake()
        {
            Initial();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Initial()
        {

            InitialAppWidthAndHeight();
        }

        /// <summary>
        /// 初始化游戏屏幕宽高的值
        /// </summary>
        private void InitialAppWidthAndHeight()
        {
            var orientation = Screen.orientation;
            // 横屏
            if (orientation == ScreenOrientation.Landscape)
            {

            }
            // 竖屏
            else if (orientation == ScreenOrientation.Portrait)
            {

            }
        }
    }
}
