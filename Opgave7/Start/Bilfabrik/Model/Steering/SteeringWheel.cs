using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilfabrik.Model.Steering
{
    class SteeringWheel : ISteering
    {
        public string TurnRight(int degrees)
            => $"The SteeringWheel is turning right by {degrees} degrees";

        public string TurnLeft(int degrees)
            => $"The SteeringWheell is turning left by {degrees} degrees";

        public string SoundTheHorn()
            => "The horn is sounding loud and clear";

        public override string ToString()
            => "SteeringWheel";
    }
}
