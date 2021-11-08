using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto3camadas.Code.BLL;
using Projeto3camadas.Code.DTO;

namespace Projeto3camadas.Ui

{
    public partial class Frm_Medicamentos : Form
    {

        MedicamentoBLL medbll = new MedicamentoBLL();
        MedicamentoDTO meddto = new MedicamentoDTO();

        public Frm_Medicamentos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            meddto.Medicamento = txtMedicamento.Text;
            meddto.Composicao = txtComposicao.Text;

            medbll.Inserir(meddto);
        }
    }
}
