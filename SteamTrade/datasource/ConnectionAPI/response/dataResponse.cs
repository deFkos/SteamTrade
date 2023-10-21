using SteamTrade.baseSelect;
using SteamTrade.Controls.Combobox.cmbCur;
using SteamTrade.Controls.Listbox.listBoxW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.WebRequestMethods;

namespace SteamTrade.datasource.ConnectionAPI.response
{
    internal class dataResponse
    {
        public string data(ComboBox cmbCurrency, ComboBox gameid, RadioButton quality)
        {

            string? weaponName = Iresponse.skin;

            string qualit = quality.Content.ToString().Replace(" ", "%20");
            string response = $"http://steamcommunity.com/market/priceoverview/?appid=730&currency={cmbCurrency.SelectedIndex + 1}&market_hash_name={IselectedW.gunName}%20%7C%20{weaponName}%20%28{qualit}%29";
            return response;
        }
    }
}
