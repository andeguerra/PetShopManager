namespace ProjetoDesktop
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlWhiteForm = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnAtendimento = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnCentral = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tmrSidebar = new System.Windows.Forms.Timer(this.components);
            this.pnlSidebar.SuspendLayout();
            this.pnCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlSidebar.Controls.Add(this.pnlWhiteForm);
            this.pnlSidebar.Controls.Add(this.btnMenu);
            this.pnlSidebar.Controls.Add(this.btnProdutos);
            this.pnlSidebar.Controls.Add(this.btnEstoque);
            this.pnlSidebar.Controls.Add(this.btnVendas);
            this.pnlSidebar.Controls.Add(this.btnAtendimento);
            this.pnlSidebar.Controls.Add(this.btnAnimais);
            this.pnlSidebar.Controls.Add(this.btnClientes);
            this.pnlSidebar.Controls.Add(this.btnInicio);
            this.pnlSidebar.Controls.Add(this.btnSair);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.MaximumSize = new System.Drawing.Size(282, 768);
            this.pnlSidebar.MinimumSize = new System.Drawing.Size(81, 768);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(282, 768);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlWhiteForm
            // 
            this.pnlWhiteForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlWhiteForm.Location = new System.Drawing.Point(0, 92);
            this.pnlWhiteForm.Name = "pnlWhiteForm";
            this.pnlWhiteForm.Size = new System.Drawing.Size(2, 81);
            this.pnlWhiteForm.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::ProjetoDesktop.Properties.Resources.cardapio;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnMenu.Size = new System.Drawing.Size(282, 56);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "PetPro Suit";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Image = global::ProjetoDesktop.Properties.Resources.produtos;
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 578);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnProdutos.Size = new System.Drawing.Size(282, 81);
            this.btnProdutos.TabIndex = 8;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = global::ProjetoDesktop.Properties.Resources.pacotes__1_;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 497);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnEstoque.Size = new System.Drawing.Size(282, 81);
            this.btnEstoque.TabIndex = 7;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Image = global::ProjetoDesktop.Properties.Resources.carrinho_de_compras__1_;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(0, 416);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnVendas.Size = new System.Drawing.Size(282, 81);
            this.btnVendas.TabIndex = 6;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVendas.UseVisualStyleBackColor = false;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnAtendimento
            // 
            this.btnAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAtendimento.FlatAppearance.BorderSize = 0;
            this.btnAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtendimento.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendimento.ForeColor = System.Drawing.Color.White;
            this.btnAtendimento.Image = global::ProjetoDesktop.Properties.Resources.estetoscopio__1_;
            this.btnAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtendimento.Location = new System.Drawing.Point(0, 335);
            this.btnAtendimento.Name = "btnAtendimento";
            this.btnAtendimento.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAtendimento.Size = new System.Drawing.Size(282, 81);
            this.btnAtendimento.TabIndex = 5;
            this.btnAtendimento.Text = "Atendimento";
            this.btnAtendimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtendimento.UseVisualStyleBackColor = false;
            this.btnAtendimento.Click += new System.EventHandler(this.btnAtendimento_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAnimais.FlatAppearance.BorderSize = 0;
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimais.ForeColor = System.Drawing.Color.White;
            this.btnAnimais.Image = global::ProjetoDesktop.Properties.Resources.pata;
            this.btnAnimais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnimais.Location = new System.Drawing.Point(0, 254);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAnimais.Size = new System.Drawing.Size(282, 81);
            this.btnAnimais.TabIndex = 4;
            this.btnAnimais.Text = "Bichinhos";
            this.btnAnimais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnimais.UseVisualStyleBackColor = false;
            this.btnAnimais.Click += new System.EventHandler(this.btnAnimais_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::ProjetoDesktop.Properties.Resources.arquivo;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 173);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnClientes.Size = new System.Drawing.Size(282, 81);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::ProjetoDesktop.Properties.Resources.casa__4_;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 92);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnInicio.Size = new System.Drawing.Size(282, 81);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicío";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::ProjetoDesktop.Properties.Resources.saida__1_;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 695);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSair.Size = new System.Drawing.Size(282, 73);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(282, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 56);
            this.panel2.TabIndex = 1;
            // 
            // pnCentral
            // 
            this.pnCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnCentral.Controls.Add(this.panel4);
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCentral.Location = new System.Drawing.Point(282, 56);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(998, 712);
            this.pnCentral.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(16, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(970, 680);
            this.panel4.TabIndex = 0;
            // 
            // tmrSidebar
            // 
            this.tmrSidebar.Interval = 10;
            this.tmrSidebar.Tick += new System.EventHandler(this.tmrSidebar_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.pnCentral);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnAtendimento;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Timer tmrSidebar;
        private System.Windows.Forms.Panel pnlWhiteForm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnCentral;
    }
}

