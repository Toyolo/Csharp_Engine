using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Engine.Engine
{
    public class Vector
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public override string ToString()
        {
            return x.ToString() + y.ToString();
        }

        public Vector(float x_, float y_)
        {
            x = x_;
            y = y_;

        }

        public Vector(Vector other)
        {
            x = other.x;
            y = other.y;
        }

        virtual public void Zero()
        {
            x = 0;
            y = 0;
        }
        virtual public void v_add(Vector other)
        {
            x = x + other.x;
            y = y + other.y;
        }

        virtual public void v_sub(Vector other)
        {
            x = x - other.x;
            y = y - other.y;
        }

        virtual public void v_mult(float n)
        {
            x = x * n;
            y = y * n;
        }

        virtual public void v_div(float n)
        {
            x = x / n;
            y = y / n;
        }

        virtual public float v_mag()
        {
            return (float)Sqrt(x * x + y * y);
        }

        virtual public void v_normalize()
        {
            float m = v_mag();
            if (m != 0)
            {
                v_div(m);
            }
        }


    }
}