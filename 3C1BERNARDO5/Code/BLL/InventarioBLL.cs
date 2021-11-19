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
    class InventarioBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "inventario";


        public void Inserir(InventarioDTO invdto)
        {
            string inserir = $"insert into {tabela} values (null, '{invdto.Produto}','{invdto.Quantidade}')";
            conexao.ExecutarComando(inserir);
        }
        public void Editar(InventarioDTO invdto)
        {
            string alterar = $"update {tabela} set produto = '{invdto.Produto}', quantidade = '{invdto.Quantidade}' where id = '{invdto.Id}';";
            conexao.ExecutarComando(alterar);
        }
        public void Excluir(InventarioDTO invdto)
        {
            string excluir = $"delete from {tabela} where id = '{invdto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
