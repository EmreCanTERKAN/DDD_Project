﻿using Domain.Abstractions;
using Domain.Shared;

namespace Domain.Users;
public sealed class User : Entity
{
    public User(Guid id, Name name, Email email, Password password, Address? address) : base(id)
    {
        Name = name;
        Email = email;
        Password = password;
        Address = address;
    }

    public Name Name { get; private set; }
    public Email Email { get; private set; }
    public Password Password { get; private set; }
    public Address? Address { get; private set; }

    public void ChangeName(string name)
    {
        Name = new Name(name);
    }
    public void ChangeEmail(string email)
    {
        Email = new Email(email);
    }
    public void ChangeAddress(string country, string city, string street, string postalCode, string fullAddress)
    {
        Address = new(country, city, street, postalCode, fullAddress);
    }

    public void ChangePassword(string password)
    {
        Password = new(password);
    }

}
