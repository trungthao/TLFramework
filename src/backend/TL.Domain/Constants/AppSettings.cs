namespace TL.Domain.Constants
{
    public class AppSettings
    {
        public JwtSettings JwtSettings { get; set; }
        public const string ConfigName = "AppSettings";

        public string EmailFrom { get; set; }

        public string SmtpHost { get; set; }

        public int SmtpPort { get; set; }

        public string SmtpUser { get; set; }

        public string SmtpPass { get; set; }

        public bool SmtpUseSsl { get; set; }

        public string ConnectionString { get; set; }
    }


    public class JwtSettings
    {
        public const string Jwt = "Jwt";

        public string SecretKey { get; set; }
        public int ExpireMinutes { get; set; }
        public int RefreshTokenExpireDays { get; set; }
    }
}