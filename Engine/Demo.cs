using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Engine.Engine;
using System.Drawing;
using static System.Console;

namespace Engine
{
    class DemoGame : Engine.Engine
    {
        Shape player;
        public DemoGame() : base(new Vector(615, 515), "Toy*") { }


        public override void On_Draw()
        {
            BackgroundColor = Color.Gray;

        }
        public override void On_Load()
        {
            player = new Shape(new Vector(10, 10), new Vector(10, 10), "v/");

        }

        int frames = 0;
        float speed = 0.1f;
        public override void On_Update()
        {
            WriteLine($"frames: {frames}");
            player.position.x += speed;
            frames++;
        }
    }
}