using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using KB.MyAirport.EF;

namespace KB.MyAirportGraphQL
{
    public class VolType : ObjectGraphType<Vol>
    {
        public VolType()
        {
            Field(x => x.VoldID);
            Field(x => x.Cie);
            Field(x => x.Lig);
            Field(x => x.Dhc);
            Field(x => x.Pkg);
            Field(x => x.Imm);
            Field(x => x.Pax);
            Field(x => x.Des);
            Field(x => x.Bagages);
        }
    }
}
