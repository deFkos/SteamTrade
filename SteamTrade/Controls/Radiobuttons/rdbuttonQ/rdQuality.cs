using SteamTrade.baseSelect;
using SteamTrade.Controls.Combobox.cmbCur;
using SteamTrade.Controls.Combobox.cmbGame;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SteamTrade.Controls.Radiobuttons.rdbuttonQ
{
    internal class rdQuality
    {
        public rdQuality(List<RadioButton> rdQual)
        {
            int count = 0;
            foreach (var item in ISelectBD.quality)
            {
                rdQual[count].Content = (item);
                count++;
            }
        }
    }
}
