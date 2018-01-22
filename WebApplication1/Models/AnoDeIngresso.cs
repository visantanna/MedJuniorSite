using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication1.Models
{
    public static class AnoDeIngresso
    {
        public static IEnumerable<SelectListItem> GetListAnoDeIngresso()
        {
            DateTime dataAtual = DateTime.Today;
            List<SelectListItem> listaDeItens = new List<SelectListItem>();
            for (int i = 2010; i <= dataAtual.Year; i++)
            {
                SelectListItem item = new SelectListItem { Selected = (i == dataAtual.Year), Text = i.ToString(), Value = i.ToString() };
                listaDeItens.Add(item);
            }

            return (IEnumerable<SelectListItem>)listaDeItens;
        }
    }
}