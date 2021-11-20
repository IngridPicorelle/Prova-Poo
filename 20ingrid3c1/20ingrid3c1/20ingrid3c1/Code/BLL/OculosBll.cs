using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20ingrid3c1.Code.DTO;
using _20ingrid3c1.Code.DAL;
using System.Data;

namespace _20ingrid3c1.Code.BLL
{
    class OculosBll
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "oculos";
        public void Inserir(OculosDto newDto)
        {
            string inserir = $"insert into {tabela} values('null', '{newDto.Nome}', '{newDto.Cor}', '{newDto.Preco}');";
            conexao.ExecutarComando(inserir);
        }
        public void Editar(OculosDto newDto)
        {
            string editar = $"update {tabela} set nome = '{newDto.Nome}', cor = '{newDto.Cor}', preco = '{newDto.Preco}' where id = '{newDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(OculosDto newDto)
        {
            string excluir = $"delete from {tabela} where id = '{newDto.Id}';";
            conexao.ExecutarConsulta(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    } 
}   



