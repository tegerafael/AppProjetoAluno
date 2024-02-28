﻿namespace AppProjetoAluno.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Media { get; set; }
        public string? Situacao { get; set; }

        public void CalcularMedia()
        {
            Situacao = "REPROVADO(A)";
            Media = (Nota1 + Nota2) / 2;
            if (Media >= 60)
            {
                Situacao = "APROVADO(A)";
            }
        }
    }
}
