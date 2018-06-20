using System.Linq;
using BotApplication1.Models.Common;

namespace BotApplication1.Handlers
{
    public class HelpIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            
            commonModel.Response.Text = "Welcome to KFC. I can help you order your favorite or re order previous order. Say, book my favorite name";
            commonModel.Session.EndSession = true;

            return commonModel;
        }
    }
}