using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    // Объявление статического класса для хранения цветов приложения
    public static class AppColors
    {
        // Объявление приватного статического поля для цвета "оранжевый"
        private static readonly System.Drawing.Color _orange = System.Drawing.Color.FromArgb(226, 156, 69);

        // Объявление приватного статического поля для цвета "зеленый"
        private static readonly System.Drawing.Color _green = System.Drawing.Color.FromArgb(85, 156, 69);

        // Объявление приватного статического поля для светло-зеленого цвета
        private static readonly System.Drawing.Color _lightGreen = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        // Объявление приватного статического поля для светло-розового цвета
        private static readonly System.Drawing.Color _lightPink = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        // Публичное свойство для получения цвета "оранжевый"
        public static System.Drawing.Color Orange => _orange;

        // Публичное свойство для получения цвета "зеленый"
        public static System.Drawing.Color Green => _green;

        // Публичное свойство для получения светло-зеленого цвета
        public static System.Drawing.Color LightGreen => _lightGreen;

        // Публичное свойство для получения светло-розового цвета
        public static System.Drawing.Color LightPink => _lightPink;
    }
}
