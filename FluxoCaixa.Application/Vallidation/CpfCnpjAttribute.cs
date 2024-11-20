using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace FluxoCaixa.Application.Vallidation
{
    public class CpfCnpjAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            var cpfCnpj = value.ToString().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cpfCnpj.Length == 11 && IsValidCpf(cpfCnpj))
            {
                return ValidationResult.Success;
            }
            else if (cpfCnpj.Length == 14 && IsValidCnpj(cpfCnpj))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("O CPF/CNPJ é inválido.");
        }

        private bool IsValidCpf(string cpf)
        {
            // Lógica simplificada para validação de CPF
            if (cpf.Length != 11 || Regex.IsMatch(cpf, @"^(.)\1+$")) return false;

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;

            // Primeiro dígito verificador
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2) resto = 0;
            else resto = 11 - resto;
            if (resto != int.Parse(cpf[9].ToString())) return false;

            // Segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2) resto = 0;
            else resto = 11 - resto;
            return resto == int.Parse(cpf[10].ToString());
        }

        private bool IsValidCnpj(string cnpj)
        {
            // Lógica simplificada para validação de CNPJ
            if (cnpj.Length != 14 || Regex.IsMatch(cnpj, @"^(.)\1+$")) return false;

            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;

            // Primeiro dígito verificador
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2) resto = 0;
            else resto = 11 - resto;
            if (resto != int.Parse(cnpj[12].ToString())) return false;

            // Segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2) resto = 0;
            else resto = 11 - resto;
            return resto == int.Parse(cnpj[13].ToString());
        }
    }
}
