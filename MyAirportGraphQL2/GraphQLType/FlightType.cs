using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZW.MyAirport.EF;

namespace MyAirportGraphQL2.GraphQLType
{
    public class FlightType: ObjectGraphType<Flight>
    {
        public FlightType()
        {
            Field(x => x.IMM);
            Field(x => x.JEX);
            Field(x => x.LIG);
            Field(x => x.PAX);
            Field(x => x.PKG);
            Field(x => x.DHC);
            Field(x => x.DES);
            Field(x => x.FLIGHTID);
            Field(x => x.CIE);
    



        }
    }
}
