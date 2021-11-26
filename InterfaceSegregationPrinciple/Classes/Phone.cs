using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Classes
{
    internal class Phone : ICall, IPhoto, IVideo, IWeb
    {
        public void Call()
        {
            Console.WriteLine("Call");
        }
        public void TakePhoto()
        {
            Console.WriteLine("Taking pictures using a smartphone");
        }
        public void MakeVideo()
        {
            Console.WriteLine("Make Video");
        }
        public void BrowseInternet()
        {
            Console.WriteLine("Browse Internet");
        }
    }
}
