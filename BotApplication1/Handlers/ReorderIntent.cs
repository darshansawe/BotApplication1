using System.Linq;
using BotApplication1.Models.Common;

namespace BotApplication1.Handlers
{
    public class ReorderIntent
    {
        internal static CommonModel Process(CommonModel commonModel)
        {
            var confirmOrderDate = commonModel.Request.Parameters.FirstOrDefault(p => p.Key == "confirmOrderDate");

            //bool.TryParse(confirmOrderDate.Value, out bool shouldOrder);

            if (confirmOrderDate.Value.ToLower() == "yes")
            {
                commonModel.Response.Ssml = $"Ok, Your confirmed order number is <say-as interpret-as=\"spell-out\">35314</say-as> " +
                    $"Please collect it by 5 PM";

                commonModel.Response.Card = new Card
                {
                    Title = "KFC Order",
                    Text = $"Ok, Your confirmed order number is 35314. Please collect it by 5 PM "
                };
            }
            else
            {
                commonModel.Response.Text = "Ok. Order cancelled.";
            }
                
            commonModel.Session.EndSession = true;
            return commonModel;
        }
    }
}