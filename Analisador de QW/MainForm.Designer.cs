using System.Windows.Forms;
/*
 * Created by SharpDevelop.
 * User: mrsouza
 * Date: 13/03/2014
 * Time: 12:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Analisador_de_QW
{
	partial class FrmEntrada
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrada));
			this.btnSair = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblNumFunc = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbNumFunc = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbCPF = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.carregarQW51ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabCadastro = new System.Windows.Forms.TabPage();
			this.tbCadastro = new System.Windows.Forms.RichTextBox();
			this.tabEmprestimos = new System.Windows.Forms.TabPage();
			this.tbVinculos = new System.Windows.Forms.RichTextBox();
			this.tabQW51 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.StaQW50 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.stQW51 = new System.Windows.Forms.ToolStripStatusLabel();
			this.filtrarQW54SuplementarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabCadastro.SuspendLayout();
			this.tabEmprestimos.SuspendLayout();
			this.tabQW51.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(906, 3);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 0;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblNumFunc);
			this.panel1.Controls.Add(this.lblNome);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.tbNumFunc);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbCPF);
			this.panel1.Controls.Add(this.btnSair);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1008, 76);
			this.panel1.TabIndex = 1;
			// 
			// lblNumFunc
			// 
			this.lblNumFunc.Location = new System.Drawing.Point(266, 38);
			this.lblNumFunc.Name = "lblNumFunc";
			this.lblNumFunc.Size = new System.Drawing.Size(110, 23);
			this.lblNumFunc.TabIndex = 9;
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(266, 6);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(210, 23);
			this.lblNome.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "ID Funcional";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbNumFunc
			// 
			this.tbNumFunc.Location = new System.Drawing.Point(82, 25);
			this.tbNumFunc.MaxLength = 15;
			this.tbNumFunc.Name = "tbNumFunc";
			this.tbNumFunc.Size = new System.Drawing.Size(136, 20);
			this.tbNumFunc.TabIndex = 6;
			this.tbNumFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCPFKeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Pesquisar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "CPF:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbCPF
			// 
			this.tbCPF.Location = new System.Drawing.Point(82, 3);
			this.tbCPF.MaxLength = 11;
			this.tbCPF.Name = "tbCPF";
			this.tbCPF.Size = new System.Drawing.Size(155, 20);
			this.tbCPF.TabIndex = 3;
			this.tbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbCPFKeyPress);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.carregarQW51ToolStripMenuItem,
									this.filtrarQW54SuplementarToolStripMenuItem,
									this.toolStripSeparator1,
									this.mnuConfig,
									this.toolStripSeparator2,
									this.mnuSair});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.fileToolStripMenuItem.Text = "&Arquivo";
			// 
			// carregarQW51ToolStripMenuItem
			// 
			this.carregarQW51ToolStripMenuItem.Name = "carregarQW51ToolStripMenuItem";
			this.carregarQW51ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.carregarQW51ToolStripMenuItem.Text = "Carregar QW51...";
			this.carregarQW51ToolStripMenuItem.Click += new System.EventHandler(this.CarregarQW51ToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
			// 
			// mnuConfig
			// 
			this.mnuConfig.Name = "mnuConfig";
			this.mnuConfig.Size = new System.Drawing.Size(209, 22);
			this.mnuConfig.Text = "Configurações";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
			// 
			// mnuSair
			// 
			this.mnuSair.Name = "mnuSair";
			this.mnuSair.Size = new System.Drawing.Size(209, 22);
			this.mnuSair.Text = "&Sair";
			this.mnuSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabCadastro);
			this.tabControl1.Controls.Add(this.tabEmprestimos);
			this.tabControl1.Controls.Add(this.tabQW51);
			this.tabControl1.Location = new System.Drawing.Point(4, 106);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1004, 553);
			this.tabControl1.TabIndex = 3;
			// 
			// tabCadastro
			// 
			this.tabCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tabCadastro.Controls.Add(this.tbCadastro);
			this.tabCadastro.Location = new System.Drawing.Point(4, 22);
			this.tabCadastro.Name = "tabCadastro";
			this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
			this.tabCadastro.Size = new System.Drawing.Size(996, 527);
			this.tabCadastro.TabIndex = 0;
			this.tabCadastro.Text = "Cadastro";
			this.tabCadastro.UseVisualStyleBackColor = true;
			// 
			// tbCadastro
			// 
			this.tbCadastro.Location = new System.Drawing.Point(2, 2);
			this.tbCadastro.Name = "tbCadastro";
			this.tbCadastro.Size = new System.Drawing.Size(990, 517);
			this.tbCadastro.TabIndex = 0;
			this.tbCadastro.Text = "";
			// 
			// tabEmprestimos
			// 
			this.tabEmprestimos.Controls.Add(this.tbVinculos);
			this.tabEmprestimos.Location = new System.Drawing.Point(4, 22);
			this.tabEmprestimos.Name = "tabEmprestimos";
			this.tabEmprestimos.Padding = new System.Windows.Forms.Padding(3);
			this.tabEmprestimos.Size = new System.Drawing.Size(996, 527);
			this.tabEmprestimos.TabIndex = 1;
			this.tabEmprestimos.Text = "Vínculos";
			this.tabEmprestimos.UseVisualStyleBackColor = true;
			// 
			// tbVinculos
			// 
			this.tbVinculos.Location = new System.Drawing.Point(3, 3);
			this.tbVinculos.Name = "tbVinculos";
			this.tbVinculos.Size = new System.Drawing.Size(990, 518);
			this.tbVinculos.TabIndex = 0;
			this.tbVinculos.Text = "";
			// 
			// tabQW51
			// 
			this.tabQW51.Controls.Add(this.dataGridView1);
			this.tabQW51.Location = new System.Drawing.Point(4, 22);
			this.tabQW51.Name = "tabQW51";
			this.tabQW51.Padding = new System.Windows.Forms.Padding(3);
			this.tabQW51.Size = new System.Drawing.Size(996, 527);
			this.tabQW51.TabIndex = 2;
			this.tabQW51.Text = "QW51";
			this.tabQW51.UseVisualStyleBackColor = true;
			this.tabQW51.Enter += new System.EventHandler(this.TabQW51Enter);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(990, 521);
			this.dataGridView1.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.StaQW50,
									this.toolStripSplitButton1,
									this.stQW51});
			this.statusStrip1.Location = new System.Drawing.Point(0, 708);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// StaQW50
			// 
			this.StaQW50.Name = "StaQW50";
			this.StaQW50.Size = new System.Drawing.Size(79, 17);
			this.StaQW50.Text = "QW 50 aberto";
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
			this.toolStripSplitButton1.Text = "toolStripSplitButton1";
			// 
			// stQW51
			// 
			this.stQW51.Name = "stQW51";
			this.stQW51.Size = new System.Drawing.Size(79, 17);
			this.stQW51.Text = "QW 51 aberto";
			// 
			// filtrarQW54SuplementarToolStripMenuItem
			// 
			this.filtrarQW54SuplementarToolStripMenuItem.Name = "filtrarQW54SuplementarToolStripMenuItem";
			this.filtrarQW54SuplementarToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.filtrarQW54SuplementarToolStripMenuItem.Text = "Filtrar QW54 Suplementar";
			this.filtrarQW54SuplementarToolStripMenuItem.Click += new System.EventHandler(this.FiltrarQW54SuplementarToolStripMenuItemClick);
			// 
			// FrmEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 730);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmEntrada";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Analisador de QW";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEntradaFormClosing);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabCadastro.ResumeLayout(false);
			this.tabEmprestimos.ResumeLayout(false);
			this.tabQW51.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem filtrarQW54SuplementarToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem carregarQW51ToolStripMenuItem;
		private System.Windows.Forms.RichTextBox tbVinculos;
		private System.Windows.Forms.Label lblNumFunc;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.RichTextBox tbCadastro;
		private System.Windows.Forms.TextBox tbNumFunc;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabPage tabQW51;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripStatusLabel stQW51;
		private System.Windows.Forms.ToolStripStatusLabel StaQW50;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TabPage tabEmprestimos;
		private System.Windows.Forms.TabPage tabCadastro;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbCPF;
		private System.Windows.Forms.ToolStripMenuItem mnuSair;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem mnuConfig;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSair;
		
		
		void FrmEntradaFormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Deseja realmente Sair?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dialogResult == DialogResult.No)
			{
			    e.Cancel = true;
			}
		}
	}
}
