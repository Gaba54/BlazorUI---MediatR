using DemoLib.DataAccess;
using DemoLib.Models;
using DemoLib.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLib.Handlers
{

	//IRequest is for queries and commands 
	//IRequestHandler is to handle that, first what we have to handle, second what the output is going to be (optional )
	public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
	{
		private readonly IDataAccess _data;

		//dependency injection
		public GetPersonListHandler(IDataAccess data)
		{
			_data = data;
			
		}

		public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
		{
			return Task.FromResult(_data.GetPeople());
			//it will return in our handler
		}
	}
}
