using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {


        public IViewComponentResult Invoke(string name)
        {
            var projects = new List<Project>
            {
                new Project(1, "تاکسی", "تاکسی آنلاین سفر های درون شهری", "project-1.jpg","Atriya"),
                new Project(2, "زودفود", "درخواست آنلاین غذا", "project-2.jpg","Zodfod"),
                new Project(3, "مدارس", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg","MONOP"),
                new Project(4, "فضاپیما", "برنامه مدیریت فضا پیما های ناسا", "project-3.jpg","NASA")



            };

            return View("_Projects", projects);
        }
    }
}

