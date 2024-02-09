using System.Web.Mvc;

public class AccountController : Controller
{
    public ActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Implement your authentication logic here, e.g., check username and password against database
            if (model.UserName == "admin" && model.Password == "password")
            {
                // If authentication succeeds, redirect to home page or any desired page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid username or password.");
            }
        }

        // If authentication fails, return the login view with error message
        return View(model);
    }
}
