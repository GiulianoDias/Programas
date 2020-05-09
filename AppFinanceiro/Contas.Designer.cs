namespace AppFinanceiro {
    partial class Contas {
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
            this.lblId = new System.Windows.Forms.Label();
            this.lbConta = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.cboConGrupo = new System.Windows.Forms.ComboBox();
            this.txtConId = new System.Windows.Forms.TextBox();
            this.txtConConta = new System.Windows.Forms.TextBox();
            this.dgvConRegistros = new System.Windows.Forms.DataGridView();
            this.lblGrid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblId.Location = new System.Drawing.Point(17, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // lbConta
            // 
            this.lbConta.AutoSize = true;
            this.lbConta.BackColor = System.Drawing.Color.Transparent;
            this.lbConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbConta.Location = new System.Drawing.Point(17, 69);
            this.lbConta.Name = "lbConta";
            this.lbConta.Size = new System.Drawing.Size(48, 18);
            this.lbConta.TabIndex = 1;
            this.lbConta.Text = "Conta";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.BackColor = System.Drawing.Color.Transparent;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrupo.Location = new System.Drawing.Point(259, 72);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(50, 18);
            this.lblGrupo.TabIndex = 2;
            this.lblGrupo.Text = "Grupo";
            // 
            // cboConGrupo
            // 
            this.cboConGrupo.AutoCompleteCustomSource.AddRange(new string[] {
            "Receitas",
            "Despesas"});
            this.cboConGrupo.FormattingEnabled = true;
            this.cboConGrupo.Location = new System.Drawing.Point(333, 69);
            this.cboConGrupo.Name = "cboConGrupo";
            this.cboConGrupo.Size = new System.Drawing.Size(156, 21);
            this.cboConGrupo.TabIndex = 3;
            // 
            // txtConId
            // 
            this.txtConId.Location = new System.Drawing.Point(53, 35);
            this.txtConId.Name = "txtConId";
            this.txtConId.Size = new System.Drawing.Size(49, 20);
            this.txtConId.TabIndex = 4;
            // 
            // txtConConta
            // 
            this.txtConConta.Location = new System.Drawing.Point(76, 70);
            this.txtConConta.Name = "txtConConta";
            this.txtConConta.Size = new System.Drawing.Size(177, 20);
            this.txtConConta.TabIndex = 5;
            // 
            // dgvConRegistros
            // 
            this.dgvConRegistros.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvConRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConRegistros.GridColor = System.Drawing.Color.White;
            this.dgvConRegistros.Location = new System.Drawing.Point(20, 184);
            this.dgvConRegistros.Name = "dgvConRegistros";
            this.dgvConRegistros.Size = new System.Drawing.Size(469, 139);
            this.dgvConRegistros.TabIndex = 6;
            this.dgvConRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // lblGrid
            // 
            this.lblGrid.AutoSize = true;
            this.lblGrid.BackColor = System.Drawing.Color.Transparent;
            this.lblGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGrid.Location = new System.Drawing.Point(21, 163);
            this.lblGrid.Name = "lblGrid";
            this.lblGrid.Size = new System.Drawing.Size(72, 18);
            this.lblGrid.TabIndex = 7;
            this.lblGrid.Text = "Registros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(414, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 344);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGrid);
            this.Controls.Add(this.dgvConRegistros);
            this.Controls.Add(this.txtConConta);
            this.Controls.Add(this.txtConId);
            this.Controls.Add(this.cboConGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lbConta);
            this.Controls.Add(this.lblId);
            this.MaximizeBox = false;
            this.Name = "Contas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas";
            this.Load += new System.EventHandler(this.Contas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbConta;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cboConGrupo;
        private System.Windows.Forms.TextBox txtConId;
        private System.Windows.Forms.TextBox txtConConta;
        private System.Windows.Forms.DataGridView dgvConRegistros;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}