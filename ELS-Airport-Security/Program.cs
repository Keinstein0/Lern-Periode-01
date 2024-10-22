using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace _ELS__Airport_Security
{
    internal class Game
    {
        static void Main(string[] args)
        {

            Painter[] animations = {
                new Painter() {sourcefile = @"..\..\..\Animations\animation_01.csv"},
                new Painter() {sourcefile = @"..\..\..\Animations\animation_02.csv"},
                new Painter() {sourcefile = @"..\..\..\Animations\animation_03.csv"},
                new Painter() {sourcefile = @"..\..\..\Animations\animation_04.csv"}
            };

            Communicator com = new Communicator() { sourcefile = @"..\..\..\chatbot.py" };

            bool process = com.get_response("Apple"); //Feel Free to change the Item
                                                      //Depending on what item is entered the output might change
            animations[0].play_animation(300);

            if (process)
            {
                animations[1].play_animation(200);
                animations[3].play_animation(300);
            }
            else
            {
                animations[2].play_animation(200);
            }


        }
    }

}

