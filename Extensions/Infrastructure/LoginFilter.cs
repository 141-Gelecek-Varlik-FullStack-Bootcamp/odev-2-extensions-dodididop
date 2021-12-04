using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;



namespace Extensions.Infrastructure
{
    public class LoginFilter : Attribute, IActionFilter
    {
        string userType = UserType.UserType1.ToString();//user type assigned to the variable.

        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Privacy" }));// executed context action is privacy because user type is not a manager.
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (userType != "UserType1") //if user is not a manager,you cannot allow to see the page.                         
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Privacy" }));
            }
            return;
        }


    }
}
