using ProjFinanceiro.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjFinanceiro.Models
{
    public class UsuarioModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage  = "Preencha o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o Email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha a Senha!")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Preencha a Data!")]
        public string DataNasc { get; set; }

        public bool ValidarLogin()
        {
            string sql = $"select ID, NOME,  DATA_NASCIMENTO FROM USUARIO EMAIL='{Email}' AND SENHA='{Senha}'";
            Dal objDal = new Dal();
            DataTable dt = objDal.RetDataTable(sql);
            if (dt != null) {
                if (dt.Rows.Count == 1) {
                    ID = int.Parse(dt.Rows[0]["ID"].ToString());
                    Nome = dt.Rows[1]["NOME"].ToString();
                    DataNasc = dt.Rows[2]["DATA_NASCIMENTO"].ToString();
                    return true;
                }
            }
            return false;
        }
        public void RegistrarUsuario(){

            string sql = $"insert into USUARIO(NOME, EMAIL, SENHA, DATA_NASCIMENTO) VALUES " +
                $"('{Nome}', '{Email}', '{Senha}','{DataNasc}')";
            string DataNa = DateTime.Parse(DataNasc).ToString("yyyy/mm/dd");
            Dal objDal = new Dal();
            objDal.executaSql(sql);
        }
    }
}
