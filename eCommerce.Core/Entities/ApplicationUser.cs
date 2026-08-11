using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Core.Entities
{
    public class ApplicationUser
    {
        /// <summary>
        /// Gets and set for User
        /// </summary>
        public Guid UserID { get; set; }
        public string? PersonName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Gender { get; set; }

    }
}
