using AspCoreCaslışması.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreCaslışması.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "Mehmet"
                },
                new UserComment
                {
                    ID = 2, 
                    Username = "ahmet"
                },
                new UserComment
                {
                    ID = 3,
                    Username = "Kağan"
                },
            };
            return View(commentvalues);
        }
    }
}
