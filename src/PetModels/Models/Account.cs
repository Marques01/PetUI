using System.ComponentModel.DataAnnotations;

namespace PetModels.Models
{
    public class Account
    {
        string
            _userMail = string.Empty,
            _userPassword = string.Empty,
            _userConfirmPassword = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [EmailAddress(ErrorMessage = "Insira um e-mail válido")]
        public string UserMail { get => _userMail; set => _userMail = value; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres")]
        public string Password { get => _userPassword; set => _userPassword = value; }

        [Compare(nameof(Password), ErrorMessage = "As senhas não são iguais")]
        public string ConfirmPassword { get => _userConfirmPassword; set => _userConfirmPassword = value; }
    }
}
