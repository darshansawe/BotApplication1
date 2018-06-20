using System.Linq;
using BotApplication1.Models.Common;

namespace BotApplication1.Handlers
{
    public class StopIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            
            commonModel.Response.Text = "Ok, all cancelled";
            commonModel.Session.EndSession = true;

            return commonModel;
        }
    }
}