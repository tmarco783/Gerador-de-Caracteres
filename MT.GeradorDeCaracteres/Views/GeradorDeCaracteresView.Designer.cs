namespace MT.GeradorDeCaracteres.Views
{
    partial class GeradorDeCaracteresView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeradorDeCaracteresView));
            this.grbTipos = new System.Windows.Forms.GroupBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.lblQuantidadeASerGerada = new System.Windows.Forms.Label();
            this.rdbEspeciais = new System.Windows.Forms.RadioButton();
            this.rdbNumericos = new System.Windows.Forms.RadioButton();
            this.rdbAlfabeticos = new System.Windows.Forms.RadioButton();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.btnCopiarTexto = new System.Windows.Forms.Button();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblQuantGerada = new System.Windows.Forms.Label();
            this.txbResultadoGerado = new System.Windows.Forms.TextBox();
            this.grbTipos.SuspendLayout();
            this.grbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipos
            // 
            this.grbTipos.Controls.Add(this.txbQuantidade);
            this.grbTipos.Controls.Add(this.rdbTodos);
            this.grbTipos.Controls.Add(this.lblQuantidadeASerGerada);
            this.grbTipos.Controls.Add(this.rdbEspeciais);
            this.grbTipos.Controls.Add(this.rdbNumericos);
            this.grbTipos.Controls.Add(this.rdbAlfabeticos);
            this.grbTipos.Location = new System.Drawing.Point(12, 12);
            this.grbTipos.Name = "grbTipos";
            this.grbTipos.Size = new System.Drawing.Size(132, 155);
            this.grbTipos.TabIndex = 0;
            this.grbTipos.TabStop = false;
            this.grbTipos.Text = "Parâmetros";
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(72, 125);
            this.txbQuantidade.MaxLength = 4;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(52, 20);
            this.txbQuantidade.TabIndex = 1;
            this.txbQuantidade.TextChanged += new System.EventHandler(this.EventoTextoAlteradoTextBoxQuantidade);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(6, 90);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 3;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.EventoRadioButtonTodosMarcado);
            // 
            // lblQuantidadeASerGerada
            // 
            this.lblQuantidadeASerGerada.AutoSize = true;
            this.lblQuantidadeASerGerada.Location = new System.Drawing.Point(6, 128);
            this.lblQuantidadeASerGerada.Name = "lblQuantidadeASerGerada";
            this.lblQuantidadeASerGerada.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidadeASerGerada.TabIndex = 0;
            this.lblQuantidadeASerGerada.Text = "Quantidade";
            // 
            // rdbEspeciais
            // 
            this.rdbEspeciais.AutoSize = true;
            this.rdbEspeciais.Location = new System.Drawing.Point(6, 67);
            this.rdbEspeciais.Name = "rdbEspeciais";
            this.rdbEspeciais.Size = new System.Drawing.Size(70, 17);
            this.rdbEspeciais.TabIndex = 2;
            this.rdbEspeciais.TabStop = true;
            this.rdbEspeciais.Text = "Especiais";
            this.rdbEspeciais.UseVisualStyleBackColor = true;
            this.rdbEspeciais.CheckedChanged += new System.EventHandler(this.EventoRadioButtonEspeciaisMarcado);
            // 
            // rdbNumericos
            // 
            this.rdbNumericos.AutoSize = true;
            this.rdbNumericos.Location = new System.Drawing.Point(6, 44);
            this.rdbNumericos.Name = "rdbNumericos";
            this.rdbNumericos.Size = new System.Drawing.Size(75, 17);
            this.rdbNumericos.TabIndex = 1;
            this.rdbNumericos.TabStop = true;
            this.rdbNumericos.Text = "Numéricos";
            this.rdbNumericos.UseVisualStyleBackColor = true;
            this.rdbNumericos.CheckedChanged += new System.EventHandler(this.EventoRadioButtonNumericosMarcado);
            // 
            // rdbAlfabeticos
            // 
            this.rdbAlfabeticos.AutoSize = true;
            this.rdbAlfabeticos.Location = new System.Drawing.Point(6, 19);
            this.rdbAlfabeticos.Name = "rdbAlfabeticos";
            this.rdbAlfabeticos.Size = new System.Drawing.Size(77, 17);
            this.rdbAlfabeticos.TabIndex = 0;
            this.rdbAlfabeticos.TabStop = true;
            this.rdbAlfabeticos.Text = "Alfabéticos";
            this.rdbAlfabeticos.UseVisualStyleBackColor = true;
            this.rdbAlfabeticos.CheckedChanged += new System.EventHandler(this.EventoRadioButtonAlfabeticosMarcado);
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.btnCopiarTexto);
            this.grbResultado.Controls.Add(this.btnLimparCampos);
            this.grbResultado.Controls.Add(this.lblQuantidade);
            this.grbResultado.Controls.Add(this.lblQuantGerada);
            this.grbResultado.Controls.Add(this.txbResultadoGerado);
            this.grbResultado.Location = new System.Drawing.Point(150, 13);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(204, 155);
            this.grbResultado.TabIndex = 2;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultado";
            // 
            // btnCopiarTexto
            // 
            this.btnCopiarTexto.Location = new System.Drawing.Point(19, 120);
            this.btnCopiarTexto.Name = "btnCopiarTexto";
            this.btnCopiarTexto.Size = new System.Drawing.Size(75, 26);
            this.btnCopiarTexto.TabIndex = 5;
            this.btnCopiarTexto.Text = "Copiar Texto";
            this.btnCopiarTexto.UseVisualStyleBackColor = true;
            this.btnCopiarTexto.Click += new System.EventHandler(this.EventoCliqueBotaoCopiarTexto);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Location = new System.Drawing.Point(100, 120);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(87, 26);
            this.btnLimparCampos.TabIndex = 4;
            this.btnLimparCampos.Text = "Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.EventoCliqueBotaoLimparCampos);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(102, 21);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(46, 13);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "lblQuant";
            this.lblQuantidade.Visible = false;
            // 
            // lblQuantGerada
            // 
            this.lblQuantGerada.AutoSize = true;
            this.lblQuantGerada.Location = new System.Drawing.Point(6, 21);
            this.lblQuantGerada.Name = "lblQuantGerada";
            this.lblQuantGerada.Size = new System.Drawing.Size(101, 13);
            this.lblQuantGerada.TabIndex = 1;
            this.lblQuantGerada.Text = "Quantidade gerada:";
            // 
            // txbResultadoGerado
            // 
            this.txbResultadoGerado.BackColor = System.Drawing.Color.LemonChiffon;
            this.txbResultadoGerado.Location = new System.Drawing.Point(9, 37);
            this.txbResultadoGerado.Multiline = true;
            this.txbResultadoGerado.Name = "txbResultadoGerado";
            this.txbResultadoGerado.ReadOnly = true;
            this.txbResultadoGerado.Size = new System.Drawing.Size(192, 77);
            this.txbResultadoGerado.TabIndex = 0;
            this.txbResultadoGerado.TextChanged += new System.EventHandler(this.EventoTextoAlteradoTextBoxResultadoGerado);
            // 
            // GeradorDeCaracteresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 181);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.grbTipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GeradorDeCaracteresView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Caracteres";
            this.grbTipos.ResumeLayout(false);
            this.grbTipos.PerformLayout();
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipos;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbEspeciais;
        private System.Windows.Forms.RadioButton rdbNumericos;
        private System.Windows.Forms.RadioButton rdbAlfabeticos;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Label lblQuantidadeASerGerada;
        private System.Windows.Forms.GroupBox grbResultado;
        private System.Windows.Forms.TextBox txbResultadoGerado;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblQuantGerada;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Button btnCopiarTexto;
    }
}