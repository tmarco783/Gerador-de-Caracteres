// -----------------------------------------------------------------------
// <copyright file="GeradorDeCaracteresAleatorios.cs" company="LG lugar de gente">
//     Copyright © LG lugar de gente. All rights reserved.
//     TODOS OS DIREITOS RESERVADOS.
// </copyright>
// -----------------------------------------------------------------------


using System;
using System.Linq;
using MT.GeradorDeCaracteres.Negocio.Enumeradores;
namespace MT.GeradorDeCaracteres.Geracao
{
    /// <summary>
    /// Representa o gerador de caracteres.
    /// </summary>
    public class GeradorDeCaracteresAleatorios
    {
        private ParametrosDaGeracao parametrosDaGeracao;

        /// <summary>
        /// O construtor da classe.
        /// </summary>
        /// <param name="parametros">Os parâmetros da geração.</param>
        public GeradorDeCaracteresAleatorios(ParametrosDaGeracao parametros)
        {
            this.parametrosDaGeracao = parametros;
        }

        /// <summary>
        /// Método responsável por gerar os caracteres aleatórios.
        /// </summary>
        /// <returns>Uma string com os caracteres aleatórios.</returns>
        public string GereCaracteresAleatorios()
        {
            var caracteresParaGeracao = this.ObtenhaCaracteresParaGeracao();
            var quantidadeDeCaracteres = parametrosDaGeracao.QuantidadeCaracteres;
            var random = new Random();

            var caracteresGerados = new string(
                Enumerable.Repeat(caracteresParaGeracao, quantidadeDeCaracteres)
                .Select(s => s[random.Next(s.Length)])
                .ToArray());

            return caracteresGerados;
        }

        #region MÉTODOS PRIVADOS

        private string ObtenhaCaracteresParaGeracao()
        {
            if (parametrosDaGeracao.TipoDeCaracter == EnumTipoDeCaracter.ALFABETICOS)
            {
                return ArmazemDeCaracteres.ObtenhaCaracteresAlfabeticos();
            }
            else if (parametrosDaGeracao.TipoDeCaracter == EnumTipoDeCaracter.ESPECIAIS)
            {
                return ArmazemDeCaracteres.ObtenhaCaracteresEspeciais();
            }
            else if (parametrosDaGeracao.TipoDeCaracter == EnumTipoDeCaracter.NUMERICOS)
            {
                return ArmazemDeCaracteres.ObtenhaCaracteresNumericos();
            }
            else if (parametrosDaGeracao.TipoDeCaracter == EnumTipoDeCaracter.TODOS)
            {
                return ArmazemDeCaracteres.ObtenhaTodosOsCaracteres();
            }

            return string.Empty;
        }

        #endregion
    }
}
