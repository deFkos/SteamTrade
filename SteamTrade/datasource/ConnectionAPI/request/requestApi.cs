using Newtonsoft.Json.Linq;
using SteamTrade.baseSelect;
using SteamTrade.Controls.Listbox.listBoxW;
using SteamTrade.datasource.ConnectionAPI;
using SteamTrade.datasource.ConnectionAPI.response;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace SteamTrade.datasource.ConnectionAPI.request
{
    class requestApi : IselectedW
    {
        public requestApi(ComboBox cmbCurrency, ComboBox gameid, RadioButton quality)
        {
            Iresponse.Price = null;
            dataResponse data = new dataResponse();
            var request = new ConnectionApi(data.data(cmbCurrency, gameid, quality));
            request.Run();
            var response = request.Response;
            var json = response != null ? JObject.Parse(response) : null;
            var lowPrice = json != null ? json : null;
            Iresponse.Price = lowPrice != null ? lowPrice.ToString() : null;
        }
    }
}
