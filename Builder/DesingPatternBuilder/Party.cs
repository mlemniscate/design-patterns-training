namespace DesingPatternBuilder
{

    public class Party
    {
        public int Id { get; set; }
    }

    public class IndividualParty : Party
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
    }
    public class LegalParty : Party
    {
        public string RegistrationCode { get; set; }
        public string Title { get; set; }
    }
}
