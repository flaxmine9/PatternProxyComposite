using System.Collections.Generic;
using System.Linq;

namespace PatternProxyComposite
{
    class GlobusStoreProxy : IGlobus
    {
        List<User> users { get; set; }
        GlobusStore globusStore { get; set; }

        public GlobusStoreProxy()
        {
            users = new List<User>() { new User() { Login = "globus", PassWord = "globus123" } };
        }

        public User Authenticate(string login, string password)
        {
            User user = users.FirstOrDefault(u => u.Login == login && u.PassWord == password);
            if(user == null)
            {
                if(globusStore == null)
                {
                    globusStore = new GlobusStore();
                }
                user = globusStore.Authenticate(login, password);
                users.Add(user);
            }
            return user;
        }

        public void Dispose()
        {
            if (globusStore != null)
            {
                globusStore.Dispose();
            }
        }
    }
}
