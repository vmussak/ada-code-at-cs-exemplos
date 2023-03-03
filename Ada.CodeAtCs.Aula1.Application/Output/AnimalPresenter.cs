using System;
using Ada.CodeAtCs.Aula1.Core;

namespace Ada.CodeAtCs.Aula1.Application.Output
{
	public class AnimalPresenter
	{
		public AnimalPresenter(Animal animal) 
		{
			this.Id = animal.Id;
			this.Nome = $"{animal.Especie} - {animal.Nome}";
		}

        public int Id { get; set; }
        public string Nome { get; set; }
        
    }
}

