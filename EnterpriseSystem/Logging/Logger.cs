namespace EnterpriseSystem.Logging
{
    public class Logger
    {
        public event Action<string, string> Notify;
        private void OnNotify(string message, string filepath)
        {
            Notify.Invoke(message, filepath);
        }

        private static Logger? _self;
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (_self != null) return _self;
                return _self = new Logger();
            }
        }

        public void Log(string message, string filepath)
        {
            OnNotify(message, filepath);
        }
    }
}
