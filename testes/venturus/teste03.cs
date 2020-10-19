using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace testes.venturus
{
    // Validar strings em uma lista:
    // Três primeiros caracteres devem ser Letras Maiúsculas
    // Próximos quatro caracteres correspondem ao Ano, que deve estar entre 1900 e 2019
    // O último caractere deve ser uma Letra Maiúscula.
    // Depois do Ano e antes do último caractere deve estar o valor da Nota.
    // Os valores válidos para a Nota são: 10, 20, 50, 100, 200, 500, 1000.
    public class teste03
    {
        List<string> serialNumber;
        public teste03()
        {
            serialNumber = new List<string>(){
                                                "XYZ200019Z",
                                                "ABB19991000Z"
                                            };
        }
        public int CheckString()
        {
            int valorTotal = 0;

            foreach (var item in serialNumber)
            {
                if (item.Length >= 10 && item.Length <= 12)
                {
                    int year = Convert.ToInt32(item.Substring(3, 4));
                    if (year >= 1900 && year <= 2019)
                    {
                        var tres = item.Substring(0, 3);
                        Regex regex = new Regex("^([A-Z]{3})$");
                        if (regex.IsMatch(tres))
                        {
                            var a = item.Substring(0, 1);
                            var b = item.Substring(1, 1);
                            var c = item.Substring(2, 1);

                            if (a != b && a != c && b != c)
                            {
                                var len = item.Length;
                                var ultimo = item.Substring(len - 1, 1);
                                Regex regex02 = new Regex("^([A-Z]{1})$");
                                if (regex02.IsMatch(ultimo))
                                {
                                    var tamanhoValor = len - 7 - 1;
                                    var valor = Convert.ToInt32(item.Substring(7, tamanhoValor));
                                    if (valor == 10 || valor == 20 || valor == 50 || valor == 100 || valor == 200 || valor == 500 || valor == 1000)
                                        valorTotal = valorTotal + valor;
                                }
                            }


                        }

                    }

                }
            }
            return valorTotal;
        }
    }
}