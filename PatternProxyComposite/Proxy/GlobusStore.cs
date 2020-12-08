using System.Linq;

namespace PatternProxyComposite
{
    class GlobusStore : IGlobus
    {
        GlobusContext globusContext;

        public GlobusStore()
        {
            globusContext = new GlobusContext();
        }

        public User Authenticate(string login, string password)
        {
            return globusContext.Users.FirstOrDefault(u => u.Login == login && u.PassWord == password);
        }

        public void Dispose()
        {
            globusContext.Dispose();
        }
    }
}
