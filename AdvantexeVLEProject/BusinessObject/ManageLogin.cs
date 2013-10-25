using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    [DataContract]
    public class ManageLogin
    {
        [DataMember]
        [Required(ErrorMessage = "User Name is Required")]
        [DisplayName("Email Id:")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email Format is wrong")]
        [StringLength(50, ErrorMessage = "Less than 50 characters")]
        public string UserName { get; set; }

        [DataMember]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]
        [DisplayName("Password:")]
        [StringLength(30, ErrorMessage = "Password should be less than 30 characters")]
        public string Password { get; set; }
    }
}
