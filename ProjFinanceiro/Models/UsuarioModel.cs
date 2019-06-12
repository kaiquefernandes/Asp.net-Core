using ProjFinanceiro.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjFinanceiro.Models
{
    public class UsuarioModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNasc { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"select ID, NOME,  DATA_NASCIMENTO FROM USUARIO EMAIL='{Email}' AND SENHA='{Senha}'";
            Dal objDal = new Dal();
            DataTable dt = objDal.RetDataTable(sql);
            if (dt != null) {
                if (dt.Rows.Count == 1) {
                    ID = int.Parse(dt.Rows[0]["ID"].ToString());
                    Nome = dt.Rows[1]["NOME"].ToString();
                    DataNasc = DateTime.Parse(dt.Rows[2]["DATA_NASCIMENTO"].ToString());
                    return true;
                }
            }
            return false;
        }
    }
}
