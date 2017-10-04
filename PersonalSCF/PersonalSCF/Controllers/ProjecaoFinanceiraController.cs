using PersonalSCF.DataModel;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using System;

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

            decimal valorReceitas = 0;
            decimal valorDespesas = 0;
            List<tb_lancamento> receitas = new List<tb_lancamento>();
            List<tb_lancamento> despesas = new List<tb_lancamento>();

            foreach (tb_lancamento lanc in lancamentos)
            {
                if (lanc.Valor > 0)
                {
                    valorReceitas += lanc.Valor;
                    receitas.Add(lanc);
                }
                else if (lanc.Valor < 0)
                {
                    valorDespesas += lanc.Valor;
                    despesas.Add(lanc);
                }
            }

            decimal receitas30dias = 0, despesas30dias = 0, receitas60dias = 0, despesas60dias = 0, receitas90dias = 0, despesas90dias = 0;

            foreach (tb_lancamento receita in receitas)
            {
                if (receita.DataEvento >= DateTime.Now && receita.DataEvento <= DateTime.Now.AddMonths(1))
                {
                    receitas30dias += receita.Valor;
                }
                if (receita.DataEvento >= DateTime.Now && receita.DataEvento <= DateTime.Now.AddMonths(2))
                {
                    receitas60dias += receita.Valor;
                }
                if (receita.DataEvento >= DateTime.Now && receita.DataEvento <= DateTime.Now.AddMonths(3))
                {
                    receitas90dias += receita.Valor;
                }
            }

            foreach (tb_lancamento despesa in despesas)
            {
                if (despesa.DataEvento >= DateTime.Now && despesa.DataEvento <= DateTime.Now.AddMonths(1))
                {
                    despesas30dias -= despesa.Valor;
                }
                if (despesa.DataEvento >= DateTime.Now && despesa.DataEvento <= DateTime.Now.AddMonths(2))
                {
                    despesas60dias -= despesa.Valor;
                }
                if (despesa.DataEvento >= DateTime.Now && despesa.DataEvento <= DateTime.Now.AddMonths(3))
                {
                    despesas90dias -= despesa.Valor;
                }
            }

            ViewBag.ValorReceitas = valorReceitas;
            ViewBag.ValorDespesas = valorDespesas;
            ViewBag.Receitas = receitas.OrderByDescending(r => r.DataEvento);
            ViewBag.Despesas = despesas.OrderByDescending(r => r.DataEvento);
            ViewBag.Receitas30dias = receitas30dias.ToString().Replace(",", ".");
            ViewBag.Despesas30dias = despesas30dias.ToString().Replace(",", ".");
            ViewBag.Receitas60dias = receitas60dias.ToString().Replace(",", ".");
            ViewBag.Despesas60dias = despesas60dias.ToString().Replace(",", ".");
            ViewBag.Receitas90dias = receitas90dias.ToString().Replace(",", ".");
            ViewBag.Despesas90dias = despesas90dias.ToString().Replace(",", ".");

            return View();
        }
    }
}