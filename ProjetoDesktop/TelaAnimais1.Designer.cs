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
            this.UltimosPet_Animais = new System.Windows.Forms.DataGridView();
            this.CadastrarPetAnimais = new System.Windows.Forms.Button();
            this.VisualizarL_Animais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PetsCadastrados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UltimosPet_Animais)).BeginInit();
            this.SuspendLayout();
            // 
            // UltimosPet_Animais
            // 
            this.UltimosPet_Animais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.UltimosPet_Animais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UltimosPet_Animais.Location = new System.Drawing.Point(12, 306);
            this.UltimosPet_Animais.Name = "UltimosPet_Animais";
            this.UltimosPet_Animais.Size = new System.Drawing.Size(974, 394);
            this.UltimosPet_Animais.TabIndex = 0;
            // 
            // CadastrarPetAnimais
            // 
            this.CadastrarPetAnimais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.CadastrarPetAnimais.FlatAppearance.BorderSize = 0;
            this.CadastrarPetAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarPetAnimais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarPetAnimais.ForeColor = System.Drawing.Color.White;
            this.CadastrarPetAnimais.Location = new System.Drawing.Point(12, 12);
            this.CadastrarPetAnimais.Name = "CadastrarPetAnimais";
            this.CadastrarPetAnimais.Size = new System.Drawing.Size(187, 34);
            this.CadastrarPetAnimais.TabIndex = 1;
            this.CadastrarPetAnimais.Text = "Cadastrar Pet";
            this.CadastrarPetAnimais.UseVisualStyleBackColor = false;
            this.CadastrarPetAnimais.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisualizarL_Animais
            // 
            this.VisualizarL_Animais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.VisualizarL_Animais.FlatAppearance.BorderSize = 0;
            this.VisualizarL_Animais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisualizarL_Animais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizarL_Animais.ForeColor = System.Drawing.Color.White;
            this.VisualizarL_Animais.Location = new System.Drawing.Point(706, 266);
            this.VisualizarL_Animais.Name = "VisualizarL_Animais";
            this.VisualizarL_Animais.Size = new System.Drawing.Size(280, 34);
            this.VisualizarL_Animais.TabIndex = 2;
            this.VisualizarL_Animais.Text = "Visualizar Lista Completa";
            this.VisualizarL_Animais.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ultimos Pets Cadastrados";
            // 
            // PetsCadastrados
            // 
            this.PetsCadastrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.PetsCadastrados.FlatAppearance.BorderSize = 0;
            this.PetsCadastrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.PetsCadastrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetsCadastrados.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PetsCadastrados.ForeColor = System.Drawing.Color.White;
            this.PetsCadastrados.Location = new System.Drawing.Point(808, 12);
            this.PetsCadastrados.Name = "PetsCadastrados";
            this.PetsCadastrados.Size = new System.Drawing.Size(178, 90);
            this.PetsCadastrados.TabIndex = 4;
            this.PetsCadastrados.Text = "Pets Cadastrados";
            this.PetsCadastrados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.PetsCadastrados.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(174)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(949, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "2";
            // 
            // TelaAnimais1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(998, 712);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PetsCadastrados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisualizarL_Animais);
            this.Controls.Add(this.CadastrarPetAnimais);
            this.Controls.Add(this.UltimosPet_Animais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaAnimais1";
            this.Text = "TelaAnimais1";
            ((System.ComponentModel.ISupportInitialize)(this.UltimosPet_Animais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UltimosPet_Animais;
        private System.Windows.Forms.Button CadastrarPetAnimais;
        private System.Windows.Forms.Button VisualizarL_Animais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PetsCadastrados;
        private System.Windows.Forms.Label label2;
    }
}