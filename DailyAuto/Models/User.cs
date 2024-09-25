using System.Numerics;

namespace DailyAuto.Models
{
    public class User
    {
        protected int user_id { get; set; }
        public string user_name { get; set; }
        public string user_email { get; set; }
        private string user_password { get; set; }
        public string user_phone { get; set; }
        private string user_cpf { get; set; }
        public string user_address { get; set; }


        public User()
        {
            user_id = 0;
            user_name = "";
            user_email = "";
            user_password = "";
            user_phone = "";
            user_cpf = "";
            user_address = "";
        }
    }
}
