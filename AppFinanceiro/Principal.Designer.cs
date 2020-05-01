namespace AppFinanceiro {
    partial class Principal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadContas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCadLancamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelAcumulados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRelAcuLancamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArquivo,
            this.tsmCadastros,
            this.tsmRelatorios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmArquivo
            // 
            this.tsmArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSair});
            this.tsmArquivo.Name = "tsmArquivo";
            this.tsmArquivo.Size = new System.Drawing.Size(61, 20);
            this.tsmArquivo.Text = "&Arquivo";
            // 
            // tsmSair
            // 
            this.tsmSair.Name = "tsmSair";
            this.tsmSair.Size = new System.Drawing.Size(93, 22);
            this.tsmSair.Text = "Sair";
            // 
            // tsmCadastros
            // 
            this.tsmCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadContas,
            this.tsmCadLancamentos});
            this.tsmCadastros.Name = "tsmCadastros";
            this.tsmCadastros.Size = new System.Drawing.Size(71, 20);
            this.tsmCadastros.Text = "&Cadastros";
            // 
            // tsmCadContas
            // 
            this.tsmCadContas.Name = "tsmCadContas";
            this.tsmCadContas.Size = new System.Drawing.Size(180, 22);
            this.tsmCadContas.Text = "Contas";
            this.tsmCadContas.Click += new System.EventHandler(this.tsmCadContas_Click);
            // 
            // tsmCadLancamentos
            // 
            this.tsmCadLancamentos.Name = "tsmCadLancamentos";
            this.tsmCadLancamentos.Size = new System.Drawing.Size(180, 22);
            this.tsmCadLancamentos.Text = "Lançamentos";
            // 
            // tsmRelatorios
            // 
            this.tsmRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRelAcumulados});
            this.tsmRelatorios.Name = "tsmRelatorios";
            this.tsmRelatorios.Size = new System.Drawing.Size(71, 20);
            this.tsmRelatorios.Text = "&Relatórios";
            // 
            // tsmRelAcumulados
            // 
            this.tsmRelAcumulados.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRelAcuLancamentos});
            this.tsmRelAcumulados.Name = "tsmRelAcumulados";
            this.tsmRelAcumulados.Size = new System.Drawing.Size(180, 22);
            this.tsmRelAcumulados.Text = "Acumulados";
            // 
            // tsmRelAcuLancamentos
            // 
            this.tsmRelAcuLancamentos.Name = "tsmRelAcuLancamentos";
            this.tsmRelAcuLancamentos.Size = new System.Drawing.Size(180, 22);
            this.tsmRelAcuLancamentos.Text = "Lançamentos";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmArquivo;
        private System.Windows.Forms.ToolStripMenuItem tsmSair;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastros;
        private System.Windows.Forms.ToolStripMenuItem tsmCadContas;
        private System.Windows.Forms.ToolStripMenuItem tsmCadLancamentos;
        private System.Windows.Forms.ToolStripMenuItem tsmRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tsmRelAcumulados;
        private System.Windows.Forms.ToolStripMenuItem tsmRelAcuLancamentos;
    }
}