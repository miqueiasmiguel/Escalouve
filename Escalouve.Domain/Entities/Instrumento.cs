﻿using Escalouve.Domain.Validation;

namespace Escalouve.Domain.Entities;

public sealed class Instrumento
{
    public int Id { get; private set; }
    public string Nome { get; private set; }

    public Instrumento(string nome)
    {
        Validar(nome);
    }

    private void Validar(string nome)
    {
        DomainExceptionValidation.When(nome.Length > 250, "Nome inválido. O nome não pode ter mais que 250 caracteres.");
        DomainExceptionValidation.When(nome.Length < 3, "Nome inválido. O nome não pode ter menos que 3 caracteres.");

        Nome = nome;
    }
}
