﻿using Core.Persistence.Repositories;

namespace Core.Security.Entities;

public class User : Entity<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Status { get; set; }
    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; } = null!;
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = null!;
    public virtual ICollection<OtpAuthenticator> OtpAuthenticators { get; set; } = null!;

    public User()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        PasswordSalt = Array.Empty<byte>();
        PasswordHash = Array.Empty<byte>();
    }

    public User(string firstName, string lastName, string email, byte[] passwordSalt, byte[] passwordHash, bool status)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
    }

    public User(int id, string firstName, string lastName, string email, byte[] passwordSalt, byte[] passwordHash, bool status) : base(id)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
    }
}
