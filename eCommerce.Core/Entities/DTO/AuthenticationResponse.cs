using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.Entities.DTO
{
    public record AuthenticationResponse(
    Guid UserID, string? Email, string? PersonName, string? Gender, string? Token, bool Success
    )
    {
        //parameterless constructor for mapping
        public AuthenticationResponse() : this(default, default, default, default, default, default ) { }
    }
}
