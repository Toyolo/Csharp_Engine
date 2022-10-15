using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Engine.Engine
{
    public class Vector3 : Vector
    {
        public override string ToString()
        {
            return x.ToString() + y.ToString() + z.ToString();
        }

        public Vector3(float x_, float y_, float z_) : base(x_, y_)
        {
            this.x = x_;
            this.y = y_;
            this.z = z_;
        }


        public Vector3(Vector3 other) : base(other)
        {
            this.x = other.x;
            this.y = other.y;
            this.z = other.z;
        }

        public override void Zero()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public override void v_add(Vector other)
        {
            x = this.x + other.x;
            y = this.y + other.y;
            z = this.z + other.z;
        }

        public override void v_sub(Vector other)
        {
            x = this.x - other.x;
            y = this.y - other.y;
            z = this.z - other.z;
        }

        public override void v_mult(float n)
        {
            x = this.x * n;
            y = this.y * n;
            z = this.z * n;
        }

        public override void v_div(float n)
        {
            x = this.x / n;
            y = this.y / n;
            z = this.z / n;
        }

        public override float v_mag()
        {
            return (float)Sqrt(x * x + y * y);
        }

        public override void v_normalize()
        {
            float m = v_mag();
            if (m != 0)
            {
                v_div(m);
            }
        }


    }
}