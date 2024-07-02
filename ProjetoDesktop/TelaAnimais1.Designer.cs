namespace ProjetoDesktop
{
    partial class TelaAnimais1
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
            this.CadastrarPetAnimais = new System.Windows.Forms.Button();
            this.VisualizarL_Animais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PetsCadastrados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minhaDataGridView = new System.Windows.Forms.DataGridView();
            this.botao_consulta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minhaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CadastrarPetAnimais
            // 
            this.CadastrarPetAnimais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.CadastrarPetAnimais.FlatAppearance.BorderSize = 0;
            this.CadastrarPetAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarPetAnimais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarPetAnimais.ForeColor = System.Drawing.Color.White;
            this.CadastrarPetAnimais.Location = new System.Drawing.Point(10, 10);
            this.CadastrarPetAnimais.Name = "CadastrarPetAnimais";
            this.CadastrarPetAnimais.Size = new System.Drawing.Size(187, 34);
            this.CadastrarPetAnimais.TabIndex = 1;
            this.CadastrarPetAnimais.Text = "Cadastrar Pet";
            this.CadastrarPetAnimais.UseVisualStyleBackColor = false;
            this.CadastrarPetAnimais.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisualizarL_Animais
            // 
            this.VisualizarL_Animais.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.VisualizarL_Animais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.VisualizarL_Animais.FlatAppearance.BorderSize = 0;
            this.VisualizarL_Animais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualizarL_Animais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizarL_Animais.ForeColor = System.Drawing.Color.White;
            this.VisualizarL_Animais.Location = new System.Drawing.Point(708, 266);
            this.VisualizarL_Animais.Name = "VisualizarL_Animais";
            this.VisualizarL_Animais.Size = new System.Drawing.Size(280, 34);
            this.VisualizarL_Animais.TabIndex = 2;
            this.VisualizarL_Animais.Text = "Visualizar lista completa";
            this.VisualizarL_Animais.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ultimos Pets Cadastrados";
            // 
            // PetsCadastrados
            // 
            this.PetsCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PetsCadastrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.PetsCadastrados.FlatAppearance.BorderSize = 0;
            this.PetsCadastrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.PetsCadastrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetsCadastrados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetsCadastrados.ForeColor = System.Drawing.Color.White;
            this.PetsCadastrados.Location = new System.Drawing.Point(810, 10);
            this.PetsCadastrados.Name = "PetsCadastrados";
            this.PetsCadastrados.Size = new System.Drawing.Size(178, 90);
            this.PetsCadastrados.TabIndex = 4;
            this.PetsCadastrados.Text = "Pets Cadastrados";
            this.PetsCadastrados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.PetsCadastrados.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(948, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.minhaDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.VisualizarL_Animais);
            this.panel1.Controls.Add(this.CadastrarPetAnimais);
            this.panel1.Controls.Add(this.PetsCadastrados);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(998, 712);
            this.panel1.TabIndex = 7;
            // 
            // minhaDataGridView
            // 
            this.minhaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.minhaDataGridView.Location = new System.Drawing.Point(10, 308);
            this.minhaDataGridView.Name = "minhaDataGridView";
            this.minhaDataGridView.ReadOnly = true;
            this.minhaDataGridView.RowHeadersVisible = false;
            this.minhaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.minhaDataGridView.Size = new System.Drawing.Size(978, 394);
            this.minhaDataGridView.TabIndex = 6;
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
            // TelaAnimais1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(998, 712);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaAnimais1";
            this.Text = "TelaAnimais1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minhaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CadastrarPetAnimais;
        private System.Windows.Forms.Button VisualizarL_Animais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PetsCadastrados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView minhaDataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn botao_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
    }
}