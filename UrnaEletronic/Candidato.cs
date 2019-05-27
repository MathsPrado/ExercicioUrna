using System;
using System.Collections.Generic;
using System.Text;

namespace UrnaEletronic
{
     class Candidato : Pessoa
    {
      
        public string Partido { get; set; }
        public int NumeroVotos { get; set; }
        public int Numero { get; set; }
        public Candidato(string partido, int numeroVotos, int numero, string nome, int id)
        {
            Partido = partido;
            NumeroVotos = numeroVotos;
            Numero = numero;
            Nome = nome;
            Id = id;
        }

      
        public override string ToString()
        {
            return Id + "," + " Candidato:" + Nome + ", Partido:" + Partido; 
        }

        public override void Voto()
        {
            this.NumeroVotos++;
        }
    }
}
