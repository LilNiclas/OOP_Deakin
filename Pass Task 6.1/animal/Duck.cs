using System;
namespace task_6_1
{
    class Duck : Bird
    {
        public double size
        {
            get; set;
        }
        public string kind
        {
            get; set;
        }

        public override string ToString()
        {
            return "A duck name " + base.name + " is a " + size + " inch" + kind;
        }
    }
}