﻿namespace SistemaCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.comboEC = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.checkCasa = new System.Windows.Forms.CheckBox();
            this.checkVeiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.lista = new System.Windows.Forms.ListBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de nascimento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(191, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(359, 32);
            this.txtNome.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(191, 67);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(359, 32);
            this.txtData.TabIndex = 5;
            // 
            // comboEC
            // 
            this.comboEC.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEC.FormattingEnabled = true;
            this.comboEC.Location = new System.Drawing.Point(191, 126);
            this.comboEC.Name = "comboEC";
            this.comboEC.Size = new System.Drawing.Size(359, 31);
            this.comboEC.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(191, 188);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(359, 32);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone_MaskInputRejected);
            // 
            // checkCasa
            // 
            this.checkCasa.AutoSize = true;
            this.checkCasa.Location = new System.Drawing.Point(191, 249);
            this.checkCasa.Name = "checkCasa";
            this.checkCasa.Size = new System.Drawing.Size(122, 18);
            this.checkCasa.TabIndex = 8;
            this.checkCasa.Text = "Possui casa própria? ";
            this.checkCasa.UseVisualStyleBackColor = true;
            // 
            // checkVeiculo
            // 
            this.checkVeiculo.AutoSize = true;
            this.checkVeiculo.Location = new System.Drawing.Point(191, 274);
            this.checkVeiculo.Name = "checkVeiculo";
            this.checkVeiculo.Size = new System.Drawing.Size(96, 18);
            this.checkVeiculo.TabIndex = 9;
            this.checkVeiculo.Text = "Possui veiculo?";
            this.checkVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioO);
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(191, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(7, 82);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(52, 18);
            this.radioO.TabIndex = 2;
            this.radioO.TabStop = true;
            this.radioO.Text = "Outro";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Location = new System.Drawing.Point(6, 56);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(69, 18);
            this.radioF.TabIndex = 1;
            this.radioF.TabStop = true;
            this.radioF.Text = "Feminino";
            this.radioF.UseVisualStyleBackColor = true;
            this.radioF.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Location = new System.Drawing.Point(6, 30);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(72, 18);
            this.radioM.TabIndex = 0;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 23;
            this.lista.Location = new System.Drawing.Point(133, 531);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(631, 96);
            this.lista.TabIndex = 11;
            this.lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lista_MouseDoubleClick);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(133, 439);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(190, 67);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar / Alterar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(353, 439);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(190, 67);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(573, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 67);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkVeiculo);
            this.Controls.Add(this.checkCasa);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.comboEC);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.ComboBox comboEC;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.CheckBox checkCasa;
        private System.Windows.Forms.CheckBox checkVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button1;
    }
}

