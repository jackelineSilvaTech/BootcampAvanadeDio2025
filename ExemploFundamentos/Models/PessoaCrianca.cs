using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_AVANADE___.Net___IA___2025.Models // organização de classes. caminho virtual.
{
    public class PessoaCrianca // nome da minha classe
    {
        public string Nome { get; set; } // get para pegar valor e set para atribuir o valor
        public int Idade { get; set; }

        public void Apresentar() // método ou função - ações que  minha classe  vai representar.

        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho  {Idade} anos");
        }
    }
}