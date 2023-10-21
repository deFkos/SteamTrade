using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;
using static SteamTrade.Controls.Dockpanel.Animation.IAnimation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Configuration;

namespace SteamTrade.Controls.Dockpanel.Animation
{
    class AnimationPanelCateg : IAnimation
    {
        public AnimationPanelCateg(Thickness thickness, DockPanel menu, int configuration = 1)
        {
            if (menu.Width >= 150 && menu.Height >= 135)
            {
                menu.Width += ShapeValueDeviation * configuration;
                thickness.Left -= ShapeValueDeviation * configuration;
                menu.Height += HvalueDeviation * configuration;
                if (menu.Opacity < opacityShape)
                {
                    menu.Opacity += OvalueDeviation * configuration;
                }
                menu.Margin = thickness;
            }
        }
    }
}
