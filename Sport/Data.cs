using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Sport
{
    internal class Data
    {
        NpgsqlConnection conn = new NpgsqlConnection("port = 3456 , database = sport; pawword = 0907, host = localhost");

    }
}
