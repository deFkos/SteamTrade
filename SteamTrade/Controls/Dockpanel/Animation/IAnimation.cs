using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SteamTrade.Controls.Dockpanel.Animation
{
    interface IAnimation
    {
        public static bool activeRec = true;
        public const int WidthPanelCateg = 300;
        public const int ShapeValueDeviation = 18;
        public const int HvalueDeviation = 28;
        public const int opacityShape = 100;
        public const double OvalueDeviation = 0.06;
        public static bool configurationSelect = true;
        public static double Actualwidth = 0;
    }
}
