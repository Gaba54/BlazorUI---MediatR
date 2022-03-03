using DemoLib.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Queries
{
	//records are almost read only, because you can do both, but you shouldnt
	 public record GetPersonListQuery() : IRequest<List<PersonModel>>;
	//record which returns list of people 

	//public class GetPersonListQueryClass : IRequest<List<PersonModel>>
	//{

	//}
}
