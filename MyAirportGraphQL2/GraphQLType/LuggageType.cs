using System;
using GraphQL.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZW.MyAirport.EF;

namespace MyAirportGraphQL2.GraphQLType
{
    public class LuggageType: ObjectGraphType<Luggage>
    {
        public LuggageType()
        {
            Field(x => x.LUGGAGEID);
            Field(x => x.CLASSE);
            Field(x => x.CODE_IATA);
            Field(x => x.DATE_CREATION);
            Field(x => x.DESTINATION);
            Field(x => x.ESCALE);
            Field(x => x.PRIORITAIRE);
            //Field(x => x.FLIGHTID);
            Field(x => x.STA);
            Field(x => x.SSUR);



        }
    }
}
