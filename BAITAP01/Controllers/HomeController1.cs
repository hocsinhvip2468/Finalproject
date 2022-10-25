using Microsoft.AspNetCore.Mvc;

namespace BAITAP01.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index(double sohang01, double sohang02, string pheptoan)
        {
            ViewBag.sohang01 = sohang01;
            ViewBag.sohang02 = sohang02;
            ViewBag.pheptoan = pheptoan;
            double kq = 0;
            switch (pheptoan)
            {
                case "+":
                    kq = sohang01 + sohang02;
                    break;
                case "-":
                    kq = sohang01 - sohang02;
                    break;
                case "*":
                    kq = sohang01 * sohang02;
                    break;
                case "/":
                    kq = sohang01 / sohang02;
                    break;
            }
            ViewBag.KetQua = kq;
            return View();
        }
    }
}
