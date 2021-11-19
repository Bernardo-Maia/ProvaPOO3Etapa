using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1BERNARDO5.Code.DTO;
using _3C1BERNARDO5.Code.DAL;
using System.Data;

namespace _3C1BERNARDO5.Code.BLL
{
    class loginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "login";
        public bool RealizarLogin(loginDTO login) 
        {
            string sql = $"select * from {tabela} where email = '{login.Email}' and senha = '{login.Senha}';";
            DataTable dt = conexao.ExecutarConsulta(sql);
            if (dt.Rows.Count > 0) return true;
            else return false;
        
        }
    }
}
