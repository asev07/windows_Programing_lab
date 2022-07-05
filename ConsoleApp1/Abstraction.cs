

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION

{
    abstract class IShape
    {
        public abstract float area();
        public abstract float perimeter();
    }
    public class rectangle : IShape
    {
        public float width { set; get };
        public float length { set; get };


        public override float area()
        {
            return length * width;
        }

        public override float perimeter()
        {
            return 2 * (length + width);
        }
    }

    public class Circle : IShape
    {
        public static readonly float pi = 3.14;

        public float radius { set; get };


        public override float area()
        {
            return pi * (radius * radius);
        }

        public override float perimeter()
        {
            return 2 * (pi * radius);
        }
    }
}







