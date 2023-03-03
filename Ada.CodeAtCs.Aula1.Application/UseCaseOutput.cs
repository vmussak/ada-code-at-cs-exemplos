using System;
using System.Net;

namespace Ada.CodeAtCs.Aula1.Application
{
	public class UseCaseOutput
	{
        public UseCaseOutput(List<string> errors)
        {
            Errors = errors;
            Code = HttpStatusCode.BadRequest;
        }

        public UseCaseOutput(object data)
        {
            Data = data;
            Code = HttpStatusCode.OK;
            Errors = new List<string>();
        }

        public UseCaseOutput()
		{
            Errors = new List<string>();
        }

        public List<string> Errors { get; set; }
        public object Data { get; set; }
        public HttpStatusCode Code { get; set; }
        public bool HasErrors => this.Errors.Any();
    }
}

