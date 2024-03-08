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
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Database=sport;Username=YonisJr;Password=0907;Port=5432");

    }
}
