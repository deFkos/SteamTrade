using SteamTrade.Controls.Combobox.cmbCur;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SteamTrade.baseSelect.ISelectBD;

namespace SteamTrade.baseSelect
{
    internal class dataSelectBD : ISelectBD
    {
        List<string> querys = new List<string>()
        {
           queryQuality,queryWeapon,queryCurrency,queryGameid
        };
        public dataSelectBD()
        {
            int count = 0;
            foreach (var query in querys)
            {
                listList.Add(new List<string>());
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    foreach (List<string> i in listList)
                    {
                        if (i == listList[count])
                        {
                            i.Add(reader[0].ToString());
                        }
                    }
                }
                count++;
                reader.Close();
                connection.Close();
            }
        }
    }
}
