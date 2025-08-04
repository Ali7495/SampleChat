using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Application.Common.DataTransferModels
{
    public class PasswordHasher
    {
        public static string HashPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);
        public static bool Verify(string password, string hash) => BCrypt.Net.BCrypt.Verify(password, hash);
    }
}
