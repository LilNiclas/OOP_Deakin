namespace Zoo
{
    public class ZooKeeper
    {
        public string name;

        public ZooKeeper(string _name)
        {
            name = _name;
        }

        public void Feed(Panda panda)
        {
            panda.Eat();
        }
    }
}