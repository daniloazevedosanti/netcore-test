using Api.Model;
using Api.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Implementations
{
    public class UserRepositoryImpl : IUserRepository
    {
        private readonly Context _context;

        public UserRepositoryImpl(Context context)
        {
            _context = context;
        }

        public User FindByLogin(string login)
        {
            return _context.Usuarios.SingleOrDefault(u => u.Login.Equals(login));
        }
    }
}
