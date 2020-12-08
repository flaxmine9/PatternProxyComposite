using System;

namespace PatternProxyComposite
{
    public interface IGlobus : IDisposable
    {
        User Authenticate(string login, string password);
    }
}
