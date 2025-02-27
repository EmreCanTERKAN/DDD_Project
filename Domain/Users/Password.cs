﻿namespace Domain.Users;

public sealed record Password
{
    public string Value { get; init; }
    public Password(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentNullException("password alanı boş olamaz.");
        if (value.Length < 6)
            throw new ArgumentException("şifre alanı 6 karakterden küçük olamaz!");
        Value = value;
    }
}
