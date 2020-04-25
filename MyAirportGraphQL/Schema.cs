using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

namespace KB.MyAirportGraphQL
{
    public class AirportSchema: Schema
    {
        public AirportSchema(IDependencyResolver  resolver): base(resolver)
        {
            Query = resolver.Resolve<MyAirportQuery>();
        }
    }
}
