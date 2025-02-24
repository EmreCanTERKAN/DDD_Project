namespace Domain.Users;

public sealed record Email
{
    public string Value { get; init; }
    public Email(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentNullException("email alanı boş olamaz.");
        if (value.Length < 3)
            throw new ArgumentException("email alanı 3 karakterden küçük olamaz!");
        if (!value.Contains("@"))
            throw new ArgumentException("geçersiz mail");
        Value = value;
    }

}
