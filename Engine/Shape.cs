using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Engine
{
    public class Shape
    {
        public Vector position = null;
        public Vector scale = null;
        public string Tag = "";

        public Shape(Vector position, Vector scale, string Tag)
        {
            this.position = position;
            this.scale = scale;
            this.Tag = Tag;

            Engine.RegisterShape(this);
        }

        public void DestroySelf()
        {
            Engine.UnregisterShape(this);
        }
    }
}