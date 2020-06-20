using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Pages
{
    public class LearnBlazorBase : ComponentBase
    {
        protected string name = null;
        protected string WelcomeText = "Time to learn blazor!";

        protected void getName()
        {
            name = "Blazor Learner";
        }
    }
}
