using Microsoft.AspNetCore.Http;
using ProjFinanceiro.util;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjFinanceiro.Models
{
    public class ContaModel
    {
        public int Id {get; set;}
        [Required]
        public string Nome { get; set; }
        [Required]
        public double Saldo { get; set; }
        
        public int usuario_id { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }


        public ContaModel() {

        }

        public ContaModel(IHttpContextAccessor httpContextAccessor) {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<ContaModel> ListaConta()
        {
            List<ContaModel> lista = new List<ContaModel>();
            ContaModel item;
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"SELECT ID, NOME, SALDO, USUARIO_ID FROM CONTA WHERE USUARIO_ID = {id_usuario_logado}";
            Dal objDal = new Dal();
            DataTable dt = objDal.RetDataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ContaModel();
                item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
                item.Nome = dt.Rows[i]["NOME"].ToString();
                item.Saldo = Double.Parse(dt.Rows[i]["SALDO"].ToString());
                item.usuario_id = int.Parse(dt.Rows[i]["USUARIO_ID"].ToString());
                lista.Add(item);

            }
            return lista;
        }
        public void Insert() {

            string id_usuario_logado =  HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO CONTA(NOME, SALDO, USUARIO_ID) VALUES('{Nome}','{Saldo}','{id_usuario_logado}')";
            Dal objDal = new Dal();
            objDal.executaSql(sql);
        }

        public void ExcluirConta(int id) {
            string sql = $"DELETE FROM CONTA where id="+ id;
            Dal objDal = new Dal();
            objDal.executaSql(sql);
        }
    }
}
