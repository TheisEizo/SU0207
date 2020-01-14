using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilfabrik.Model.Steering
{
    class SteeringWheel
    {
        public string TurnRight(int degrees)
        {
            return string.Format("The SteeringWheel is turning right by {0} degrees", degrees);
        }

        public string TurnLeft(int degrees)
        {
            return string.Format("The SteeringWheel is turning left by {0} degrees", degrees);
        }

        public string SoundTheHorn()
        {
            return "The horn is sounding loud and clear";
        }

        public override string ToString()
        {
            return "SteeringWheel";
        }
    }
}
