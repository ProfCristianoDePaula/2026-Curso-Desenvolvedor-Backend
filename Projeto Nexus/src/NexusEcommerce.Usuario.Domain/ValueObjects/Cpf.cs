using System;
using System.Linq; // Obrigatório para o Where, ToArray, Distinct e Count!

namespace NexusEcommerce.Usuario.Domain.ValueObjects
{
    public record Cpf
    {
        public string Numero { get; }

        public Cpf(string numero)
        {
            // Remove todos os caracteres não numéricos de forma segura
            var numeroLimpo = new string(numero?.Where(char.IsDigit).ToArray() ?? Array.Empty<char>());

            // O Fail-Fast é uma abordagem onde o sistema falha rapidamente ao detectar um erro.
            // Se o número fornecido for inválido, lançamos uma exceção imediatamente 
            // para evitar que o sistema continue com um estado inconsistente na memória.
            if (!IsValidCpf(numeroLimpo))
            {
                throw new ArgumentException("O CPF informado é inválido.", nameof(numero));
            }

            // Atribuir o valor validado à propriedade!
            Numero = numeroLimpo;
        }

        private static bool IsValidCpf(string cpf)
        {
            // Verifica se tem 11 dígitos ou se todos os números são iguais (ex: 111.111.111-11)
            if (cpf.Length != 11 || cpf.Distinct().Count() == 1) return false;

            // Cálculo matemático do Dígito Verificador
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 }; // O cálculo do dígito verificador do CPF é realizado usando dois conjuntos de multiplicadores. O primeiro conjunto é usado para calcular o primeiro dígito verificador, e o segundo conjunto é usado para calcular o segundo dígito verificador. Cada dígito do CPF é multiplicado pelo respectivo multiplicador, e os resultados são somados para determinar os dígitos verificadores.
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 }; // O cálculo do dígito verificador do CPF é realizado usando dois conjuntos de multiplicadores. O primeiro conjunto é usado para calcular o primeiro dígito verificador, e o segundo conjunto é usado para calcular o segundo dígito verificador. Cada dígito do CPF é multiplicado pelo respectivo multiplicador, e os resultados são somados para determinar os dígitos verificadores.

            string tempCpf = cpf.Substring(0, 9); // O cálculo do dígito verificador do CPF é realizado usando os 9 primeiros dígitos do CPF para calcular o primeiro dígito verificador, e os 10 primeiros dígitos (incluindo o primeiro dígito verificador) para calcular o segundo dígito verificador. O CPF temporário é criado a partir dos 9 primeiros dígitos do CPF fornecido, e os cálculos são realizados para determinar os dígitos verificadores.

            int soma = 0; // Soma dos produtos dos dígitos pelos multiplicadores

            for (int i = 0; i < 9; i++) // Para cada um dos 9 primeiros dígitos do CPF, multiplicamos pelo respectivo multiplicador e somamos o resultado
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i]; // O resultado da soma é usado para calcular o primeiro dígito verificador do CPF, que é adicionado ao final do CPF temporário para o próximo cálculo.

            int resto = soma % 11; // O resto da divisão da soma por 11 é calculado para determinar o primeiro dígito verificador. Se o resto for menor que 2, o dígito é 0; caso contrário, o dígito é 11 menos o resto.

            resto = resto < 2 ? 0 : 11 - resto; // O primeiro dígito verificador é adicionado ao final do CPF temporário, e o processo é repetido para calcular o segundo dígito verificador, usando os 10 primeiros dígitos (incluindo o primeiro dígito verificador) e os multiplicadores correspondentes.

            string digito = resto.ToString(); // O segundo dígito verificador é calculado usando os 10 primeiros dígitos do CPF (incluindo o primeiro dígito verificador) e os multiplicadores correspondentes. O resultado é comparado com os dois últimos dígitos do CPF para validar sua autenticidade.

            tempCpf += digito; // O CPF temporário é atualizado para incluir o primeiro dígito verificador, e a soma é recalculada usando os 10 primeiros dígitos do CPF (incluindo o primeiro dígito verificador) e os multiplicadores correspondentes para determinar o segundo dígito verificador.

            soma = 0; // O segundo dígito verificador é calculado usando os 10 primeiros dígitos do CPF (incluindo o primeiro dígito verificador) e os multiplicadores correspondentes. O resultado é comparado com os dois últimos dígitos do CPF para validar sua autenticidade.

            for (int i = 0; i < 10; i++) // Para cada um dos 10 primeiros dígitos do CPF (incluindo o primeiro dígito verificador), multiplicamos pelo respectivo multiplicador e somamos o resultado
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i]; // O resultado da soma é usado para calcular o segundo dígito verificador do CPF, que é adicionado ao final do CPF temporário para o próximo cálculo.

            resto = soma % 11; // O resto da divisão da soma por 11 é calculado para determinar o segundo dígito verificador. Se o resto for menor que 2, o dígito é 0; caso contrário, o dígito é 11 menos o resto.

            resto = resto < 2 ? 0 : 11 - resto; // O segundo dígito verificador é calculado usando os 10 primeiros dígitos do CPF (incluindo o primeiro dígito verificador) e os multiplicadores correspondentes. O resultado é comparado com os dois últimos dígitos do CPF para validar sua autenticidade.

            digito += resto.ToString(); // O CPF é considerado válido se os dois dígitos verificadores calculados corresponderem aos dois últimos dígitos do CPF fornecido. A função retorna true se o CPF for válido e false caso contrário.

            return cpf.EndsWith(digito); // O CPF é considerado válido se os dois dígitos verificadores calculados corresponderem aos dois últimos dígitos do CPF fornecido. A função retorna true se o CPF for válido e false caso contrário.
        }
    }
}