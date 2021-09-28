using System;
namespace API.Models
{

    public class Pessoa 
    {       

            //Construtor
            public Pessoa() => CriadoEm = DateTime.Now;

            public int Id{ get; set; }
 
            public string Nome {get; set;}

            public double Cpf {get; set;}

            public string Descricao { get; set;}

            public DateTime CriadoEm { get; set; }

            public override string ToString()
            {
                return $"Nome: {Nome} | Cpf: {Cpf.ToString("c2")} | Criado em:{ CriadoEm}";

            } 

    }
}