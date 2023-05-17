using Microsoft.Net.Http.Headers;
using WebApplication16.Models.Interface;

namespace WebApplication16.Models.ElementModel
{
    public class ElementState
    {
         IElementState Element;
        public ElementState(IElementState Element) { 
        this.Element = Element ;}
        public  int GetState()
        {
            return Element.state();
        }

    }
}
