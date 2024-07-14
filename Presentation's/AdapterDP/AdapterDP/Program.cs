namespace AdapterDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
        }
        public class Target
        {
            public virtual void Request()
            {
                Console.WriteLine("Targer Request Method");
            }
        }
        public class Adapter : Target
        {
            private Adaptee adaptee = new Adaptee();
            public override void Request()
            {
                adaptee.SpecialRequest();
            }
        }
        public class Adaptee
        {
            public void SpecialRequest()
            {
                Console.WriteLine("Adaptee Request Method");
            }
        }
    }
}
