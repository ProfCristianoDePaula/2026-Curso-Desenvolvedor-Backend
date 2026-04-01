using NexusEcommerce.Usuario.Domain.ValueObjects;
using NexusEcommerce.Usuario.Domain.Exceptions;

namespace NexusEcommerce.Usuario.Domain.Entities;

public class Cliente
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    // Ponte com o ASP.NET Identity (gerado na Etapa 1 do onboarding)
    public string IdentityId { get; private set; } = string.Empty;

    public string NomeCompleto { get; private set; } = string.Empty;

    // CPF agora é um tipo inteligente — não uma string solta
    public Cpf Cpf { get; private set; } = null!;

    public string Email { get; private set; } = string.Empty;

    // Endereço (preenchido na Etapa 2 do onboarding)
    public string? Cep { get; private set; }
    public string? Logradouro { get; private set; }
    public string? Bairro { get; private set; }
    public string? Cidade { get; private set; }
    public string? Estado { get; private set; }
    public string? NumeroEndereco { get; private set; }

    // Construtor protegido: obrigatório para o EF Core conseguir
    // reconstruir o objeto ao ler do banco (sem ele, EF lança exceção)
    protected Cliente() { }

    public Cliente(string identityId, string nomeCompleto, string cpf, string email)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(identityId);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(nomeCompleto);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(email);

        IdentityId = identityId;
        NomeCompleto = nomeCompleto;
        Email = email;
        Cpf = new Cpf(cpf); // Fail-Fast: se CPF inválido, para AQUI
    }

    // Método de negócio explícito — o estado só muda por aqui
    public void AtribuirEndereco(
        string cep, string logradouro, string bairro,
        string cidade, string estado, string numero)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(cep);

        Cep = cep;
        Logradouro = logradouro;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        NumeroEndereco = numero;
    }
}