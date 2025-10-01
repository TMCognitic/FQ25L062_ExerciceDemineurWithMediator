namespace FQ25L062_ExerciceDemineur.Tools
{
    public class Mediator<TMessage>
        where TMessage : IMessage
    {
        public static readonly Mediator<TMessage> Instance = new Mediator<TMessage>();

        private Mediator()
        {            
        }

        public int ActionCount => _clients?.GetInvocationList().Length ?? 0;

        private Action<TMessage>? _clients;

        public void Register(Action<TMessage> action)
        {
            _clients += action;
        }

        public void Unregister(Action<TMessage> action)
        {
            _clients -= action;
        }

        public void Send(TMessage message)
        {
            _clients?.Invoke(message);
        }

        public void Send(TMessage message, Func<Action<TMessage>, bool> predicate)
        {
            if(_clients is null)
            {
                return;
            }

            IEnumerable<Action<TMessage>> actionsToCall = _clients.GetInvocationList().Cast<Action<TMessage>>().Where(predicate).ToList();

            foreach (Action<TMessage> action in actionsToCall)
            {
                Console.WriteLine(action.Target);
                action.Invoke(message);
            }
        }
    }
}
