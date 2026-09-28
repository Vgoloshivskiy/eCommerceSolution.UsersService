using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.Entities.DTO
{
    public record UserDTO(Guid UserID, string? Email, string? PersonName, string Gender)
    {

    }
}
