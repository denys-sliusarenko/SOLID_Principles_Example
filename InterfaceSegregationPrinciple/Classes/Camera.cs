using InterfaceSegregationPrinciple.Interfaces;

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
