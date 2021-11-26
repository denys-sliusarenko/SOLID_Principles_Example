using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Classes
{
    internal class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking pictures with a camera");
        }
    }
}
