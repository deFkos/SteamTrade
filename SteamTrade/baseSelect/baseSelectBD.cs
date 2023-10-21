using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SteamTrade.baseSelect
{
    internal class baseSelectBD
    {
        public baseSelectBD()
        {
            dataSelectBD dataSelectBD = new dataSelectBD();
            foreach (var i in ISelectBD.listList)
            {
                if (ISelectBD.listList[0] == i)
                {
                    ISelectBD.quality = i;
                }
                if (ISelectBD.listList[1] == i)
                {
                    ISelectBD.weapon = i;
                }
                if (ISelectBD.listList[2] == i)
                {
                    ISelectBD.currency = i;
                }
                if (ISelectBD.listList[3] == i)
                {
                    ISelectBD.gameid = i;
                }
            }
        }
    }
}
