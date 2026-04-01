using NexusEcommerce.Usuario.Domain.Exceptions;
using System.Linq;

namespace NexusEcommerce.Usuario.Domain.ValueObjects;

/// <summary>
/// Value Object imutável. Comparação por valor (não por referência).
/// Princípio Fail-Fast: CPF inválido = exceção imediata no construtor.
/// </summary>
public record Cpf
{
    public string Numero { get; init; }

    public Cpf(string numero)
    {
        // Fail-Fast 1: nulo antes de qualquer processamento
        ArgumentNullException.ThrowIfNullOrWhiteSpace(numero);

        var numeroLimpo = LimparFormatacao(numero);

        // Fail-Fast 2: regras de negócio
        if (!EhValido(numeroLimpo))
            throw new DomainException("O CPF informado é inválido.");

        Numero = numeroLimpo;
    }

    private static string LimparFormatacao(string cpf) =>
        new string(cpf.Where(char.IsDigit).ToArray());

    private static bool EhValido(string cpf)
    {
        if (cpf.Length != 11 || cpf.Distinct().Count() == 1) return false;

        int[] mult1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] mult2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        var soma = 0;
        for (int i = 0; i < 9; i++)
            soma += (cpf[i] - '0') * mult1[i]; // sem int.Parse = zero alocação

        var d1 = soma % 11 < 2 ? 0 : 11 - soma % 11;

        soma = 0;
        for (int i = 0; i < 9; i++)
            soma += (cpf[i] - '0') * mult2[i + 1];
        soma += d1 * mult2[0];

        var d2 = soma % 11 < 2 ? 0 : 11 - soma % 11;

        return (cpf[9] - '0') == d1 && (cpf[10] - '0') == d2;
    }

    // C# moderno: Range syntax ao invés de Substring
    public string ObterFormatado() =>
        $"{Numero[..3]}.{Numero[3..6]}.{Numero[6..9]}-{Numero[9..]}";

    public override string ToString() => ObterFormatado();
}