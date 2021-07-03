using System;
using System.ComponentModel.DataAnnotations; //[Required]

namespace Store.Web.Models
{
    public class ErrorViewModel
    {
        [Required] // если тут 0 то ошибка
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
