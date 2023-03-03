using System;
using Microsoft.AspNetCore.Mvc;

namespace Ada.CodeAtCs.Aula1
{
	public class TesteParametros
	{
		public TesteParametros()
		{
			
		}

		[FromQuery(Name = "id")]
        public int Id { get; set; }

		[FromHeader(Name = "t1")]
        public int Teste1 { get; set; }

		[FromRoute(Name = "t2")]
        public int Teste2 { get; set; }

		
    }
}

