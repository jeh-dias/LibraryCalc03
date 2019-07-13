using LibraryCalc03.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc03
{
    /// <summary>
    /// Esta interface estabele o contrato para a implementação das 4 principais
    /// operações aritméticas
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Soma dos valores
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        int sum(PointTest point);

        /// <summary>
        /// Subtração dos valores
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        int subtraction(PointTest point);

        /// <summary>
        /// Multiplicação de Valores
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        int multiplication(PointTest point);

        /// <summary>
        /// Divisão de valores
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        double division(PointTest point);
    }
}
