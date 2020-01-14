using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilfabrik.Model.Steering
{
    class Brain
    {
        public int Capacity { get; set; }
        public int IQ { get; set; }

        public string ThinkOnGoingLeft(int degrees)
        {
            return string.Format("The Brain is thinking about going left by {0} degreees", degrees);
        }
        public string ThinkOnGoingRight(int degrees)
        {
            return string.Format("The Brain is thinking about going right by {0} degreees", degrees);
        }
        public string SaySomething(string whatToSay)
        {
            return string.Format("The Brain says: {0}", whatToSay);
        }
        public string ThinkAboutJumping(int numberOfJumbs)
        {
            return string.Format("The Brain is thinking about Jumping {0} times.", numberOfJumbs);
        }

        public override string ToString()
        {
            return "Brain";
        }

    }
}
