using System;
using Ada.CodeAtCs.Aula1.Application.Inputs;
using Ada.CodeAtCs.Aula1.Application.Interfaces;
using Ada.CodeAtCs.Aula1.Application.Output;
using Ada.CodeAtCs.Aula1.Core;

namespace Ada.CodeAtCs.Aula1.Application.UseCases
{
	public class CadastrarAnimalUseCase : ICadastrarAnimalUseCase
    {
		public CadastrarAnimalUseCase()
		{
		}

        public UseCaseOutput Execute(CadastrarAnimalInput input)
        {
            var animal = new Animal
            (
                input.Id,
                input.Nome,
                input.Especie
            );

            if (!animal.IsValid)
            {
                return new UseCaseOutput(animal.Validations);
            }

            //chama o banco de dados

            var meuRetornoBonito = new AnimalPresenter(animal);
            return new UseCaseOutput(meuRetornoBonito);
        }
    }
}

