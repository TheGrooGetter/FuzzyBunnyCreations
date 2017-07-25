using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBCServices.Shared
{
    class Common
    {
        public static string dbId { get; } = "FBC";

        public static string dbConnectionString => $"{dbId}";


    }
}
