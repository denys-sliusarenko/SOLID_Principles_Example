using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Classes
{
    internal class Photograph
    {
        public void TakePhoto(IPhoto photoMaker)
        {
            photoMaker.TakePhoto();
        }
    }
}
