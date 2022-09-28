using System;

namespace ChainofResponsibility.handlers
{
    public abstract class Handler
    {

        private Handler _next;

        public Handler setNextHandler(Handler next)
        {
            _next = next;
            return next;
        }

        public abstract bool handle(string username, string password);

        protected bool handleNext(string username, string password)
        {
            if (_next == null)
            {
                return true;
            }
            return _next.handle(username, password);
        }

    }
}
