using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Enums
{
    public enum Faculdade
    {
        [Display(Name = "Enfermagem")]
        enfermagem,
        [Display(Name = "Fisioterapia")]
        fisioterapia,
        [Display(Name = "Fonoaudiologia")]
        fonoaudiologia,
        [Display(Name = "Medicina")]
        medicina,
        [Display(Name = "Nutrição")]
        nutricao,
        [Display(Name = "Saúde Pública")]
        saudePublica,
        [Display(Name = "Terapia Ocupacional")]
        terapiaOcupacional
    }
}