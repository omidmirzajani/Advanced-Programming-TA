namespace A5
{
    public class Patient : IPerson
    {
        public Patient(string fitstname, string lastname, string disease, bool recovered)
        {
            Firstname = fitstname;
            Lastname = lastname;
            Disease = disease;
            Recovered = recovered;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Disease { get; set; }
        public bool Recovered { get; set; }
    }
}
