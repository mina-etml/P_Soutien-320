using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parachute
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Met la fenêtre de la console aux bonnes dimmensions
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

            Plane plane = new Plane();
            

            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();
               
                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();
                // Temporiser
                Thread.Sleep(100);
            }



        }

        static class Config
        {
            public const int SCREEN_HEIGHT = 40;
            public const int SCREEN_WIDTH = 150;
        }

        class Plane
        {
            private static int x = 0;

            private static string[] view =
            {
            @" _ ",
            @"| \ ",
            @"|  \       ______ ",
            @"--- \_____/ |_|_\___| ",
            @" \_______ --------- __>-} ",
            @"      \_____|_____/ | "
            };

            public static int X
            {
                get { return x; }
                set { x = value; }
            }

            public void draw()
            {
               for (int i = 0; i < view.Length; i++)
                {
                    Console.SetCursorPosition(x,i +2);
                    Console.WriteLine(view[i]);
                }
            }

            public void update()
            {
                if (x == Config.SCREEN_WIDTH - 1)
                {
                    x = 0;
                }
                else
                {
                    ++x;
                }
            }
        }

        class Para
        {
            private bool visible = false;
            private int x = 0;


            private string[] withoutParachute =
            {
                 @"     ",
                 @"     ",
                 @"     ",
                 @"  o  ",
                 @" /░\ ",
                 @" / \ ",
            };

            private string[] withParachute =
             {
                 @" ___ ",
                 @"/|||\",
                 @"\   /",
                 @" \o/ ",
                 @"  ░  ",
                 @" / \ ",
             };


            public void update()
            {
                x = Plane.X;



            }


        }



    }
}

