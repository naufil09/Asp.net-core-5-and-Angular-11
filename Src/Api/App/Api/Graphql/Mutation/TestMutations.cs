using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Graphql.Mutation
{
    [ExtendObjectType(Name = "Mutation")]
    public class TestMutations
    {
        public string SaveTest()
        {
            return "Mutation Working";
        }
    }
}
