using System.Linq;
using BotApplication1.Models.Common;

namespace BotApplication1.Handlers
{
    public class CheckInIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            var confirmPosition = commonModel.Request.Parameters.FirstOrDefault(p => p.Key == "confirmPosition");
            var pickkupType = commonModel.Request.Parameters.FirstOrDefault(p => p.Key == "pickkupType");

            //bool.TryParse(confirmPosition.Value, out bool shouldCheckin);

            if (confirmPosition.Value.ToLower() == "yes")
            {
                commonModel.Response.Ssml = $"Order Checked in. Please go to {pickkupType.Value} "  +
                    $"and quote order number <say-as interpret-as=\"spell-out\">3314</say-as>";

                commonModel.Response.Card = new Card
                {
                    Title = "KFC Check In",
                    Text = $"Order checked in. Please go to the {pickkupType.Value} and quote order number 3314."
                };
            }
            else
            {
                commonModel.Response.Text = "Please checkin when you are at restaurant. See you soon!";
            }
                
            commonModel.Session.EndSession = true;
            return commonModel;
        }
    }
}