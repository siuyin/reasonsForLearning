using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System.Collections.Generic;
using Microsoft.Bot.Connector;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"I don't understand what you are saying. Please consult your teacher."); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Why")]
    public async Task Why(IDialogContext context, LuisResult result)
    {

        await context.PostAsync($"Learning is fun."); //
        context.Wait(MessageReceived);
    }
    
    [LuisIntent("Whypressure")]
    public async Task Whypressure(IDialogContext context, LuisResult result)
    {

        await context.PostAsync($"Pressure is all around you. We are surrounded by air pressure."); //
        context.Wait(MessageReceived);
    }
    [LuisIntent("Whyangle")]
    public async Task Whyangle(IDialogContext context, LuisResult result)
    {

        await context.PostAsync($"Everyone uses angles daily."); //
        context.Wait(MessageReceived);
    }
    [LuisIntent("Whyphy")]
    public async Task Whyphy(IDialogContext context, LuisResult result)
    {

        await context.PostAsync($"Physics explains the world."); //
        context.Wait(MessageReceived);
    }
    [LuisIntent("Whyma")]
    public async Task Whyma(IDialogContext context, LuisResult result)
    {

        await context.PostAsync($"Maths is used to perform many different daily tasks, such as counting, telling time, etc."); //
        context.Wait(MessageReceived);
    }
    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    [LuisIntent("Greeting")]
    public async Task Greeting(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Hi. I'm a study bot. Do you want to know Physics or Maths?"); //
        context.Wait(MessageReceived);
    }
    
    
    
    [LuisIntent("Study")]
    public async Task Study(IDialogContext context, LuisResult result)
    {
        string subject = "";
        if(result.Entities.Count != 0)
        {
            subject = result.Entities[0].Entity;
        }
        else
        {
            subject = "empty";
        }
        
        
        if(subject == "maths" || subject == "math"|| subject == "mathematics")
        {
            await context.PostAsync($"What Maths topic interests you?"); //
            context.Wait(MessageReceived);
        }
        else if(subject == "pressure")
        {
         //Cut from here
        var replyImage = context.MakeMessage();
        
        replyImage.Attachments = new List<Attachment>()
        {
            new Attachment()
            {
                ContentUrl = "http://www.aaronswansonpt.com/wp-content/uploads/2011/07/Pressure.png",
                ContentType = "image/png",
                Name = "image.png"
            }
        };
        //this line reply to users on the image
        await context.PostAsync(replyImage);
        //until here   
            await context.PostAsync($"Pressure is force over area."); //
            context.Wait(MessageReceived);
        }
         else if(subject == "force")
        {
            //Cut from here
        var replyImage = context.MakeMessage();
        
        replyImage.Attachments = new List<Attachment>()
        {
            new Attachment()
            {
                ContentUrl = "https://assets.ec.quoracdn.net/main-qimg-62fde7c58956c987eba5077b1106f221",
                ContentType = "image/png",
                Name = "image.png"
            }
        };
        //this line reply to users on the image
        await context.PostAsync(replyImage);
        //until here
            await context.PostAsync($"force is push or pull."); //
            context.Wait(MessageReceived);
        }
        else
        {
            await context.PostAsync($"What Physics topic interests you?"); //
            context.Wait(MessageReceived);  
        }
    }
}