using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;

namespace ProjetoIntegradoArmazem
{
    public partial class frminterfaceWMS_Armazem : Form
    {
        //Marca d'água (Cuebanner)
        public frminterfaceWMS_Armazem()
        {
            InitializeComponent();
            Disable();
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();

            tList.Add(txtNome_Prod);
            tList.Add(txtCodigo_Prod);
            tList.Add(txtCodigo_Ean);
            tList.Add(txtFornecedor);
            tList.Add(txtQuantidade);
            tList.Add(txtLote);
            tList.Add(txtStatus);
            tList.Add(txtArea_Prod);
            tList.Add(txtAltura_Prod);
            tList.Add(txtLargura_Prod);
            tList.Add(txtComprimento_Prod);
            tList.Add(txtVolume_Prod);
            tList.Add(txtPeso_Prod);
            tList.Add(txtCorredor);
            tList.Add(txtVao);
            tList.Add(txtModulo);
            tList.Add(txtNivel);
            tList.Add(txtEndereco_Prod);
            tList.Add(txtConsulta_Prod);
            tList.Add(txtID_Endereco);

            sList.Add("Ex. Papel Higiênico");
            sList.Add("Ex. 03457899-8");
            sList.Add("Ex. 5901234123457");
            sList.Add("Ex. 1345678");
            sList.Add("Ex. 12 caixas");
            sList.Add("Ex. CM91384811Z4");
            sList.Add("Ex. Ativo/Inativo");
            sList.Add("Ex. 01");
            sList.Add("Ex. 10cm");
            sList.Add("Ex. 13cm");
            sList.Add("Ex. 11cm");
            sList.Add("Ex. 4cm³");
            sList.Add("Ex. 20kg");
            sList.Add("Ex. 02");
            sList.Add("Ex. 03");
            sList.Add("Ex. 04");
            sList.Add("Ex. 05");
            sList.Add("Ex. 12345");
            sList.Add(" 🔍");
            sList.Add("Ex. 3467812");
            SetCueBanner(ref tList, sList);
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
        string caminho = Application.StartupPath + @"\BD\BDP2-WMSV2.mdb";

        //Alguns métodos
        public void Disable()
        {
            txtNome_Prod.Enabled = false;
            txtCodigo_Prod.Enabled = false;
            txtCodigo_Ean.Enabled = false;
            txtFornecedor.Enabled = false;
            txtQuantidade.Enabled = false;
            txtLote.Enabled = false;
            txtStatus.Enabled = false;
            txtArea_Prod.Enabled = false;
            txtAltura_Prod.Enabled = false;
            txtLargura_Prod.Enabled = false;
            txtComprimento_Prod.Enabled = false;
            txtVolume_Prod.Enabled = false;
            txtPeso_Prod.Enabled = false;
            txtCorredor.Enabled = false;
            txtVao.Enabled = false;
            txtModulo.Enabled = false;
            txtNivel.Enabled = false;
            txtEndereco_Prod.Enabled = false;
            txtID_Endereco.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
        }
        public void Enable()
        {
            txtNome_Prod.Enabled = true;
            txtCodigo_Prod.Enabled = true;
            txtCodigo_Ean.Enabled = true;
            txtFornecedor.Enabled = true;
            txtQuantidade.Enabled = true;
            txtLote.Enabled = true;
            txtStatus.Enabled = true;
            txtArea_Prod.Enabled = true;
            txtAltura_Prod.Enabled = true;
            txtLargura_Prod.Enabled = true;
            txtComprimento_Prod.Enabled = true;
            txtVolume_Prod.Enabled = true;
            txtPeso_Prod.Enabled = true;
            txtCorredor.Enabled = true;
            txtVao.Enabled = true;
            txtModulo.Enabled = true;
            txtNivel.Enabled = true;
            txtEndereco_Prod.Enabled = true;
            txtID_Endereco.Enabled = true;
            btnSalvar.Enabled = true;
        }
        public void ClearAll()
        {
            txtNome_Prod.Clear();
            txtCodigo_Prod.Clear();
            txtCodigo_Ean.Clear();
            txtFornecedor.Clear();
            txtQuantidade.Clear();
            txtLote.Clear();
            txtStatus.Clear();
            txtArea_Prod.Clear();
            txtAltura_Prod.Clear();
            txtLargura_Prod.Clear();
            txtComprimento_Prod.Clear();
            txtVolume_Prod.Clear();
            txtPeso_Prod.Clear();
            txtCorredor.Clear();
            txtVao.Clear();
            txtModulo.Clear();
            txtNivel.Clear();
            txtEndereco_Prod.Clear();
            txtConsulta_Prod.Clear();
            txtID_Endereco.Clear();
        }

        //Código começa aqui
        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataeHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }
        private void btnAdicionarNovo_Click(object sender, EventArgs e)
        {
            Enable();
            txtID_Endereco.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID_Endereco.Text != "" && txtNome_Prod.Text != "" && txtCodigo_Prod.Text != "" && txtCodigo_Ean.Text != "" && txtArea_Prod.Text != "" && txtCorredor.Text != "" && txtModulo.Text != "" && txtNivel.Text != "" && txtVao.Text != "" && txtEndereco_Prod.Text != "" && txtPeso_Prod.Text != "" && txtAltura_Prod.Text != "" && txtLargura_Prod.Text != "" && txtComprimento_Prod.Text != "" && txtVolume_Prod.Text != "" && txtStatus.Text != "" && txtFornecedor.Text != "" && txtQuantidade.Text != "" && txtLote.Text != "")
                {
                    string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                    OleDbConnection connec = new OleDbConnection(StrConnec);
                    connec.Open();

                    string nome_produto = txtNome_Prod.Text;
                    string Codigo_produto = txtCodigo_Prod.Text;
                    string CodigoEan = txtCodigo_Ean.Text;
                    string area = txtArea_Prod.Text;
                    string corredor = txtCorredor.Text;
                    string modulo = txtModulo.Text;
                    string nivel = txtNivel.Text;
                    string vao = txtVao.Text;
                    string Endereco_produto = txtEndereco_Prod.Text;
                    string PesoBruto = txtPeso_Prod.Text;
                    string altura_produto = txtAltura_Prod.Text;
                    string largura_produto = txtLargura_Prod.Text;
                    string comprimento_produto = txtComprimento_Prod.Text;
                    string volume_produto = txtVolume_Prod.Text;
                    string status_produto = txtStatus.Text;
                    string ID_fornecedor = txtFornecedor.Text;
                    string quantidade = txtQuantidade.Text;
                    string lote = txtLote.Text;

                    string cons = "UPDATE Armazenagem SET nome_produto = '" + nome_produto +
                                            "', Codigo_produto  = '" + Codigo_produto +
                                            "', CodigoEan = '" + CodigoEan +
                                            "', area = '" + area +
                                            "', corredor = '" + corredor +
                                            "', modulo = '" + modulo +
                                            "', nivel = '" + nivel +
                                            "', vao = '" + vao +
                                            "', Endereco_produto = '" + Endereco_produto +
                                            "', PesoBruto = '" + PesoBruto +
                                            "', altura_produto = '" + altura_produto +
                                            "', largura_produto ='" + largura_produto +
                                            "', comprimento_produto = '" + comprimento_produto +
                                            "', volume_produto = '" + volume_produto +
                                            "', status_produto = '" + status_produto +
                                            "', ID_fornecedor = '" + ID_fornecedor +
                                            "', quantidade = '" + quantidade +
                                            "', lote = '" + lote +
                                            "+' WHERE ID_Endereco = '" + txtConsulta_Prod.Text + "'";

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connec;
                    cmd.CommandText = cons;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados alterados com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();

                    connec.Close();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                try
                {
                    string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                    OleDbConnection con = new OleDbConnection(StrConnec);
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT * FROM Armazenagem";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    //adaptar dados pro DatatGrid 
                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable dados = new DataTable();
                    adapter.Fill(dados);
                    grdArmazem.DataSource = dados;
                    con.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID_Endereco.Text != "")
                {
                    var result = MessageBox.Show("Tem certeza que deseja excluir todos os dados?", "FAWS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                        OleDbConnection connec = new OleDbConnection(StrConnec);
                        connec.Open();

                        String SQL;
                        SQL = "DELETE * FROM Armazenagem WHERE ID_endereco = '" + txtID_Endereco.Text + "'";
                        OleDbCommand cmd = new OleDbCommand(SQL, connec);
                        cmd.CommandText = SQL;
                        cmd.ExecuteNonQuery();

                        ClearAll();

                        connec.Close();

                        MessageBox.Show("Dados excluídos com sucesso", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("O campo ID do endereço precisa ser preenchido");
                    }
                    try
                    {
                        string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                        OleDbConnection con = new OleDbConnection(StrConnec);
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandText = "SELECT * FROM Armazenagem";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        //adaptar dados pro DatatGrid 
                        OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                        DataTable dados = new DataTable();
                        adapter.Fill(dados);
                        grdArmazem.DataSource = dados;
                        con.Close();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtConsulta_Prod.Text != "")
                {
                    string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                    OleDbConnection connec = new OleDbConnection(StrConnec);


                    string consulta = "SELECT * FROM Armazenagem";
                    if (txtConsulta_Prod.Text != "")
                        consulta = "SELECT * FROM Armazenagem WHERE ID_endereco LIKE '" + txtConsulta_Prod.Text + "'";

                    DataTable dt = new DataTable();

                    OleDbDataAdapter adpt = new OleDbDataAdapter(consulta, connec);

                    connec.Open();

                    adpt.Fill(dt);

                    txtID_Endereco.Text = (string)dt.Rows[0][0].ToString();
                    txtNome_Prod.Text = (string)dt.Rows[0][1];
                    txtCodigo_Prod.Text = (string)dt.Rows[0][2];
                    txtCodigo_Ean.Text = (string)dt.Rows[0][3];
                    txtArea_Prod.Text = (string)dt.Rows[0][4];
                    txtCorredor.Text = (string)dt.Rows[0][5];
                    txtModulo.Text = (string)dt.Rows[0][6];
                    txtNivel.Text = (string)dt.Rows[0][7];
                    txtVao.Text = (string)dt.Rows[0][8];
                    txtEndereco_Prod.Text = (string)dt.Rows[0][9];
                    txtPeso_Prod.Text = (string)dt.Rows[0][10].ToString();
                    txtAltura_Prod.Text = (string)dt.Rows[0][11].ToString();
                    txtLargura_Prod.Text = (string)dt.Rows[0][12].ToString();
                    txtComprimento_Prod.Text = (string)dt.Rows[0][13].ToString();
                    txtVolume_Prod.Text = (string)dt.Rows[0][14].ToString();
                    txtStatus.Text = (string)dt.Rows[0][15];
                    txtFornecedor.Text = (string)dt.Rows[0][16];
                    txtQuantidade.Text = (string)dt.Rows[0][17].ToString();
                    txtLote.Text = (string)dt.Rows[0][18];

                    connec.Close();
                }
                else
                {
                    MessageBox.Show("O campo de consulta precisa ser preenchido corretamente", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Produto inexistente, verifique se o código foi digitado corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja limpar os campos?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == resposta)
            {
                ClearAll();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (txtID_Endereco.Text != "" && txtNome_Prod.Text != "" && txtCodigo_Prod.Text != "" && txtCodigo_Ean.Text != "" && txtArea_Prod.Text != "" && txtCorredor.Text != "" && txtModulo.Text != "" && txtNivel.Text != "" && txtVao.Text != "" && txtEndereco_Prod.Text != "" && txtPeso_Prod.Text != "" && txtAltura_Prod.Text != "" && txtLargura_Prod.Text != "" && txtComprimento_Prod.Text != "" && txtVolume_Prod.Text != "" && txtStatus.Text != "" && txtFornecedor.Text != "" && txtQuantidade.Text != "" && txtLote.Text != "")
                {
                    string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                    OleDbConnection connec = new OleDbConnection(StrConnec);
                    connec.Open();
                    String SQL;
                    SQL = "Insert Into Armazenagem (ID_endereco, nome_produto, Codigo_produto, CodigoEan, area, corredor, modulo, nivel, vao, Endereco_produto, PesoBruto, altura_produto, largura_produto, comprimento_produto, volume_produto, status_produto, ID_fornecedor, quantidade, lote) Values";
                    SQL += "('" + txtID_Endereco.Text + "','" + txtNome_Prod.Text + "','" + txtCodigo_Prod.Text + "','" + txtCodigo_Ean.Text + "','" + txtArea_Prod.Text + "','" + txtCorredor.Text + "','" + txtModulo.Text + "','" + txtNivel.Text + "','" + txtVao.Text + "','" + txtEndereco_Prod.Text + "','" + txtPeso_Prod.Text + "','" + txtAltura_Prod.Text + "','" + txtLargura_Prod.Text + "','" + txtComprimento_Prod.Text + "','" + txtVolume_Prod.Text + "','" + txtStatus.Text.ToUpper() + "','" + txtFornecedor.Text + "','" + txtQuantidade.Text + "','" + txtLote.Text + "')";

                    OleDbCommand cmd = new OleDbCommand(SQL, connec);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados gravados com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ClearAll();

                    connec.Close();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                OleDbConnection con = new OleDbConnection(StrConnec);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Armazenagem";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                //adaptar dados pro DatatGrid 
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dados = new DataTable();
                adapter.Fill(dados);
                grdArmazem.DataSource = dados;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVisualizarMapa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMapa fMapa = new frmMapa();
            fMapa.Show();
        }
        private void btnBalancoInventario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRelatorioMensal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void optionSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void optionSuporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSuporteAoUsuario f2 = new frmSuporteAoUsuario("MainForms");
            f2.Show();
        }

        private void btnMostrarDados_Click(object sender, EventArgs e)
        {
            try
            {
                string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                OleDbConnection con = new OleDbConnection(StrConnec);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Armazenagem";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                //adaptar dados pro DatatGrid 
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dados = new DataTable();
                adapter.Fill(dados);
                grdArmazem.DataSource = dados;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_Endereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodigo_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodigo_Ean_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAltura_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLargura_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtComprimento_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtVolume_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPeso_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtArea_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtVao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtEndereco_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNome_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas letras", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente letras e números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas letras", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtConsulta_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void grdArmazem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdArmazem.CurrentCell.ColumnIndex == 0)
            {
                txtID_Endereco.Text = Convert.ToString(grdArmazem.CurrentCell.Value);
            }
            try
            {
                string StrConnec = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + caminho;
                OleDbConnection connec = new OleDbConnection(StrConnec);


                string consulta = "SELECT * FROM Armazenagem";
                consulta = "SELECT * FROM Armazenagem WHERE ID_endereco LIKE '" + txtID_Endereco.Text + "'";

                DataTable dt = new DataTable();

                OleDbDataAdapter adpt = new OleDbDataAdapter(consulta, connec);

                connec.Open();

                adpt.Fill(dt);

                txtID_Endereco.Text = (string)dt.Rows[0][0].ToString();
                txtNome_Prod.Text = (string)dt.Rows[0][1];
                txtCodigo_Prod.Text = (string)dt.Rows[0][2];
                txtCodigo_Ean.Text = (string)dt.Rows[0][3];
                txtArea_Prod.Text = (string)dt.Rows[0][4];
                txtCorredor.Text = (string)dt.Rows[0][5];
                txtModulo.Text = (string)dt.Rows[0][6];
                txtNivel.Text = (string)dt.Rows[0][7];
                txtVao.Text = (string)dt.Rows[0][8];
                txtEndereco_Prod.Text = (string)dt.Rows[0][9];
                txtPeso_Prod.Text = (string)dt.Rows[0][10].ToString();
                txtAltura_Prod.Text = (string)dt.Rows[0][11].ToString();
                txtLargura_Prod.Text = (string)dt.Rows[0][12].ToString();
                txtComprimento_Prod.Text = (string)dt.Rows[0][13].ToString();
                txtVolume_Prod.Text = (string)dt.Rows[0][14].ToString();
                txtStatus.Text = (string)dt.Rows[0][15];
                txtFornecedor.Text = (string)dt.Rows[0][16];
                txtQuantidade.Text = (string)dt.Rows[0][17].ToString();
                txtLote.Text = (string)dt.Rows[0][18];

                connec.Close();
            }
            catch(Exception erro)
            {
                    MessageBox.Show(erro.Message, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
        private void frminterfaceWMS_Armazem_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}  

