using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradoArmazem
{
    public partial class frmSuporteAoUsuario : Form
    {
        public string verForms;
        public frmSuporteAoUsuario(string verif)
        {
            InitializeComponent();
            verForms = verif;
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataeHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sup = Application.StartupPath + @"\Arquivo\Suporte.txt";
            Process.Start(sup);
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (verForms == "MainForms")
            {
                frminterfaceWMS_Armazem f = new frminterfaceWMS_Armazem();
                f.Show();
            }
            else if(verForms == "MapForms")
            {
                frmMapa f = new frmMapa();
                f.Show();
            }
        }
        private void optionSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Operação cancelada", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void optionPreferencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void optionVerMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua matrícula é 00000000", "Matrícula de funcionário", MessageBoxButtons.OK);
        }
        private void optionPermissoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmSuporteAoUsuario_FormClosing(object sender, FormClosingEventArgs e)
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
