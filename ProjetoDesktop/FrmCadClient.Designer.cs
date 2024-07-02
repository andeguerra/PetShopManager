namespace ProjetoDesktop
{
    partial class FrmCadClient
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
            this.btnLista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnSelecionado = new System.Windows.Forms.Panel();
            this.pnCadClient = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLista
            // 
            this.btnLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnLista.ForeColor = System.Drawing.Color.White;
            this.btnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.Location = new System.Drawing.Point(31, 32);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(934, 38);
            this.btnLista.TabIndex = 5;
            this.btnLista.Text = "Cadastro de Cliente";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLista.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pnSelecionado);
            this.panel1.Controls.Add(this.pnCadClient);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Location = new System.Drawing.Point(31, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 613);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(317, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Endereço";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(167, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Contatos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnSelecionado
            // 
            this.pnSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.pnSelecionado.Location = new System.Drawing.Point(17, 54);
            this.pnSelecionado.Name = "pnSelecionado";
            this.pnSelecionado.Size = new System.Drawing.Size(149, 6);
            this.pnSelecionado.TabIndex = 0;
            // 
            // pnCadClient
            // 
            this.pnCadClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnCadClient.BackColor = System.Drawing.Color.White;
            this.pnCadClient.Location = new System.Drawing.Point(17, 60);
            this.pnCadClient.Name = "pnCadClient";
            this.pnCadClient.Size = new System.Drawing.Size(899, 534);
            this.pnCadClient.TabIndex = 3;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.White;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.Black;
            this.btnCadastro.Location = new System.Drawing.Point(17, 19);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(149, 35);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Dados Básicos";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnLista);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 712);
            this.panel2.TabIndex = 0;
            // 
            // FrmCadClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(998, 712);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadClient";
            this.Text = "FormCadClient";
            this.Load += new System.EventHandler(this.FrmCadClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnSelecionado;
        private System.Windows.Forms.Panel pnCadClient;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}