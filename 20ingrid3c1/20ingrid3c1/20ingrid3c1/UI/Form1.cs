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
using _20ingrid3c1.Code.DLL; //Bll

namespace _20ingrid3c1
{
    public partial class Form1 : Form
    {
        LoginDto dto = new LoginDto();
        LoginBll bll = new LoginBll();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            dto.Email = txtemail.Text;
            dto.Senha = txtsenha.Text;

            if (bll.RealizarLogin(dto) == true)
            {
                UI.Form2 formulario = new UI.Form2();
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos");
            }
        }
    }
}
