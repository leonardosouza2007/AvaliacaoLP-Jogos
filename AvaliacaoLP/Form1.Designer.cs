namespace AvaliacaoLP
{
    partial class Avaliação
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
            this.radioBtn_Play = new System.Windows.Forms.RadioButton();
            this.radioBtn_wii = new System.Windows.Forms.RadioButton();
            this.lbl_Categoria_Selecionada = new System.Windows.Forms.Label();
            this.txtBox_Categoria = new System.Windows.Forms.TextBox();
            this.txtBox_Preco = new System.Windows.Forms.TextBox();
            this.txtBox_Quantidade = new System.Windows.Forms.TextBox();
            this.txtBox_ValorPagar = new System.Windows.Forms.TextBox();
            this.checkBox_Desconto = new System.Windows.Forms.CheckBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_ValorPagar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_xbox = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioBtn_Play
            // 
            this.radioBtn_Play.AutoSize = true;
            this.radioBtn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Play.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioBtn_Play.Location = new System.Drawing.Point(219, 41);
            this.radioBtn_Play.Name = "radioBtn_Play";
            this.radioBtn_Play.Size = new System.Drawing.Size(106, 20);
            this.radioBtn_Play.TabIndex = 1;
            this.radioBtn_Play.TabStop = true;
            this.radioBtn_Play.Text = "playStation";
            this.radioBtn_Play.UseVisualStyleBackColor = true;
            this.radioBtn_Play.CheckedChanged += new System.EventHandler(this.radioBtn_Play_CheckedChanged);
            // 
            // radioBtn_wii
            // 
            this.radioBtn_wii.AutoSize = true;
            this.radioBtn_wii.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.radioBtn_wii.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioBtn_wii.Location = new System.Drawing.Point(476, 41);
            this.radioBtn_wii.Name = "radioBtn_wii";
            this.radioBtn_wii.Size = new System.Drawing.Size(50, 20);
            this.radioBtn_wii.TabIndex = 1;
            this.radioBtn_wii.TabStop = true;
            this.radioBtn_wii.Text = "Wii";
            this.radioBtn_wii.UseVisualStyleBackColor = true;
            this.radioBtn_wii.CheckedChanged += new System.EventHandler(this.radioBtn_wii_CheckedChanged);
            // 
            // lbl_Categoria_Selecionada
            // 
            this.lbl_Categoria_Selecionada.AutoSize = true;
            this.lbl_Categoria_Selecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria_Selecionada.Location = new System.Drawing.Point(27, 207);
            this.lbl_Categoria_Selecionada.Name = "lbl_Categoria_Selecionada";
            this.lbl_Categoria_Selecionada.Size = new System.Drawing.Size(178, 18);
            this.lbl_Categoria_Selecionada.TabIndex = 4;
            this.lbl_Categoria_Selecionada.Text = "Categoria Selecionada";
            // 
            // txtBox_Categoria
            // 
            this.txtBox_Categoria.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBox_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Categoria.Location = new System.Drawing.Point(233, 207);
            this.txtBox_Categoria.Name = "txtBox_Categoria";
            this.txtBox_Categoria.Size = new System.Drawing.Size(388, 22);
            this.txtBox_Categoria.TabIndex = 5;
            // 
            // txtBox_Preco
            // 
            this.txtBox_Preco.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_Preco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Preco.Location = new System.Drawing.Point(105, 375);
            this.txtBox_Preco.Name = "txtBox_Preco";
            this.txtBox_Preco.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Preco.TabIndex = 6;
            // 
            // txtBox_Quantidade
            // 
            this.txtBox_Quantidade.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_Quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Quantidade.Location = new System.Drawing.Point(345, 373);
            this.txtBox_Quantidade.Name = "txtBox_Quantidade";
            this.txtBox_Quantidade.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Quantidade.TabIndex = 7;
            // 
            // txtBox_ValorPagar
            // 
            this.txtBox_ValorPagar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_ValorPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_ValorPagar.Location = new System.Drawing.Point(504, 443);
            this.txtBox_ValorPagar.Name = "txtBox_ValorPagar";
            this.txtBox_ValorPagar.Size = new System.Drawing.Size(117, 22);
            this.txtBox_ValorPagar.TabIndex = 8;
            // 
            // checkBox_Desconto
            // 
            this.checkBox_Desconto.AutoSize = true;
            this.checkBox_Desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Desconto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox_Desconto.Location = new System.Drawing.Point(493, 374);
            this.checkBox_Desconto.Name = "checkBox_Desconto";
            this.checkBox_Desconto.Size = new System.Drawing.Size(128, 22);
            this.checkBox_Desconto.TabIndex = 9;
            this.checkBox_Desconto.Text = "Desconto 10%";
            this.checkBox_Desconto.UseVisualStyleBackColor = true;
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Valor.Location = new System.Drawing.Point(350, 443);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(124, 20);
            this.lbl_Valor.TabIndex = 10;
            this.lbl_Valor.Text = "Valor a Pagar";
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantidade.Location = new System.Drawing.Point(230, 375);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(93, 18);
            this.lbl_Quantidade.TabIndex = 11;
            this.lbl_Quantidade.Text = "Quantidade";
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preco.Location = new System.Drawing.Point(36, 377);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(53, 18);
            this.lbl_Preco.TabIndex = 12;
            this.lbl_Preco.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome Jogo";
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBox_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Nome.Location = new System.Drawing.Point(159, 308);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(462, 22);
            this.txtBox_Nome.TabIndex = 14;
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.Color.Lime;
            this.btn_Iniciar.Location = new System.Drawing.Point(52, 503);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(153, 44);
            this.btn_Iniciar.TabIndex = 15;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Limpar.Location = new System.Drawing.Point(261, 503);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(153, 44);
            this.btn_Limpar.TabIndex = 16;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_ValorPagar
            // 
            this.btn_ValorPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ValorPagar.Location = new System.Drawing.Point(468, 503);
            this.btn_ValorPagar.Name = "btn_ValorPagar";
            this.btn_ValorPagar.Size = new System.Drawing.Size(153, 44);
            this.btn_ValorPagar.TabIndex = 17;
            this.btn_ValorPagar.Text = "Valor a Pagar";
            this.btn_ValorPagar.UseVisualStyleBackColor = false;
            this.btn_ValorPagar.Click += new System.EventHandler(this.btn_ValorPagar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_xbox);
            this.groupBox1.Controls.Add(this.radioBtn_wii);
            this.groupBox1.Controls.Add(this.radioBtn_Play);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(52, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria";
            // 
            // radioBtn_xbox
            // 
            this.radioBtn_xbox.AutoSize = true;
            this.radioBtn_xbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_xbox.Location = new System.Drawing.Point(35, 41);
            this.radioBtn_xbox.Name = "radioBtn_xbox";
            this.radioBtn_xbox.Size = new System.Drawing.Size(67, 22);
            this.radioBtn_xbox.TabIndex = 2;
            this.radioBtn_xbox.TabStop = true;
            this.radioBtn_xbox.Text = "Xbox";
            this.radioBtn_xbox.UseVisualStyleBackColor = true;
            this.radioBtn_xbox.CheckedChanged += new System.EventHandler(this.radioBtn_xbox_CheckedChanged);
            // 
            // Avaliação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(704, 592);
            this.Controls.Add(this.btn_ValorPagar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.txtBox_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Preco);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.checkBox_Desconto);
            this.Controls.Add(this.txtBox_ValorPagar);
            this.Controls.Add(this.txtBox_Quantidade);
            this.Controls.Add(this.txtBox_Preco);
            this.Controls.Add(this.txtBox_Categoria);
            this.Controls.Add(this.lbl_Categoria_Selecionada);
            this.Controls.Add(this.groupBox1);
            this.Name = "Avaliação";
            this.Text = "Avaliação";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioBtn_Play;
        private System.Windows.Forms.RadioButton radioBtn_wii;
        private System.Windows.Forms.Label lbl_Categoria_Selecionada;
        private System.Windows.Forms.TextBox txtBox_Categoria;
        private System.Windows.Forms.TextBox txtBox_Preco;
        private System.Windows.Forms.TextBox txtBox_Quantidade;
        private System.Windows.Forms.TextBox txtBox_ValorPagar;
        private System.Windows.Forms.CheckBox checkBox_Desconto;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Label lbl_Quantidade;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Nome;
        private System.Windows.Forms.Button btn_Iniciar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_ValorPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_xbox;
    }
}

