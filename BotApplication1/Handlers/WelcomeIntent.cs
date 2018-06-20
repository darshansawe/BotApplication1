using BotApplication1.Models.Common;

namespace BotApplication1.Handlers
{
    public class WelcomeIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            commonModel.Response.Text = "Welcome to KFC. Order your favorite or ask for help";

            commonModel.Session.EndSession = false;
            return commonModel;
        }
    }
}