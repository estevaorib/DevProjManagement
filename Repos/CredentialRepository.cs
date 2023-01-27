using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevProjectManagement
{
    public class CredentialRepository
    {
        public static Developer FindByEmail(string email)
        {
            try
            {
                using (Repository dbcontext = new Repository())
                {
                    return dbcontext.Developers
                        .Include("Credential")
                        .Where(c => c.Credential.Email == email)
                        .FirstOrDefault<Developer>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Developer Authenticate(string email, string password)
        {
            Developer d = FindByEmail(email);

            if (d != null)
            {
                string dbPassword = d.Credential.Password;
                password = Credential.ComputeSHA256(password, Credential.SALT);
                if (dbPassword == password)
                {
                    return d;
                }
            }
            return null;
            // MessageBox.Show("User not found!");
        }
    }
}
