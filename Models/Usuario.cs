﻿using Microsoft.AspNetCore.Identity;
using System;

namespace UsuariosAPI.Models
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }

        public Usuario() : base() { }
    }
}
