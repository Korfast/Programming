using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Статический класс, хранящий определённые цвета приложения.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет "оранжевый" (используется в приложении).
        /// </summary>
        private static readonly System.Drawing.Color _orange = System.Drawing.Color.FromArgb(226, 156, 69);

        /// <summary>
        /// Цвет "зеленый" (используется в приложении).
        /// </summary>
        private static readonly System.Drawing.Color _green = System.Drawing.Color.FromArgb(85, 156, 69);

        /// <summary>
        /// Светло-зеленый цвет.
        /// </summary>
        private static readonly System.Drawing.Color _lightGreen = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Светло-розовый цвет.
        /// </summary>
        private static readonly System.Drawing.Color _lightPink = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Возвращает цвет "оранжевый".
        /// </summary>
        public static System.Drawing.Color Orange => _orange;

        /// <summary>
        /// Возвращает цвет "зеленый".
        /// </summary>
        public static System.Drawing.Color Green => _green;

        /// <summary>
        /// Возвращает светло-зеленый цвет.
        /// </summary>
        public static System.Drawing.Color LightGreen => _lightGreen;

        /// <summary>
        /// Возвращает светло-розовый цвет.
        /// </summary>
        public static System.Drawing.Color LightPink => _lightPink;
    }
}
