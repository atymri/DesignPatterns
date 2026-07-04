namespace ProxyPattern
{
    /*
        Proxy Pattern (Structural)

        GoF Definition:
            Provide a surrogate or placeholder for another object to control access to it.

        Why it exists:
            Sometimes direct access to an object isn't desirable or possible - due to cost,
            location, or access-control concerns. Instead of changing the object itself or
            forcing every client to handle these concerns manually, you introduce a proxy:
            a stand-in that implements the same interface as the real object and sits
            between the client and it.

            The client only ever talks to the interface. It has no idea whether it's
            holding the real object or a proxy - and it shouldn't need to care. The proxy
            decides what happens before/after/instead of forwarding the call to the
            real subject.

        Common variants:
            - Virtual Proxy:      delays creation of an expensive object until it's
                                   actually needed (lazy initialization).
            - Protection Proxy:   checks permissions/roles before allowing access to
                                   the real object.
            - Remote Proxy:       represents an object that lives in a different
                                   process/machine, hiding network calls behind a
                                   normal-looking local interface.
            - Logging/Caching Proxy: adds cross-cutting behavior (logging calls,
                                   caching results) without touching the real object.

        Real World Example:
            A bank ATM doesn't talk to your account data directly - it talks to a proxy
            that represents your account on a remote banking server. The ATM interface
            looks the same regardless of where or how that data is actually stored.

        Computer World Example:
            Creating a heavy object (e.g. one that opens a large file, hits a database,
            or loads a large model into memory) on every request can be wasteful,
            especially if that object ends up unused in many code paths. A proxy can
            defer that creation until the first real call, and/or hand out lightweight
            stand-ins that all point to a single shared instance - reducing memory
            footprint and improving startup performance.

        Note:
            Proxy and the real subject share the same abstraction (interface/base class)
            on purpose. The proxy IS-A Subject, and it HAS-A (or creates on demand) the
            real ConcreteSubject. This is what allows the client to remain unaware of
            which one it's actually using.

        For simplicity, all related classes are kept in this single file - split them
        into separate files if preferred.
    */

    public abstract class Subject
    {
        public abstract void DoSomeWork();
    }

    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
            => Console.WriteLine($"doing some work, in {nameof(ConcreteSubject)}.{nameof(DoSomeWork)}");
    }

    // note that both ConcreteSubject and Proxy are using same abstract,
    // this is because proxy is a wrapper around subject, and the core functionality is for
    // ConcreteSubject and Proxy controls the access in here.
    public class Proxy(string user) : Subject
    {
        private string[] _allowedUsers = ["admin", "josh", "someone"];
        private ConcreteSubject _subject;
        public static object _obj = new object();
        public override void DoSomeWork()
        {
            if (!_allowedUsers.Contains(user))
            {
                Console.WriteLine($"sorry {user}, you dont have access.");
                return;
            }
            else
            {
                Console.WriteLine($"{user} is allowed , processing...");
                if(_subject is null)
                {
                    lock (_obj)
                    {
                        _subject ??= new ConcreteSubject();
                    }
                }
                _subject.DoSomeWork();
            }

        }
    }

    public class Program
    {
        public static void Main()
        {
            var proxy = new Proxy("adam");
            proxy.DoSomeWork();

            proxy = new Proxy("admin");
            proxy.DoSomeWork();
        }
    }
}