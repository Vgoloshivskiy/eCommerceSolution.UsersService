using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.Entities.DTO
{
    public record RegisterRequest(string? Email, string? Password,string? PersonName, GenderOptions Gender)
    {
        //parameterless constructor for mapping
        public RegisterRequest() : this(default, default, default, default) { }
    }
    
    
}
