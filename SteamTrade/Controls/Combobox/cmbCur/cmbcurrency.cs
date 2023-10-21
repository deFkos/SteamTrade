using SteamTrade.baseSelect;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SteamTrade.Controls.Combobox.cmbCur
{
    internal class cmbcurrency
    {
        public cmbcurrency(ComboBox cmbCurrency)
        {

            foreach (var item in ISelectBD.currency)
            {
                cmbCurrency.Items.Add(item);
            }
        }
    }
}
