using WebApplication16.Models.Interface;

namespace WebApplication16.Models.ElementModel
{
    public class Element : IElementState
    {
       string ElementName;
        public static int x = 0; 
        public int state()
        {
            return x;
        }
    }
}
