using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtJsDataGridMvcApp.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Contact(string pName, string pPhone, string pEmail)
        {
            this.Id = System.Guid.NewGuid().ToString();
            this.Name = pName;
            this.Phone = pPhone;
            this.Email = pEmail;
        }

        public Contact() { }
    }
}