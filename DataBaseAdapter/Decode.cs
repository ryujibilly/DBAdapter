using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAdapter
{
    public class Decode
    {
        private SqlConnection SqlCon { get; set; }
        public Decode(SqlConnection sc)
        {
            this.SqlCon = sc;
        }
        public WITSData Convert(String[] data)
        {
            WITSData witsData=new WITSData();
            return witsData;
        }
    }
}
