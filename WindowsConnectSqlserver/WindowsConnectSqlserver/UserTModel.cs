using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsConnectSqlserver
{
    [Table("UserTForWinform")]
    //去掉后，会去找叫UserModelForEF的表
    public class UserTModel
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        [NotMapped]
        public string RealGender { 
            get
            {
                if (Gender == "1")
                {
                    return "男";
                }
                else if (Gender == "2")
                {
                    return "女";
                }
                return "未知";
            }
        
        }
    }
}
