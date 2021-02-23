
namespace CadastroEventoProway
{
    partial class Form1
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
            this.tbCadastro = new System.Windows.Forms.TabControl();
            this.tbLista = new System.Windows.Forms.TabPage();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSala = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.tbAluno = new System.Windows.Forms.TabPage();
            this.tbSala = new System.Windows.Forms.TabPage();
            this.tbCafe = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSala = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCadastro.SuspendLayout();
            this.tbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.tbAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSala)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.tbLista);
            this.tbCadastro.Controls.Add(this.tbAluno);
            this.tbCadastro.Controls.Add(this.tbCafe);
            this.tbCadastro.Controls.Add(this.tbSala);
            this.tbCadastro.Location = new System.Drawing.Point(12, 12);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.SelectedIndex = 0;
            this.tbCadastro.Size = new System.Drawing.Size(776, 426);
            this.tbCadastro.TabIndex = 0;
            // 
            // tbLista
            // 
            this.tbLista.Controls.Add(this.btnExcluir);
            this.tbLista.Controls.Add(this.dgvLista);
            this.tbLista.Controls.Add(this.btnSair);
            this.tbLista.Controls.Add(this.btnSala);
            this.tbLista.Controls.Add(this.btnCafe);
            this.tbLista.Controls.Add(this.btnAluno);
            this.tbLista.Location = new System.Drawing.Point(4, 22);
            this.tbLista.Name = "tbLista";
            this.tbLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbLista.Size = new System.Drawing.Size(768, 400);
            this.tbLista.TabIndex = 0;
            this.tbLista.Text = "Lista";
            this.tbLista.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Nascimento,
            this.Sala});
            this.dgvLista.Location = new System.Drawing.Point(6, 66);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(756, 328);
            this.dgvLista.TabIndex = 4;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSair.Location = new System.Drawing.Point(687, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 54);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSala
            // 
            this.btnSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSala.Location = new System.Drawing.Point(216, 6);
            this.btnSala.Name = "btnSala";
            this.btnSala.Size = new System.Drawing.Size(99, 54);
            this.btnSala.TabIndex = 2;
            this.btnSala.Text = "Cadastrar Sala";
            this.btnSala.UseVisualStyleBackColor = true;
            this.btnSala.Click += new System.EventHandler(this.btnSala_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCafe.Location = new System.Drawing.Point(111, 6);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(99, 54);
            this.btnCafe.TabIndex = 1;
            this.btnCafe.Text = "Cadastrar Café";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btnCafe_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.Location = new System.Drawing.Point(6, 6);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(99, 54);
            this.btnAluno.TabIndex = 0;
            this.btnAluno.Text = "Cadastrar Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // tbAluno
            // 
            this.tbAluno.Controls.Add(this.mtbNascimento);
            this.tbAluno.Controls.Add(this.label3);
            this.tbAluno.Controls.Add(this.nudSala);
            this.tbAluno.Controls.Add(this.label2);
            this.tbAluno.Controls.Add(this.btnLimpar);
            this.tbAluno.Controls.Add(this.btnCadastrar);
            this.tbAluno.Controls.Add(this.txtNome);
            this.tbAluno.Controls.Add(this.label1);
            this.tbAluno.Location = new System.Drawing.Point(4, 22);
            this.tbAluno.Name = "tbAluno";
            this.tbAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tbAluno.Size = new System.Drawing.Size(768, 400);
            this.tbAluno.TabIndex = 1;
            this.tbAluno.Text = "Cadastro Aluno";
            this.tbAluno.UseVisualStyleBackColor = true;
            // 
            // tbSala
            // 
            this.tbSala.Location = new System.Drawing.Point(4, 22);
            this.tbSala.Name = "tbSala";
            this.tbSala.Size = new System.Drawing.Size(768, 400);
            this.tbSala.TabIndex = 2;
            this.tbSala.Text = "Cadastro Sala";
            this.tbSala.UseVisualStyleBackColor = true;
            // 
            // tbCafe
            // 
            this.tbCafe.Location = new System.Drawing.Point(4, 22);
            this.tbCafe.Name = "tbCafe";
            this.tbCafe.Size = new System.Drawing.Size(768, 400);
            this.tbCafe.TabIndex = 3;
            this.tbCafe.Text = "Cadastro Café";
            this.tbCafe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNome.Location = new System.Drawing.Point(188, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 26);
            this.txtNome.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCadastrar.Location = new System.Drawing.Point(668, 356);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 38);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnExcluir.Location = new System.Drawing.Point(582, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 54);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnLimpar.Location = new System.Drawing.Point(568, 356);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 38);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(140, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sala";
            // 
            // nudSala
            // 
            this.nudSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nudSala.Location = new System.Drawing.Point(188, 97);
            this.nudSala.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSala.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSala.Name = "nudSala";
            this.nudSala.Size = new System.Drawing.Size(120, 26);
            this.nudSala.TabIndex = 5;
            this.nudSala.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Nascimento";
            // 
            // mtbNascimento
            // 
            this.mtbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mtbNascimento.Location = new System.Drawing.Point(188, 61);
            this.mtbNascimento.Mask = "00/00/0000";
            this.mtbNascimento.Name = "mtbNascimento";
            this.mtbNascimento.Size = new System.Drawing.Size(97, 26);
            this.mtbNascimento.TabIndex = 7;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Aluno";
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // Nascimento
            // 
            this.Nascimento.HeaderText = "Data de Nascimento";
            this.Nascimento.Name = "Nascimento";
            // 
            // Sala
            // 
            this.Sala.HeaderText = "Sala Aluno";
            this.Sala.Name = "Sala";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCadastro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tbCadastro.ResumeLayout(false);
            this.tbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.tbAluno.ResumeLayout(false);
            this.tbAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCadastro;
        private System.Windows.Forms.TabPage tbLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSala;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.TabPage tbAluno;
        private System.Windows.Forms.TabPage tbSala;
        private System.Windows.Forms.TabPage tbCafe;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.NumericUpDown nudSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
    }
}

