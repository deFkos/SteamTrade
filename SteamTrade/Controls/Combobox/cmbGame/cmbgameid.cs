using SteamTrade.baseSelect;
using SteamTrade.Controls.Combobox.cmbCur;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SteamTrade.Controls.Combobox.cmbGame
{
    internal class cmbgameid
    {
        public cmbgameid(ComboBox cmbgameid) 
        {
            foreach (var item in ISelectBD.gameid)
            {
                cmbgameid.Items.Add(item);
            }
        }
    }
}
