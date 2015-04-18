using System.Web.UI.WebControls;
using Nancy;

namespace TePrestamos.Web
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ => View["Client/index"];
        }
    }
}