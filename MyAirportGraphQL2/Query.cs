using GraphQL.Types;
using MyAirportGraphQL2.GraphQLType;
using System.Linq;
using ZW.MyAirport.EF;

namespace MyAirport.GraphQL
{
    public class AirportQuery: ObjectGraphType
    {
        public AirportQuery(MyAirportContext db)
        {
            Field<ListGraphType<LuggageType>>(
                "luggages",
                resolve: context => db.Luggages.ToList());

        }

    }
}
