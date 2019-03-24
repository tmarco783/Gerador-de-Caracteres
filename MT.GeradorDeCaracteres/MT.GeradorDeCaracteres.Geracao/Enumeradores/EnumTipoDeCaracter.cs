// -----------------------------------------------------------------------
// <copyright file="EnumTipoDeCaracter.cs" company="LG lugar de gente">
//     Copyright © LG lugar de gente. All rights reserved.
//     TODOS OS DIREITOS RESERVADOS.
// </copyright>
// -----------------------------------------------------------------------

namespace MT.GeradorDeCaracteres.Negocio.Enumeradores
{
    /// <summary>
    /// Representa o enumerador do tipo de caracteres.
    /// </summary>
    public enum EnumTipoDeCaracter
    {
        /// <summary>
        /// Os caracteres alfabéticos.
        /// </summary>
        ALFABETICOS = 1,

        /// <summary>
        /// Os caracteres numéricos.
        /// </summary>
        NUMERICOS = 2,

        /// <summary>
        /// Os caracteres especiais.
        /// </summary>
        ESPECIAIS = 3,

        /// <summary>
        /// Todos os caracteres juntos.
        /// </summary>
        TODOS = 4
    }
}
