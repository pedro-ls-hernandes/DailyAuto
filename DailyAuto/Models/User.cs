using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace DailyAuto.Models
{
    public class User
    {
        protected int user_id { get; set; }
        [Required, MaxLength(255)]
        public string user_name { get; set; }
        [Required, MaxLength(255)]
        public string user_email { get; set; }
        [Required, DataType(DataType.Password)]
        private string user_password { get; set; }
        public string user_phone { get; set; }
        private string user_cpf { get; set; }
        public string user_address { get; set; }


    }
}
