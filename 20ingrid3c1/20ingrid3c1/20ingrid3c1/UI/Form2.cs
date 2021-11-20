using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20ingrid3c1.Code.DTO;
using _20ingrid3c1.Code.BLL;

namespace _20ingrid3c1.UI
{
    public partial class Form2 : Form
    {
        OculosDto dto = new OculosDto();
        OculosBll bll = new OculosBll();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
           
            dto.Nome = txtnome.Text;
            dto.Cor = txtcor.Text;
            dto.Preco = double.Parse(txtpreco.Text);

            bll.Inserir(dto);

            MessageBox.Show("Cadastrado com sucesso");

            txtID.Clear();
            txtnome.Clear();
            txtcor.Clear();
            txtpreco.Clear();
            dgvlista.DataSource = bll.Listar();
        }

        private void button1_Click(object sender, EventArgs e)  //editar
        {
            dto.Id = int.Parse(txtID.Text);
            dto.Nome = txtnome.Text;
            dto.Cor = txtcor.Text;
            dto.Preco = double.Parse(txtpreco.Text);

            bll.Editar(dto);

            MessageBox.Show("Editado com sucesso");

            txtID.Clear();
            txtnome.Clear();
            txtcor.Clear();
            txtpreco.Clear();
            dgvlista.DataSource = bll.Listar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            dto.Id = int.Parse(txtID.Text);

            bll.Excluir(dto);

            MessageBox.Show("Excluido com sucesso");

            txtID.Clear();
            txtnome.Clear();
            txtcor.Clear();
            txtpreco.Clear();
            dgvlista.DataSource = bll.Listar();
        }

        private void dgvlista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvlista.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dgvlista.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcor.Text = dgvlista.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtpreco.Text = dgvlista.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
