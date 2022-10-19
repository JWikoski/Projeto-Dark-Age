using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dark_Age.Enteties
{
    public static class Conexao_BD
    {
        public static string Caminho_DB()
        {
            return "Server=db.lrtxyttihecehnpzgeus.supabase.co;Port=5432;Database=postgres;user Id=postgres;Password=ProjetoDark@ge123";
        }

    }
}
