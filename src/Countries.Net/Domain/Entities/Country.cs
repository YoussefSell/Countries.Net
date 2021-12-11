namespace Countries.NET
{
    using Database;
    using Enums;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// the class that defines the country entity
    /// </summary>
    public abstract partial class Country
    {
        /// <summary>
        /// the name of the country
        /// </summary>
        public LocalizedCountryName Name { get; }

        /// <summary>
        /// code ISO 3166-1 alpha-2
        /// </summary>
        public string CCA2 { get; }

        /// <summary>
        /// code ISO 3166-1 alpha-3
        /// </summary>
        public string CCA3 { get; }

        /// <summary>
        /// code ISO 3166-1 numeric
        /// </summary>
        public string CCN3 { get; }

        /// <summary>
        /// code International Olympic Committee
        /// </summary>
        public string CIOC { get; }

        /// <summary>
        /// the country flag
        /// </summary>
        public string Flag { get; }

        /// <summary>
        /// region
        /// </summary>
        public Region Region { get; }

        /// <summary>
        /// subregion
        /// </summary>
        public string Subregion { get; }

        /// <summary>
        /// ISO 3166-1 independence status
        /// </summary>
        public bool Independent { get; }

        /// <summary>
        /// ISO 3166-1 assignment status
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// UN Member status
        /// </summary>
        public bool UnMember { get; }

        /// <summary>
        /// landlocked status
        /// </summary>
        public bool Landlocked { get; }

        /// <summary>
        /// International Direct Dialing info
        /// </summary>
        public InternationalDirectDialingInfo IDD { get; }

        /// <summary>
        /// land borders
        /// </summary>
        public IEnumerable<string> Borders { get; }

        /// <summary>
        /// capital city(ies)
        /// </summary>
        public IEnumerable<string> Capital { get; }

        /// <summary>
        /// alternative spellings
        /// </summary>
        public IEnumerable<string> AltSpellings { get; }

        /// <summary>
        /// country top-level domain list
        /// </summary>
        public IEnumerable<string> TLD { get; }

        /// <summary>
        /// latitude and longitude
        /// </summary>
        public IEnumerable<double> Latlng { get; }

        /// <summary>
        /// the country time zones
        /// </summary>
        public IEnumerable<string> Timezones { get; }

        /// <summary>
        /// the country languages
        /// </summary>
        public IEnumerable<Language> Languages { get; }

        /// <summary>
        /// the country currencies
        /// </summary>
        public IEnumerable<Currency> Currencies { get; }

        /// <summary>
        /// name of residents, translated and genderized
        /// <para>key: three-letter ISO 639-3 language code</para>
        /// <para>value: genderized demonym object</para>
        /// </summary>
        public IDictionary<string, DemonymsGender> Demonyms { get; }
    }

    /// <summary>
    /// partial part for <see cref="Country"/>
    /// </summary>
    public abstract partial class Country
    {
        /// <summary>
        /// create an instance of <see cref="Country"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cca2"></param>
        /// <param name="cca3"></param>
        /// <param name="ccn3"></param>
        /// <param name="cioc"></param>
        /// <param name="flag"></param>
        /// <param name="region"></param>
        /// <param name="subregion"></param>
        /// <param name="independent"></param>
        /// <param name="status"></param>
        /// <param name="unMember"></param>
        /// <param name="landlocked"></param>
        /// <param name="idd"></param>
        /// <param name="borders"></param>
        /// <param name="capital"></param>
        /// <param name="altSpellings"></param>
        /// <param name="tld"></param>
        /// <param name="latlng"></param>
        /// <param name="timezones"></param>
        /// <param name="languages"></param>
        /// <param name="currencies"></param>
        /// <param name="demonyms"></param>
        protected Country(
            LocalizedCountryName name,
            string cca2,
            string cca3,
            string ccn3,
            string cioc,
            string flag,
            Region region,
            string subregion,
            bool independent,
            string status,
            bool unMember,
            bool landlocked,
            InternationalDirectDialingInfo idd,
            IEnumerable<string> borders,
            IEnumerable<string> capital,
            IEnumerable<string> altSpellings,
            IEnumerable<string> tld,
            IEnumerable<double> latlng,
            IEnumerable<string> timezones,
            IEnumerable<Language> languages,
            IEnumerable<Currency> currencies,
            IDictionary<string, DemonymsGender> demonyms)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            CCA2 = cca2 ?? throw new ArgumentNullException(nameof(cca2));
            CCA3 = cca3 ?? throw new ArgumentNullException(nameof(cca3));
            CCN3 = ccn3 ?? throw new ArgumentNullException(nameof(ccn3));
            CIOC = cioc ?? throw new ArgumentNullException(nameof(cioc));
            Flag = flag ?? throw new ArgumentNullException(nameof(flag));
            Region = region;
            Subregion = subregion ?? throw new ArgumentNullException(nameof(subregion));
            Independent = independent;
            Status = status ?? throw new ArgumentNullException(nameof(status));
            UnMember = unMember;
            Landlocked = landlocked;
            IDD = idd ?? throw new ArgumentNullException(nameof(idd));
            Borders = borders ?? throw new ArgumentNullException(nameof(borders));
            Capital = capital ?? throw new ArgumentNullException(nameof(capital));
            AltSpellings = altSpellings ?? throw new ArgumentNullException(nameof(altSpellings));
            TLD = tld ?? throw new ArgumentNullException(nameof(tld));
            Latlng = latlng ?? throw new ArgumentNullException(nameof(latlng));
            Timezones = timezones ?? throw new ArgumentNullException(nameof(timezones));
            Languages = languages ?? throw new ArgumentNullException(nameof(languages));
            Currencies = currencies ?? throw new ArgumentNullException(nameof(currencies));
            Demonyms = demonyms ?? throw new ArgumentNullException(nameof(demonyms));
        }

        /// <summary>
        /// the list of supported countries
        /// </summary>
        internal static readonly Country[] ALL = new Country[]
        {
            Afghanistan.Instance, ÅlandIslands.Instance, Albania.Instance, Algeria.Instance, AmericanSamoa.Instance, Andorra.Instance, Angola.Instance, Anguilla.Instance, Antarctica.Instance, AntiguaandBarbuda.Instance, Argentina.Instance, Armenia.Instance, Aruba.Instance, Australia.Instance, Austria.Instance, Azerbaijan.Instance, Bahamas.Instance, Bahrain.Instance, Bangladesh.Instance, Barbados.Instance, Belarus.Instance,
            Belgium.Instance, Belize.Instance, Benin.Instance, Bermuda.Instance, Bhutan.Instance, Bolivia.Instance, BosniaandHerzegovina.Instance, Botswana.Instance, BouvetIsland.Instance, Brazil.Instance, BritishIndianOceanTerritory.Instance, BritishVirginIslands.Instance, Brunei.Instance, Bulgaria.Instance, BurkinaFaso.Instance, Burundi.Instance, Cambodia.Instance, Cameroon.Instance, Canada.Instance, CapeVerde.Instance,
            CaribbeanNetherlands.Instance, CaymanIslands.Instance, CentralAfricanRepublic.Instance, Chad.Instance, Chile.Instance, China.Instance, ChristmasIsland.Instance, CocosKeelingIslands.Instance, Colombia.Instance, Comoros.Instance, CookIslands.Instance, CostaRica.Instance, Croatia.Instance, Cuba.Instance, Curaçao.Instance, Cyprus.Instance, Czechia.Instance, Denmark.Instance, Djibouti.Instance, Dominica.Instance,
            DominicanRepublic.Instance, DRCongo.Instance, Ecuador.Instance, Egypt.Instance, ElSalvador.Instance, EquatorialGuinea.Instance, Eritrea.Instance, Estonia.Instance, Eswatini.Instance, Ethiopia.Instance, FalklandIslands.Instance, FaroeIslands.Instance, Fiji.Instance, Finland.Instance, France.Instance, FrenchGuiana.Instance, FrenchPolynesia.Instance, FrenchSouthernandAntarcticLands.Instance, Gabon.Instance, Gambia.Instance,
            Georgia.Instance, Germany.Instance, Ghana.Instance, Gibraltar.Instance, Greece.Instance, Greenland.Instance, Grenada.Instance, Guadeloupe.Instance, Guam.Instance, Guatemala.Instance, Guernsey.Instance, Guinea.Instance, GuineaBissau.Instance, Guyana.Instance, Haiti.Instance, HeardIslandandMcDonaldIslands.Instance, Honduras.Instance, HongKong.Instance, Hungary.Instance, Iceland.Instance,
            India.Instance, Indonesia.Instance, Iran.Instance, Iraq.Instance, Ireland.Instance, IsleofMan.Instance, Israel.Instance, Italy.Instance, IvoryCoast.Instance, Jamaica.Instance, Japan.Instance, Jersey.Instance, Jordan.Instance, Kazakhstan.Instance, Kenya.Instance, Kiribati.Instance, Kosovo.Instance, Kuwait.Instance, Kyrgyzstan.Instance, Laos.Instance,
            Latvia.Instance, Lebanon.Instance, Lesotho.Instance, Liberia.Instance, Libya.Instance, Liechtenstein.Instance, Lithuania.Instance, Luxembourg.Instance, Macau.Instance, Madagascar.Instance, Malawi.Instance, Malaysia.Instance, Maldives.Instance, Mali.Instance, Malta.Instance, MarshallIslands.Instance, Martinique.Instance, Mauritania.Instance, Mauritius.Instance, Mayotte.Instance,
            Mexico.Instance, Micronesia.Instance, Moldova.Instance, Monaco.Instance, Mongolia.Instance, Montenegro.Instance, Montserrat.Instance, Morocco.Instance, Mozambique.Instance, Myanmar.Instance, Namibia.Instance, Nauru.Instance, Nepal.Instance, Netherlands.Instance, NewCaledonia.Instance, NewZealand.Instance, Nicaragua.Instance, Niger.Instance, Nigeria.Instance, Niue.Instance,
            NorfolkIsland.Instance, NorthKorea.Instance, NorthMacedonia.Instance, NorthernMarianaIslands.Instance, Norway.Instance, Oman.Instance, Pakistan.Instance, Palau.Instance, Palestine.Instance, Panama.Instance, PapuaNewGuinea.Instance, Paraguay.Instance, Peru.Instance, Philippines.Instance, PitcairnIslands.Instance, Poland.Instance, Portugal.Instance, PuertoRico.Instance, Qatar.Instance, RepublicoftheCongo.Instance,
            Réunion.Instance, Romania.Instance, Russia.Instance, Rwanda.Instance, SaintBarthélemy.Instance, SaintHelenaAscensionandTristandaCunha.Instance, SaintKittsandNevis.Instance, SaintLucia.Instance, SaintMartin.Instance, SaintPierreandMiquelon.Instance, SaintVincentandtheGrenadines.Instance, Samoa.Instance, SanMarino.Instance, SãoToméandPríncipe.Instance, SaudiArabia.Instance, Senegal.Instance, Serbia.Instance, Seychelles.Instance, SierraLeone.Instance, Singapore.Instance,
            SintMaarten.Instance, Slovakia.Instance, Slovenia.Instance, SolomonIslands.Instance, Somalia.Instance, SouthAfrica.Instance, SouthGeorgia.Instance, SouthKorea.Instance, SouthSudan.Instance, Spain.Instance, SriLanka.Instance, Sudan.Instance, Suriname.Instance, SvalbardandJanMayen.Instance, Sweden.Instance, Switzerland.Instance, Syria.Instance, Taiwan.Instance, Tajikistan.Instance, Tanzania.Instance,
            Thailand.Instance, TimorLeste.Instance, Togo.Instance, Tokelau.Instance, Tonga.Instance, TrinidadandTobago.Instance, Tunisia.Instance, Turkey.Instance, Turkmenistan.Instance, TurksandCaicosIslands.Instance, Tuvalu.Instance, Uganda.Instance, Ukraine.Instance, UnitedArabEmirates.Instance, UnitedKingdom.Instance, UnitedStates.Instance, UnitedStatesMinorOutlyingIslands.Instance, UnitedStatesVirginIslands.Instance, Uruguay.Instance, Uzbekistan.Instance,
            Vanuatu.Instance, VaticanCity.Instance, Venezuela.Instance, Vietnam.Instance, WallisandFutuna.Instance, Yemen.Instance, Zambia.Instance, Zimbabwe.Instance,
        };
    }
}
