using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Linq.Expressions;
using static System.Console;
namespace Engine.Engine
{

    class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }

    public abstract class Engine
    {
        private Vector ScreenSize = new Vector(512, 512);
        private string Title = "Toy*";
        private Canvas Window = null;
        private Thread GameLoopThread = null;

        private static List<Shape> AllShapes = new List<Shape>();

        public Color BackgroundColor = Color.White;

        public Engine(Vector screenSize, string title)
        {
            this.ScreenSize = screenSize;
            this.Title = title;

            Window = new Canvas();
            Window.Size = new Size((int)this.ScreenSize.x, (int)this.ScreenSize.y);
            Window.Text = this.Title;
            Window.Paint += Renderer;



            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Window);
        }

        void GameLoop()
        {
            On_Load();
            while (GameLoopThread.IsAlive)
            {

                try
                {
                    On_Draw();
                    Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); });
                    On_Update();
                    Thread.Sleep(1);
                }
                catch
                {
                    WriteLine("Loading...");
                }

            }


        }


        public static void RegisterShape(Shape shape)
        {
            AllShapes.Add(shape);
        }

        public static void UnregisterShape(Shape shape)
        {
            AllShapes.Remove(shape);
        }
        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(BackgroundColor);

            foreach (Shape shape in AllShapes)
            {
                g.FillRectangle
                    (
                    new SolidBrush(Color.DarkGray),
                    shape.position.x, shape.position.y,
                    shape.scale.x, shape.scale.y
                    );
            }
        }

        public abstract void On_Draw();
        public abstract void On_Load();

        public abstract void On_Update();

    }

}