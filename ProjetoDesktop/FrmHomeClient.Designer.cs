namespace ProjetoDesktop
{
    partial class FrmHomeClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minhaDataGridView = new System.Windows.Forms.DataGridView();
            this.botao_consulta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCliCad = new System.Windows.Forms.Button();
            this.lblCliCad = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minhaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // minhaDataGridView
            // 
            this.minhaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.minhaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.minhaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minhaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.minhaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.minhaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.minhaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.botao_consulta,
            this.nome,
            this.endereco,
            this.telefone});
            this.minhaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.minhaDataGridView.Location = new System.Drawing.Point(12, 306);
            this.minhaDataGridView.Name = "minhaDataGridView";
            this.minhaDataGridView.ReadOnly = true;
            this.minhaDataGridView.RowHeadersVisible = false;
            this.minhaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.minhaDataGridView.Size = new System.Drawing.Size(974, 394);
            this.minhaDataGridView.TabIndex = 0;
            // 
            // botao_consulta
            // 
            this.botao_consulta.DefaultCellStyle = dataGridViewCellStyle6;
            this.botao_consulta.FillWeight = 25F;
            this.botao_consulta.HeaderText = "Opções";
            this.botao_consulta.Name = "botao_consulta";
            this.botao_consulta.ReadOnly = true;
            this.botao_consulta.Text = "Opções ↓";
            this.botao_consulta.UseColumnTextForButtonValue = true;
            // 
            // nome
            // 
            this.nome.FillWeight = 65.65144F;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.FillWeight = 65.65144F;
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.FillWeight = 65.65144F;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(12, 12);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(187, 34);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastrar Cliente";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCliCad
            // 
            this.btnCliCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnCliCad.FlatAppearance.BorderSize = 0;
            this.btnCliCad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnCliCad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnCliCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliCad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliCad.ForeColor = System.Drawing.Color.White;
            this.btnCliCad.Location = new System.Drawing.Point(805, 12);
            this.btnCliCad.Name = "btnCliCad";
            this.btnCliCad.Size = new System.Drawing.Size(178, 90);
            this.btnCliCad.TabIndex = 2;
            this.btnCliCad.Text = "Clientes Cadastrados";
            this.btnCliCad.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCliCad.UseVisualStyleBackColor = false;
            // 
            // lblCliCad
            // 
            this.lblCliCad.AutoSize = true;
            this.lblCliCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.lblCliCad.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCad.ForeColor = System.Drawing.Color.White;
            this.lblCliCad.Location = new System.Drawing.Point(903, 12);
            this.lblCliCad.Name = "lblCliCad";
            this.lblCliCad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCliCad.Size = new System.Drawing.Size(80, 47);
            this.lblCliCad.TabIndex = 3;
            this.lblCliCad.Text = "100";
            this.lblCliCad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnLista.ForeColor = System.Drawing.Color.White;
            this.btnLista.Location = new System.Drawing.Point(706, 266);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(280, 34);
            this.btnLista.TabIndex = 4;
            this.btnLista.Text = "Visualizar lista completa";
            this.btnLista.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 273);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(276, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Últimos clientes cadastrados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHomeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(998, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lblCliCad);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.minhaDataGridView);
            this.Controls.Add(this.btnCliCad);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHomeClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHomeClient";
            this.Load += new System.EventHandler(this.FrmHomeClient_Load);
            this.Shown += new System.EventHandler(this.FrmHomeClient_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.minhaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView minhaDataGridView;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.DataGridViewButtonColumn botao_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.Button btnCliCad;
        private System.Windows.Forms.Label lblCliCad;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label label1;
    }
}