/*
 * Created by SharpDevelop.
 * User: mrsouza
 * Date: 13/03/2014
 * Time: 12:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using MRS_utilitarios;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Analisador_de_QW
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FrmEntrada : Form
	{
        DataSet TABELAS = new DataSet();
        DataTable colunas = new DataTable();
        string[] lines = new string[0];
        
        private DataTable getDataTableOracle(string query)
        {
            ConnOracle ConexaoBanco = new ConnOracle("c_ergon", "c_ergon", "10.9.42.23:1521");
            ConexaoBanco.SetQuery(query);
            TABELAS = ConexaoBanco.ExecutaQueryGrid("tabelas");
            ConexaoBanco.FecharConexao();
            return TABELAS.Tables[0];
        }

		public FrmEntrada()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSairClick(object sender, EventArgs e)
		{
			FrmEntrada.ActiveForm.Close();
		}
		
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void TabQW51Enter(object sender, EventArgs e)
		{

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			OracleParameter numfunc = new OracleParameter();
			OracleParameter cpf = new OracleParameter();
			string oradb = "User Id=c_ergon;Password=c_ergon;" +
				           "Data Source=HOMOL11G;";
			OracleConnection conn = new OracleConnection(oradb);
			OracleCommand cmd = new OracleCommand();
			Font negrito = new Font(tbCadastro.Font, FontStyle.Bold);
			Font normal = new Font(tbCadastro.Font, FontStyle.Regular);
			Font italico = new Font(tbCadastro.Font, FontStyle.Italic);

			
			if (tbNumFunc.Text != "")
			{
				numfunc.OracleDbType = OracleDbType.Decimal;
				numfunc.Value = tbNumFunc.Text;
				cmd.Parameters.Add(numfunc);
				cmd.CommandText = "select numero, nome, to_date(dtnasc, 'dd/mm/yyyy') from funcionarios where numero = :1";
			}
			else if(tbCPF.Text != "")
			{
				cpf.OracleDbType = OracleDbType.Decimal;
				cpf.Value = tbCPF.Text;
				cmd.Parameters.Add(cpf);
				cmd.CommandText = "select numero, nome, dtnasc from funcionarios where cpf = :1";
			}
			else 
			{
				MessageBox.Show("Preencha o CPF ou o ID Funcional para realizar a consulta", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			conn.Open(); 
			cmd.Connection = conn;
			
			cmd.CommandType = CommandType.Text;
			OracleDataReader dr = cmd.ExecuteReader();
			
			if (dr.Read())
			{
				lblNome.Text = dr.GetString(1);
				tbCadastro.Text = "";
				tbCadastro.SelectionFont = negrito;	tbCadastro.AppendText("ID funcional: ");
				tbCadastro.SelectionFont = normal;	tbCadastro.AppendText(dr.GetDecimal(0).ToString());
				tbCadastro.SelectionFont = negrito; tbCadastro.AppendText("\nNome: ");
				tbCadastro.SelectionFont = normal;  tbCadastro.AppendText(dr.GetString(1));
				tbCadastro.SelectionFont = negrito;	tbCadastro.AppendText("\nData de Nascimento: ");
				tbCadastro.SelectionFont = normal;  tbCadastro.AppendText(dr.GetDateTime(2).ToString());
			}
			else
			{
				MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
		
			if (tbNumFunc.Text != "")
			{
				numfunc.OracleDbType = OracleDbType.Decimal;
				numfunc.Value = tbNumFunc.Text;
			}
			 
			// Recuperar dados dos vínculos
			cmd.Parameters.Clear();
			cmd.Parameters.Add(numfunc);
			cmd.CommandText = " select numero, nvl(to_char(dtposse, 'dd/mm/yyyy'),'--'), nvl(regimejur, '--'), nvl(tipovinc, '--'), nvl(categoria, '--'), " +
				              "nvl(matricula, '--'), nvl(banco, '0'), nvl(agencia, '0'), nvl(conta, '0'), nvl(to_char(dtvac,'dd/mm/yyyy'), '--'), " +
				              "nvl(formavac, '--')  from vinculos where numfunc = :1";
			
			cmd.CommandType = CommandType.Text;
			dr = cmd.ExecuteReader();
			
			while(dr.Read()){
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nVínculo: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetDecimal(0).ToString());
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nData da posse: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(1));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nData da vacância: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(9));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nForma da vacância: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(10));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nRegime Jurídico: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(2));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nTipo de vínculo: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(3));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nCategoria: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(4));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nMatrícula: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(5));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nBanco: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetDecimal(6).ToString());
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nAgência: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(7));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\nConta: ");
				tbVinculos.SelectionFont = normal;  tbVinculos.AppendText(dr.GetString(8));
				tbVinculos.SelectionFont = negrito; tbVinculos.AppendText("\n------------------------------------------------------------------------------");
			}
			
			conn.Dispose();
			
		}
		
		void TbCPFKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) 
			    && !char.IsDigit(e.KeyChar))
		    {
		        e.Handled = true;
		        MessageBox.Show("Digite somente números", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
		    }
		}
		
		void CarregarQW51ToolStripMenuItemClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
 		    {
				 lines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
				 foreach (string line in lines)
				 {
				 	//dataGridView1.
				 }
			}
		}
		
		void FiltrarQW54SuplementarToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form formQW = new FrmQW54Supl();
			formQW.Show();
		}
	}
}
