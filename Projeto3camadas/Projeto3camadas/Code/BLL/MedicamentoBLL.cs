using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto3camadas.Code.DTO;
using Projeto3camadas.Code.DAL;


namespace Projeto3camadas.Code.BLL
{
    class MedicamentoBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_medicamento";



        public void Inserir(MedicamentoDTO meddto)
        {
            string inserir = $"insert into {tabela} values(null, '{meddto.Medicamento}','{meddto.Composicao}')";
            conexao.ExecutarComando(inserir);
        }
        public void Editar(MedicamentoDTO meddto)
        {
        }
        public void Listar()
        {
        }
    }
}
