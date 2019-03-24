// -----------------------------------------------------------------------
// <copyright file="ArmazemDeCaracteres.cs" company="LG lugar de gente">
//     Copyright © LG lugar de gente. All rights reserved.
//     TODOS OS DIREITOS RESERVADOS.
// </copyright>
// -----------------------------------------------------------------------


namespace MT.GeradorDeCaracteres.Geracao
{
    /// <summary>
    /// Representa os caracteres possíveis para geração.
    /// </summary>
    public static class ArmazemDeCaracteres
    {
        /// <summary>
        /// Obtém todos os caracteres disponíveis.
        /// </summary>
        /// <returns>Todos os caracteres disponíveis.</returns>
        public static string ObtenhaTodosOsCaracteres()
        {
            return
                ObtenhaCaracteresAlfabeticos() +
                ObtenhaCaracteresNumericos() +
                ObtenhaCaracteresEspeciais();
        }

        /// <summary>
        /// Obtém os caracteres alfabéticos.
        /// </summary>
        /// <returns>Os caracteres alfabéticos.</returns>
        public static string ObtenhaCaracteresAlfabeticos()
        {
            return "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        /// <summary>
        /// Obtém os caracteres numéricos.
        /// </summary>
        /// <returns>Os caracteres numéricos.</returns>
        public static string ObtenhaCaracteresNumericos()
        {
            return "0123456789";
        }

        /// <summary>
        /// Obtém os caracteres especiais.
        /// </summary>
        /// <returns>Os caracteres especiais.</returns>
        public static string ObtenhaCaracteresEspeciais()
        {
            return "!@#$%&*()[]{}/?<>;";
        }
    }
}
