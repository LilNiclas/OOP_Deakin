namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Panda p = new Panda("Yo", 200, 6);
            p.TellAbout();

            ZooKeeper zk = new ZooKeeper("Champ");
            zk.Feed(p);
        }
    }
}

