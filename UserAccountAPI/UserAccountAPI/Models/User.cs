﻿using System;
using System.Collections.Generic;

namespace UserAccountAPI.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public byte[]? Image { get; set; }
    }
}
