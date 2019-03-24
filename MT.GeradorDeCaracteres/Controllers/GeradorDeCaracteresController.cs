// -----------------------------------------------------------------------
// <copyright file="GeradorDeCaracteresController.cs" company="LG lugar de gente">
//     Copyright © LG lugar de gente. All rights reserved.
//     TODOS OS DIREITOS RESERVADOS.
// </copyright>
// -----------------------------------------------------------------------


using System.Collections.Generic;
using System.Linq;
using MT.GeradorDeCaracteres.Geracao;
using MT.GeradorDeCaracteres.Views;
namespace MT.GeradorDeCaracteres.Controllers
{
    /// <summary>
    /// Representa o controller da tela do Gerador de Caracteres.
    /// </summary>
    public class GeradorDeCaracteresController
    {
        private GeradorDeCaracteresView View;

        public GeradorDeCaracteresController(GeradorDeCaracteresView view)
        {
            this.View = view;
        }

        /// <summary>
        /// Gera os caracteres de acordo com os parâmetros.
        /// </summary>
        public void GereCaracteres()
        {
            if (this.ParametrosEstaoValidos(this.View.ObtenhaValorQuantidadeParaGeracao()))
            {
                var parametros = this.ObtenhaParametrosDaGeracao();
                var geradorDeCaracteres = new GeradorDeCaracteresAleatorios(parametros);
                var caracteresGerados = geradorDeCaracteres.GereCaracteresAleatorios();

                this.View.ObtenhaTextBoxResultadoGerado().Text = caracteresGerados;
            }
        }

        #region MÉTODOS PRIVADOS

        private ParametrosDaGeracao ObtenhaParametrosDaGeracao()
        {
            var parametrosDaGeracao = new ParametrosDaGeracao();
            parametrosDaGeracao.TipoDeCaracter = this.View.ObtenhaTipoDeCaracterParaGeracao();
            parametrosDaGeracao.QuantidadeCaracteres = int.Parse(this.View.ObtenhaValorQuantidadeParaGeracao());

            return parametrosDaGeracao;
        }

        private bool ParametrosEstaoValidos(string valorCampo)
        {
            int resultado = 0;

            bool tipoEstaValido = this.AlgumTipoDeCaracterFoiInformado(this.View.ObtenhaListaDeValoresDosTipos());
            bool quantidadeEstaValida = int.TryParse(valorCampo, out resultado);

            return tipoEstaValido && quantidadeEstaValida;
        }

        private bool AlgumTipoDeCaracterFoiInformado(List<bool> tiposDaTela)
        {
            return tiposDaTela.Any(x => x);
        }

        #endregion
    }
}
