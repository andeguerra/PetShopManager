namespace ProjetoDesktop
{
    partial class FrmListaComple
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscNome = new System.Windows.Forms.TextBox();
            this.txtBuscTele = new System.Windows.Forms.TextBox();
            this.txtBuscEnde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(21, 147);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(957, 481);
            this.dgvLista.TabIndex = 0;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(21, 12);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(187, 34);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastrar Cliente";
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(681, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(852, 666);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Excluir ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtBuscNome
            // 
            this.txtBuscNome.Location = new System.Drawing.Point(695, 12);
            this.txtBuscNome.Name = "txtBuscNome";
            this.txtBuscNome.Size = new System.Drawing.Size(283, 22);
            this.txtBuscNome.TabIndex = 5;
            // 
            // txtBuscTele
            // 
            this.txtBuscTele.Location = new System.Drawing.Point(695, 53);
            this.txtBuscTele.Name = "txtBuscTele";
            this.txtBuscTele.Size = new System.Drawing.Size(283, 22);
            this.txtBuscTele.TabIndex = 6;
            // 
            // txtBuscEnde
            // 
            this.txtBuscEnde.Location = new System.Drawing.Point(695, 93);
            this.txtBuscEnde.Name = "txtBuscEnde";
            this.txtBuscEnde.Size = new System.Drawing.Size(283, 22);
            this.txtBuscEnde.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(530, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar por nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pesquisa por telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(482, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pesquisa por endereço:";
            // 
            // FrmListaComple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(998, 712);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscEnde);
            this.Controls.Add(this.txtBuscTele);
            this.Controls.Add(this.txtBuscNome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.dgvLista);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaComple";
            this.Text = "FrmListaComple";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscNome;
        private System.Windows.Forms.TextBox txtBuscTele;
        private System.Windows.Forms.TextBox txtBuscEnde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}