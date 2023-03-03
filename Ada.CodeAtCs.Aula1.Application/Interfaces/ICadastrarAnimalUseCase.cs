using System;
using Ada.CodeAtCs.Aula1.Application.Inputs;
using Ada.CodeAtCs.Aula1.Core;

namespace Ada.CodeAtCs.Aula1.Application.Interfaces
{
	public interface ICadastrarAnimalUseCase
	{
        UseCaseOutput Execute(CadastrarAnimalInput input);
	}
}

