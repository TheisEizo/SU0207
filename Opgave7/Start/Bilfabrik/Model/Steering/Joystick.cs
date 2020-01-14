using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilfabrik.Model.Steering
{
    class Joystick
    {
        public string MoveRight(int degrees)
        {
            return string.Format("The joystick is held right by {0} degrees" ,degrees);
        }

        public string MoveLeft(int degrees)
        {
            return string.Format("The joystick is held left by {0} degrees",  degrees);
        }

        public string MoveForward(int degrees)
        {
            return string.Format("The joystick is held forward by {0} degrees", degrees);
        }

        public string MoveBack(int degrees)
        {
            return string.Format("The joystick is held back by {0} degrees", degrees);
        }

        public string PressButton(int buttonNumberToPress)
        {
            return string.Format("Button {0} is pressed on the joystick", buttonNumberToPress);

        }

        public override string ToString()
        {
            return "JoyStick";
        }

    }
}
