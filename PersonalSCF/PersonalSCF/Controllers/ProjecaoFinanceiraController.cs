using PersonalSCF.DataModel;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace PersonalSCF.Controllers
{
    public class ProjecaoFinanceiraController : Controller
    {
        // GET: ProjecaoFinanceira
        public ActionResult Index(string email)
        {
            personalscfEntities2 context = new personalscfEntities2();
            tb_usuario usuario = context.tb_usuario.Where(u => u.Email == email).First();
            List<tb_lancamento> lancamentos = context.tb_lancamento.Where(l => l.rl_usuario_lancamento.Where(rl => rl.ID_User == usuario.ID).Any()).ToList();
            decimal receitas = 0;
            decimal despesas = 0;

            foreach (tb_lancamento lanc in lancamentos)
            {
                if (lanc.Valor > 0)
                {
                    receitas += lanc.Valor;
                }
                else if (lanc.Valor < 0)
                {
                    despesas += lanc.Valor;
                }
            }

            ViewBag.Receitas = receitas;
            ViewBag.Despesas = despesas;

            return View();
        }
    }
}