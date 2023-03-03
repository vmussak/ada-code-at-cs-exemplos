using System;
namespace Ada.CodeAtCs.Aula1.Core
{
	public class Animal
	{
		public Animal(int id, string nome, string especie)
		{
			Validations = new List<string>(2);

            this.Id = id;
			this.Nome = nome;
			this.Especie = especie;

			this.Validate();
		}

		public int Id { get; private set; }
		public string Nome { get; private set; }
		public string Especie { get; private set; }

		public List<string> Validations { get; }
		public bool IsValid { get; set; }

		private void Validate()
		{
			if(this.Id <= 0)
			{
                Validations.Add("O Id não pode ser <= 0");
			}

			if (string.IsNullOrWhiteSpace(this.Especie))
			{
                Validations.Add("Preencha a espécie");
            }

			this.IsValid = !Validations.Any();
		}
	}
}