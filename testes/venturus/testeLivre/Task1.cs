using System;
using System.Text.RegularExpressions;

namespace testes.venturus.testeLivre
{
    /*
        Considere a seguinte regra para a criação de um identificador de uma entidade em um sistema coorporativo:
        1. 3 letras maiúsculas entre A e D;
        2. 4 dígitos do ano(entre 1999 e 2035);
        3. Número sequencial com 4 dígitos

        Exemplos de strings geradas corretamente: 
        1. ABC20190020
        2. BFC20350001
        3. BBB19990200

        Construa uma função que receba uma string e valide se ela está no formato esperado.
    */
    public class Task1
    {
        string Input;
        public Task1()
        {
            Input = "ABC20190020";
        }
        public Boolean CheckString(string Input)
        {
            if (Input.Length != 11)
                return false;

            int year = Convert.ToInt32(Input.Substring(3, 4));
            if (year < 1999 || year > 2035)
                return false;

            Regex regex = new Regex(@"^[A-D]{3}[1|2][0|9][0-3|9][0-5|9]\d{4}$");
            return regex.IsMatch(Input);
        }

    }
}