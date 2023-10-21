using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamTrade.baseSelect
{
    internal interface ISelectBD
    {
        internal static SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True");
        internal static string queryQuality = "SELECT quality FROM qualityBD";
        internal static string queryWeapon = "SELECT weaponName FROM weaponBD";
        internal static string queryCurrency = "SELECT currency FROM currencyBD";
        internal static string queryGameid = "SELECT * FROM gameidBD";
        internal static List<List<string>> listList = new List<List<string>>();
        internal static List<string> quality = new List<string>();
        internal static List<string> weapon = new List<string>();
        internal static List<string> currency = new List<string>();
        internal static List<string> gameid = new List<string>();
    }
}
