using System.ComponentModel.DataAnnotations;

namespace OrisCenter.Key.ViewModels
{
    public class ContaMinhaContaViewModel
    {
        [Required]
        [Display(Name ="Nome completo")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Número de celular")]
        public string NumeroDeCelular { get; set; }

        [Display(Name = "Habilitar autenticação de dois fatores")]
        public bool HabilitarAutenticacaoDeDoisFatores { get; set; }

        public bool NumeroDeCelularConfirmado { get; set; }
    }
}