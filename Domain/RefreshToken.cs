﻿using System;

namespace Domain
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public virtual AppUser AppUser { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; } = DateTime.UtcNow.AddMinutes(59);
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime? Revoked { get; set; }
        public bool IsActive => Revoked == null & !IsExpired;
    }
}