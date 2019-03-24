// -----------------------------------------------------------------------
// <copyright file="ParametrosDaGeracao.cs" company="LG lugar de gente">
//     Copyright © LG lugar de gente. All rights reserved.
//     TODOS OS DIREITOS RESERVADOS.
// </copyright>
// -----------------------------------------------------------------------

using MT.GeradorDeCaracteres.Negocio.Enumeradores;

namespace MT.GeradorDeCaracteres.Geracao
{
    /// <summary>
    /// Representa os parâmetros da geração.
    /// </summary>
    public class ParametrosDaGeracao
    {
        /// <summary>
        /// O dicionário de tipos de caracteres.
        /// </summary>
        public EnumTipoDeCaracter TipoDeCaracter { get; set; }

        /// <summary>
        /// A quantidade de caracteres a serem gerados.
        /// </summary>
        public int QuantidadeCaracteres { get; set; }

        /// <summary>
        /// O construtor da classe.
        /// </summary>
        public ParametrosDaGeracao()
        {
        }
    }
}
