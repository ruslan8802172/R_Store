using System;
using System.ComponentModel.DataAnnotations; //[Required]

namespace Store.Web.Models
{
    public class ErrorViewModel
    {
        [Required] // ���� ��� 0 �� ������
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
