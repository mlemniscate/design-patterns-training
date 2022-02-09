using System;

namespace DesingPatternBuilder
{
    
    public class PartyBuilder : IIndividualPartyBuilder,
        ILegalPartyBuilder,
        IIndividualPartyNameBuilder,
        ILegalPartyTitleBuilder,
        IPartyBuilder
    {
        private Party party;

        public IIndividualPartyBuilder CreateIndividual()
        {
            party = new IndividualParty();
            return this;
        }

        public ILegalPartyBuilder CreateLegal()
        {
            party = new LegalParty();
            return this;
        }

        IIndividualPartyNameBuilder IIndividualPartyBuilder.SetNationalCode(string nationalCode)
        {
            (party as IndividualParty).NationalCode = nationalCode;
            return this;
        }

        ILegalPartyTitleBuilder ILegalPartyBuilder.SetRegistrationCode(string registrationCode)
        {
            (party as LegalParty).RegistrationCode = registrationCode;
            return this;
        }

        IPartyBuilder IIndividualPartyNameBuilder.SetName(string firstName, string lastName)
        {
            (party as IndividualParty).FirstName = firstName;
            (party as IndividualParty).LastName = lastName;
            return this;
        }

        IPartyBuilder ILegalPartyTitleBuilder.SetTitle(string title)
        {
            (party as LegalParty).Title = title;
            return this;
        }

        Party IPartyBuilder.Build()
        {
            return party;
        }
    }

    public interface IIndividualPartyBuilder
    {
        IIndividualPartyNameBuilder SetNationalCode(string nationalCode);
    }
    public interface ILegalPartyBuilder
    {
        ILegalPartyTitleBuilder SetRegistrationCode(string registrationCode);
    }

    public interface IIndividualPartyNameBuilder
    {
        IPartyBuilder SetName(string firstName, string lastName);
    }
    public interface ILegalPartyTitleBuilder
    {
        IPartyBuilder SetTitle(string title);
    }

    public interface IPartyBuilder
    {
        Party Build();
    }

}
