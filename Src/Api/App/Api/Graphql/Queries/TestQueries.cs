using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Graphql.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class TestQueries
    {
        public string GetTest()
        {
            return "Query Working";
        }
    }
}
