using App.Api.Graphql.GraphQLTypes;
using HotChocolate;
using HotChocolate.Types;
using Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Graphql.Mutation
{
    [ExtendObjectType(Name = "Mutation")]
    public class UserMutations
    {
        public string Authentication([Service] IUnitOfWork unitOfWork, LoginInput inputData)
        {
            var user = unitOfWork.User.Authenticate(inputData.Email, inputData.Password);
            if (user != null)
            {
                return unitOfWork.Token.CreateToken(user);
            }
            return "Invalid username";
        }
    }
}
