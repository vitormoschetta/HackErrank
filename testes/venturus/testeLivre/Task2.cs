using System;

namespace testes.venturus.testeLivre
{
    /*
        Uma tarefa comum em um sistema corporativo é a definição de prazos para tarefas. Com base nos exemplos abaixo, construa uma função que determine qual é a data final de uma tarefa (Dias corridos).

        1. Data de ínicio:04/10/2020
            Dias para conclusão: 10 dias
            Prazo: 14/10/2020

        2. Data de ínicio:25/09/2020
            Dias para conclusão: 15 dias
            Prazo: 10/10/2020



        Observação: Use o formato dd/MM/yyyy para entrada e saída de datas da sua função.
    */

    public class Task2
    {
        string Date; int DaysToFinish;
        public Task2()
        {
            Date = "04/10/2020";
            DaysToFinish = 15;
        }

        public string GetDueDate()
        {
            if (string.IsNullOrEmpty(Date))
                return null;

            var initialDate = Convert.ToDateTime(Date);
            var finalDate = initialDate.AddDays(DaysToFinish);
            return finalDate.ToString("d");
        }
    }
}