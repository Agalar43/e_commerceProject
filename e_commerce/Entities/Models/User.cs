namespace Entities.Models
{
    public class User
    {
        public int UserID { get; set; }

        public String? Firstname { get; set; } = string.Empty;
        public String? Lastname { get; set; } = string.Empty;
        public String? e_mail { get; set; } = string.Empty;
        public String? adress { get; set; } = string.Empty;
        public String? phone_number { get; set; } = string.Empty;
        public String? password { get; set; } = string.Empty;


    }
}