namespace Informes
{
    public class ConfigEmail
    {
        public string EmailAddr { get; set; }
        public string EmailPass { get; set; }
        public List<string> EmailTarget { get; set; }

        public bool Informar { get; set; }

    }
}