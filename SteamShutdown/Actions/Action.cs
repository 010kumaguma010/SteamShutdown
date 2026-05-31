namespace SteamShutdown.Actions
{
    public abstract class Action
    {
        public abstract string Name { get; protected set; }

        public virtual void Execute()
        {
            SteamShutdown.Log("Execute action: " + Name);
        }

        public override string ToString()
        {
            return Name;
        }

        private static readonly Action[] _allActions = new Action[] { new Shutdown(), new Hibernation(), new Sleep() };
        public static Action[] GetAllActions => _allActions;
    }
}
