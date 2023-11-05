using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Contact
    {
        [Key] //Sql serverde FK oluşturma attribute'i // bunu tanımlamak için entity framework paketi indirdik
        public int ContectId { get; set; }

        [StringLength(50)] // Sql karakter uzunluğu attribute'i
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserMail { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
