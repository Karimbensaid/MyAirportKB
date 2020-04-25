using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using KB.MyAirport.EF;

namespace KB.MyAirportGraphQL
{
    public class BagageType: ObjectGraphType<Bagage>
    {
        public BagageType()
        {
            Field(x => x.BagageID);
            Field(x => x.Classe);
            Field(x => x.CodeIata);
            //Field(x => x.DateCreation);
            Field(x => x.Destination);
            Field(x => x.Escale);
            //Field(x => x.Prioritaire);
            Field(x => x.Sta);
            Field(x => x.Ssur);
            //Field(x => x.VolID);
        }
    }
}
