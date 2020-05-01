namespace AppFinanceiro {
    partial class Lancamentos {
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
            this.lblLanId = new System.Windows.Forms.Label();
            this.lblLanData = new System.Windows.Forms.Label();
            this.lblLanGrupo = new System.Windows.Forms.Label();
            this.lblLanValor = new System.Windows.Forms.Label();
            this.lblLanDescricao = new System.Windows.Forms.Label();
            this.txtLanId = new System.Windows.Forms.TextBox();
            this.lbxLanGrupo = new System.Windows.Forms.ListBox();
            this.dtpLanData = new System.Windows.Forms.DateTimePicker();
            this.txtLanValor = new System.Windows.Forms.TextBox();
            this.txtLanDescricao = new System.Windows.Forms.TextBox();
            this.gbxLanRegistro = new System.Windows.Forms.GroupBox();
            this.dgvLanResumo = new System.Windows.Forms.DataGridView();
            this.gbxLanRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanResumo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLanId
            // 
            this.lblLanId.AutoSize = true;
            this.lblLanId.Location = new System.Drawing.Point(70, 38);
            this.lblLanId.Name = "lblLanId";
            this.lblLanId.Size = new System.Drawing.Size(19, 18);
            this.lblLanId.TabIndex = 0;
            this.lblLanId.Text = "Id";
            // 
            // lblLanData
            // 
            this.lblLanData.AutoSize = true;
            this.lblLanData.Location = new System.Drawing.Point(368, 41);
            this.lblLanData.Name = "lblLanData";
            this.lblLanData.Size = new System.Drawing.Size(39, 18);
            this.lblLanData.TabIndex = 1;
            this.lblLanData.Text = "Data";
            // 
            // lblLanGrupo
            // 
            this.lblLanGrupo.AutoSize = true;
            this.lblLanGrupo.Location = new System.Drawing.Point(39, 120);
            this.lblLanGrupo.Name = "lblLanGrupo";
            this.lblLanGrupo.Size = new System.Drawing.Size(50, 18);
            this.lblLanGrupo.TabIndex = 2;
            this.lblLanGrupo.Text = "Grupo";
            // 
            // lblLanValor
            // 
            this.lblLanValor.AutoSize = true;
            this.lblLanValor.Location = new System.Drawing.Point(323, 120);
            this.lblLanValor.Name = "lblLanValor";
            this.lblLanValor.Size = new System.Drawing.Size(42, 18);
            this.lblLanValor.TabIndex = 3;
            this.lblLanValor.Text = "Valor";
            // 
            // lblLanDescricao
            // 
            this.lblLanDescricao.AutoSize = true;
            this.lblLanDescricao.Location = new System.Drawing.Point(13, 153);
            this.lblLanDescricao.Name = "lblLanDescricao";
            this.lblLanDescricao.Size = new System.Drawing.Size(76, 18);
            this.lblLanDescricao.TabIndex = 4;
            this.lblLanDescricao.Text = "Descrição";
            // 
            // txtLanId
            // 
            this.txtLanId.Location = new System.Drawing.Point(105, 35);
            this.txtLanId.Name = "txtLanId";
            this.txtLanId.Size = new System.Drawing.Size(71, 24);
            this.txtLanId.TabIndex = 5;
            // 
            // lbxLanGrupo
            // 
            this.lbxLanGrupo.FormattingEnabled = true;
            this.lbxLanGrupo.ItemHeight = 18;
            this.lbxLanGrupo.Location = new System.Drawing.Point(105, 122);
            this.lbxLanGrupo.Name = "lbxLanGrupo";
            this.lbxLanGrupo.Size = new System.Drawing.Size(151, 22);
            this.lbxLanGrupo.TabIndex = 6;
            // 
            // dtpLanData
            // 
            this.dtpLanData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLanData.Location = new System.Drawing.Point(416, 38);
            this.dtpLanData.Name = "dtpLanData";
            this.dtpLanData.Size = new System.Drawing.Size(110, 24);
            this.dtpLanData.TabIndex = 7;
            // 
            // txtLanValor
            // 
            this.txtLanValor.Location = new System.Drawing.Point(371, 120);
            this.txtLanValor.Name = "txtLanValor";
            this.txtLanValor.Size = new System.Drawing.Size(155, 24);
            this.txtLanValor.TabIndex = 8;
            // 
            // txtLanDescricao
            // 
            this.txtLanDescricao.Location = new System.Drawing.Point(105, 150);
            this.txtLanDescricao.Name = "txtLanDescricao";
            this.txtLanDescricao.Size = new System.Drawing.Size(421, 24);
            this.txtLanDescricao.TabIndex = 9;
            // 
            // gbxLanRegistro
            // 
            this.gbxLanRegistro.Controls.Add(this.txtLanId);
            this.gbxLanRegistro.Controls.Add(this.lblLanDescricao);
            this.gbxLanRegistro.Controls.Add(this.txtLanDescricao);
            this.gbxLanRegistro.Controls.Add(this.lblLanId);
            this.gbxLanRegistro.Controls.Add(this.txtLanValor);
            this.gbxLanRegistro.Controls.Add(this.lblLanValor);
            this.gbxLanRegistro.Controls.Add(this.dtpLanData);
            this.gbxLanRegistro.Controls.Add(this.lbxLanGrupo);
            this.gbxLanRegistro.Controls.Add(this.lblLanData);
            this.gbxLanRegistro.Controls.Add(this.lblLanGrupo);
            this.gbxLanRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLanRegistro.Location = new System.Drawing.Point(22, 25);
            this.gbxLanRegistro.Name = "gbxLanRegistro";
            this.gbxLanRegistro.Size = new System.Drawing.Size(551, 263);
            this.gbxLanRegistro.TabIndex = 10;
            this.gbxLanRegistro.TabStop = false;
            this.gbxLanRegistro.Text = "Registros";
            // 
            // dgvLanResumo
            // 
            this.dgvLanResumo.AllowUserToAddRows = false;
            this.dgvLanResumo.AllowUserToDeleteRows = false;
            this.dgvLanResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLanResumo.Location = new System.Drawing.Point(22, 312);
            this.dgvLanResumo.Name = "dgvLanResumo";
            this.dgvLanResumo.ReadOnly = true;
            this.dgvLanResumo.Size = new System.Drawing.Size(551, 241);
            this.dgvLanResumo.TabIndex = 11;
            // 
            // Lancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 565);
            this.Controls.Add(this.dgvLanResumo);
            this.Controls.Add(this.gbxLanRegistro);
            this.Name = "Lancamentos";
            this.Text = "Lançamentos";
            this.gbxLanRegistro.ResumeLayout(false);
            this.gbxLanRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLanResumo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLanId;
        private System.Windows.Forms.Label lblLanData;
        private System.Windows.Forms.Label lblLanGrupo;
        private System.Windows.Forms.Label lblLanValor;
        private System.Windows.Forms.Label lblLanDescricao;
        private System.Windows.Forms.TextBox txtLanId;
        private System.Windows.Forms.ListBox lbxLanGrupo;
        private System.Windows.Forms.DateTimePicker dtpLanData;
        private System.Windows.Forms.TextBox txtLanValor;
        private System.Windows.Forms.TextBox txtLanDescricao;
        private System.Windows.Forms.GroupBox gbxLanRegistro;
        private System.Windows.Forms.DataGridView dgvLanResumo;
    }
}