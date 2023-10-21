using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SteamTrade.Controls.Listbox.listBoxW
{
    internal class SelectedWeapon
    {
        public SelectedWeapon(ListBox listWeapon1, ListBox listWeapon2, ListBox listWeapon3)
        {
            List<ListBox> listSelected = new List<ListBox>()
            {
                listWeapon1,listWeapon2,listWeapon3
            };
            foreach (ListBox listWeapon in listSelected )
            {
                if(listWeapon.SelectedItem != null)
                {
                    IselectedW.gunName = listWeapon.SelectedItem.ToString();
                }
            }
            listWeapon1.SelectionChanged += (sender, args) =>
            {
                if (listWeapon1.SelectedItem != null)
                {
                    listWeapon2.SelectedItem = null;
                    listWeapon3.SelectedItem = null;
                }
            };
            listWeapon2.SelectionChanged += (sender, args) =>
            {
                if (listWeapon2.SelectedItem != null)
                {
                    listWeapon1.SelectedItem = null;
                    listWeapon3.SelectedItem = null;
                }
            };
            listWeapon3.SelectionChanged += (sender, args) =>
            {
                if (listWeapon3.SelectedItem != null)
                {
                    listWeapon1.SelectedItem = null;
                    listWeapon2.SelectedItem = null;
                }
            };
        }
    }
}
