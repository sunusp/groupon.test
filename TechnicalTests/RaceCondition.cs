namespace TechnicalTests
{
    public class RaceCondition
    {
        private readonly ISessionManager _sessionManager;

        public RaceCondition(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public void UpdateSession(string sessionKey)
        {
            lock (sessionKey)
            {
                var session = _sessionManager.Get(sessionKey);
                session.Count += 1;
                _sessionManager.Set(session);
            }
        }
    }
}
