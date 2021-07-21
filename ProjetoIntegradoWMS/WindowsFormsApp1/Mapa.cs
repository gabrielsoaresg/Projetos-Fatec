using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;

namespace ProjetoIntegradoArmazem
{
    public partial class frmMapa : Form
    {
        public frmMapa()
        {
            InitializeComponent();
            List<TextBox> txtList = new List<TextBox>();
            List<string> setList = new List<string>();

            txtList.Add(txtNome_do_Produto);
            txtList.Add(txtCodigo_do_Produto);
            txtList.Add(txtEAN);

            setList.Add("Ex. Papel Higiênico");
            setList.Add("Ex. 03457899 - 8");
            setList.Add("Ex. 5901234123457");
            SetCueBanner(ref txtList, setList);

        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr i, string str);
        void SetCueBanner(ref List<TextBox> txts, List<string> description)
        {
            for (int i = 0; i < txts.Count; i++)
            {
                SendMessage(txts[i].Handle, 0x1501, (IntPtr)1, description[i]);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frminterfaceWMS_Armazem frm = new frminterfaceWMS_Armazem();
            frm.Show();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataeHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }
        private void txtNome_do_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas letras", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtCodigo_do_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtEAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void opcaoSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Operação cancelada", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void opcaoPreferencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void opcaoVerMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua matrícula é 00000000", "Matrícula de funcionário", MessageBoxButtons.OK);
        }
        private void opcaoPermissoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void opcaoSuporte_Click(object sender, EventArgs e)
        {            
            this.Hide();
            frmSuporteAoUsuario f2 = new frmSuporteAoUsuario("MapForms");
            f2.Show();
        }
        private void frmMapa_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}

