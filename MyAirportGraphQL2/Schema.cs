using GraphQL.Types;
using GraphQL;
using MyAirport.GraphQL;
//using System.Web.Mvc;

namespace MyAirport.GraphQL
{
    public class AirportSchema: Schema
    {
        public AirportSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AirportQuery>();
        }
    }
}
