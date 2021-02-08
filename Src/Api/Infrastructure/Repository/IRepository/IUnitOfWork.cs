using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ITokenService Token { get; }
        IUserRepository User { get; }
    }
}
