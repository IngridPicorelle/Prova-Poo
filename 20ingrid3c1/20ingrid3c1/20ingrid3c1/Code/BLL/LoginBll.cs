using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20ingrid3c1.Code.DTO;
using _20ingrid3c1.Code.DAL;
using System.Data;


namespace _20ingrid3c1.Code.DLL
{
    class LoginBll
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "login";

        public bool RealizarLogin(LoginDto newDto)
        {
            string sql = $"select * from {tabela} where email = '{newDto.Email}' and senha = '{newDto.Senha}';";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
