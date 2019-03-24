using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MT.GeradorDeCaracteres.Controllers;
using MT.GeradorDeCaracteres.Negocio.Enumeradores;

namespace MT.GeradorDeCaracteres.Views
{
    /// <summary>
    /// Representa a tela principal do gerador de caracteres.
    /// </summary>
    public partial class GeradorDeCaracteresView : Form
    {
        private GeradorDeCaracteresController Controller;
        private const int TECLA_ENTER = 13;

        /// <summary>
        /// O construtor da classe.
        /// </summary>
        public GeradorDeCaracteresView()
        {
            InitializeComponent();

            this.Controller = new GeradorDeCaracteresController(this);
        }

        /// <summary>
        /// Obtém o tipo de caracter para geração.
        /// </summary>
        /// <returns>O tipo de caracter.</returns>
        public EnumTipoDeCaracter ObtenhaTipoDeCaracterParaGeracao()
        {
            if (this.rdbAlfabeticos.Checked)
            {
                return EnumTipoDeCaracter.ALFABETICOS;
            }
            else if (this.rdbEspeciais.Checked)
            {
                return EnumTipoDeCaracter.ESPECIAIS;
            }
            else if (this.rdbNumericos.Checked)
            {
                return EnumTipoDeCaracter.NUMERICOS;
            }
            else if (this.rdbTodos.Checked)
            {
                return EnumTipoDeCaracter.TODOS;
            }

            return 0;
        }

        /// <summary>
        /// Obtém a quantidade de caracteres para geração.
        /// </summary>
        /// <returns>A quantidade de caracter.</returns>
        public string ObtenhaValorQuantidadeParaGeracao()
        {
            return this.txbQuantidade.Text;
        }

        /// <summary>
        /// Obtém a textBox do resultado gerado.
        /// </summary>
        /// <returns>A textBox do resultado gerado.</returns>
        public TextBox ObtenhaTextBoxResultadoGerado()
        {
            return this.txbResultadoGerado;
        }

        /// <summary>
        /// Obtém a lista de valores dos tipos.
        /// </summary>
        /// <returns>A lista de valores dos tipos.</returns>
        public List<bool> ObtenhaListaDeValoresDosTipos()
        {
            var listaDeValores = new List<bool>();

            listaDeValores.Add(this.rdbAlfabeticos.Checked);
            listaDeValores.Add(this.rdbEspeciais.Checked);
            listaDeValores.Add(this.rdbNumericos.Checked);
            listaDeValores.Add(this.rdbTodos.Checked);

            return listaDeValores;
        }

        #region MÉTODOS PRIVADOS

        #region EVENTOS

        /// <summary>
        /// O evento de clique do botão "Copiar Texto".
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoCliqueBotaoCopiarTexto(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txbResultadoGerado.Text))
            {
                Clipboard.SetText(this.txbResultadoGerado.Text);
            }
        }

        /// <summary>
        /// Ao clicar no botão "Limpar Campos" a aplicação
        /// irá limpar todos os campos preenchidos da tela.
        /// </summary>
        /// <param name="sender">O disparador do evento.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoCliqueBotaoLimparCampos(object sender, EventArgs e)
        {
            this.LimpeCamposDaTela();
        }

        /// <summary>
        /// Quando o texto do resultado gerado for alterado
        /// a aplicação informará a quantidade gerada.
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoTextoAlteradoTextBoxResultadoGerado(object sender, EventArgs e)
        {
            this.lblQuantidade.Text = this.txbResultadoGerado.TextLength.ToString();
            this.lblQuantidade.Visible = true;
        }

        /// <summary>
        /// O evento de marcado do radioButton Alfabéticos.
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoRadioButtonAlfabeticosMarcado(object sender, EventArgs e)
        {
            this.ExecuteGerarCaracteres();
        }

        /// <summary>
        /// O evento de marcado do radioButton Especiais.
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoRadioButtonEspeciaisMarcado(object sender, EventArgs e)
        {
            this.ExecuteGerarCaracteres();
        }

        /// <summary>
        /// O evento de marcado do radioButton Numéricos.
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoRadioButtonNumericosMarcado(object sender, EventArgs e)
        {
            this.ExecuteGerarCaracteres();
        }

        /// <summary>
        /// O evento de marcado do radioButton Todos.
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoRadioButtonTodosMarcado(object sender, EventArgs e)
        {
            this.ExecuteGerarCaracteres();
        }

        /// <summary>
        /// O evento de texto alterado da textBox Quantidade.
        /// </summary>
        /// <param name="sender">O disparador.</param>
        /// <param name="e">Os argumentos.</param>
        private void EventoTextoAlteradoTextBoxQuantidade(object sender, EventArgs e)
        {
            if (txbQuantidade.Text == string.Empty)
            {
                lblQuantidade.Text = string.Empty;
                txbResultadoGerado.Text = string.Empty;
            }

            this.ExecuteGerarCaracteres();
        }

        #endregion

        private void LimpeCamposDaTela()
        {
            this.DesmarqueRadioButtons();

            this.txbQuantidade.Text = string.Empty;
            this.txbResultadoGerado.Text = string.Empty;
            this.lblQuantidade.Text = string.Empty;
        }

        private void DesmarqueRadioButtons()
        {
            this.rdbAlfabeticos.Checked = false;
            this.rdbEspeciais.Checked = false;
            this.rdbNumericos.Checked = false;
            this.rdbTodos.Checked = false;
        }

        private void ExecuteGerarCaracteres()
        {
            if (!string.IsNullOrEmpty(this.txbQuantidade.Text))
            {
                this.Controller.GereCaracteres();
            }
        }

        #endregion
    }
}
