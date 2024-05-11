using System.Web.Mvc;

namespace PrShip.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult LoginWithGitHub()
        {
            // GitHub ile giriş yapma 
            // Kullanıcıyı GitHub'a yönlendirme
            return Redirect("https://github.com/login/oauth/authorize?client_id=YOUR_CLIENT_ID&redirect_uri=YOUR_REDIRECT_URI");
        }

        // GitHub'dan dönüş
        public ActionResult GitHubCallback(string code)
        {
            //TODO: GitHub'dan gelen code parametresini işle ve kullanıcı bilgilerini al
            //TODO: Gerekli işlemleri gerçekleştir (kullanıcı oluşturma, oturum açma vb.)
            //TODO: Ardından ana sayfaya yönlendir veya kullanıcı profiline yönlendir
            return RedirectToAction("Index", "Home");
        }
    }
}
