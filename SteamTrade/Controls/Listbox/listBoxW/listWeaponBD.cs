using SteamTrade.baseSelect;
using SteamTrade.Controls.Combobox.cmbGame;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SteamTrade.Controls.Listbox.listBoxW
{
    class listWeaponBD
    {
        public listWeaponBD(ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            int count = 0;
            foreach (var item in ISelectBD.weapon)
            {
                if (count > 22)
                {
                    listBox3.Items.Add(item);
                }
                if (count > 11 && count <= 22)
                {
                    listBox2.Items.Add(item);
                }
                if (count < 11)
                {
                    listBox1.Items.Add(item);
                }
                count++;
            }
        }
    }
}
