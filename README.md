# Countries.Net

Get access to in-memory database of countries with an easy to use api and zero dependencies.

## Quick setup

to get started install the package using the [NuGet](https://www.nuget.org/packages/Countries.Net/) package manager `Install-Package Countries.Net`.

## Country entity

the country entity expose the following properties:

- `name`: the name of the country, a collection of key-value pairs where:
  - `key`: three-letter ISO 639-3 language code.
  - `value`: a country name object with:
    - `official`: the official name of the country.
    - `common`: the common name of the country.
- `cca2`: code ISO 3166-1 alpha-2.
- `cca3`: code ISO 3166-1 alpha-3.
- `ccn3`: code ISO 3166-1 numeric.
- `cioc`: code International Olympic Committee.
- `independent`: ISO 3166-1 independence status (denotes the country is considered a sovereign state).
- `status`: ISO 3166-1 assignment status.
- `unMember`: UN Member status.
- `flag`: the country flag.
- `region`: the country region.
- `subregion`: the country Subregion.
- `landlocked`: the landlocked status.
- `idd`: International Direct Dialing info, with:
  - `root`: the root geographical code prefix. e.g. +6 for New Zealand, +4 for UK.
  - `suffixes`: list of all suffixes assigned to this country. 4 for NZ, 809, 829, and 849 for Dominican Republic.
- `borders`: the country land borders.
- `capital`: the country capital city(ies).
- `altSpellings`: the country alternative spellings.
- `tld`: country top-level domain list.
- `latlng`: latitude and longitude.
- `timezones`: the country time zones.
- `languages`: the country languages, with:
  - `Name`: name of the language.
  - `ISO6391`: the 2 chars code of the language.
  - `ISO6392`: the 3 chars code of the language.
- `currencies`: the country currencies, with:
  - `Code`: code of the currency.
  - `Name`: the name of the currency.
  - `Symbol`: the symbol of the currency.
- `demonyms`: name of residents, translated & genderized, a collection of key-value pairs where:
  - `key`: three-letter ISO 639-3 language code.
  - `value`: genderized demonym object with:
    - `male`: the male resident name.
    - `female`: the female resident name.

here is a json representation of the country entity:

```json
{
  "Name": {
    "eng": { "Official": "Kingdom of Morocco", "Common": "Morocco" },
    "ara": { "Official": "المملكة المغربية", "Common": "المغرب" },
    "fra": { "Official": "Royaume du Maroc", "Common": "Maroc" },
    "spa": { "Official": "Reino de Marruecos", "Common": "Marruecos" }
  },
  "CCA2": "MA",
  "CCA3": "MAR",
  "CCN3": "504",
  "CIOC": "MAR",
  "Flag": "🇲🇦",
  "Region": 0,
  "Subregion": "Northern Africa",
  "Independent": true,
  "Status": "officially-assigned",
  "UnMember": true,
  "Landlocked": false,
  "IDD": { "Root": "+2", "Suffixes": ["12"] },
  "Borders": ["DZA", "ESH", "ESP"],
  "Capital": ["Rabat"],
  "AltSpellings": ["MA", "Kingdom of Morocco", "Al-Mamlakah al-Maġribiyah"],
  "TLD": [".ma", "المغرب."],
  "Latlng": [32, -5],
  "Timezones": ["UTC"],
  "Languages": [
    {
      "ISO6391": "ar",
      "ISO6392": "ara",
      "Name": "Arabic"
    },
    {
      "ISO6391": "",
      "ISO6392": "ber",
      "Name": "Berber"
    }
  ],
  "Currencies": [
    {
      "Code": "MAD",
      "Name": "Moroccan dirham",
      "Symbol": "د.م."
    }
  ],
  "Demonyms": {
    "eng": {
      "Male": "Moroccan",
      "Female": "Moroccan"
    },
    "fra": {
      "Male": "Moroccan",
      "Female": "Moroccan"
    }
  }
}
```

## Usage

### 1. working with names:

to get the name of the county you can do an implicit conversion to string with:

```csharp
// get the morocco country instance.
var morocco = Countries.Data.Morocco.Instance;

// the name prop is LocalizedCountryName object,
// but you can use the implicit conversion to get the name value.
string name = morocco.Name;
```

the name of the country is collection of translation of the common and official name, wrapped in a object type `LocalizedCountryName` this object type exposes 3 functions `GetName()`, `GetName(string languageCode)` & `GetName(string languageCode, bool useOfficialName)`

starting with `GetName(string languageCode, bool useOfficialName)` :

```csharp
// get the morocco country instance.
var morocco = Countries.Data.Morocco.Instance;

// get the official name of the country in the given language,
// this example with get the French official name of the country
// to use the common name, pass false instead of true.
var name = morocco.Name.GetName("fra", true);
```

this function will give you the name of the country in the given language and will return either the common or official name based on the `bool useOfficialName` parameters.

if no translation has been found for the given language, an exception will be thrown (this is applied to all 3 functions), if you don't want to throw an exception you can change this behavior with the static `WorldCountriesConfiguration` configuration class:

```csharp
// by setting the `ThrowIfNameNotFoundForALanguage` option to false, null will be returned instead of throwing the exception.
WorldCountriesConfiguration.ThrowIfNameNotFoundForALanguage = false;
```

for the function `GetName(string languageCode)` it same as the previous one, the only difference is that the type of the returned name (common or official) will be detrmined from `WorldCountriesConfiguration` configuration class

```csharp
// if set to `true` we will return the official name of the country when retrieving the name, 
// if set to `false` the common name will be used, by default is set to `true`
WorldCountriesConfiguration.UserOfficialNameWhenRetrievingCountryName = true;
```

finally the function `GetName()` it relays on the `WorldCountriesConfiguration` configuration class to do it job.  
for the language to be used for retrieving the name is determined with this 2 options:

- `DefaultLanguage`: the default language to be used when retrieving the name of the country with `GetName()` method, the default value is `eng`.
- `UseCurrentCultureInfoForCountryName`: if set to `true` the `CultureInfo.CurrentCulture` language will be used when retrieving the name, otherwise `DefaultLanguage` will be used, by default is set to `false`.

```csharp
// the default language to be used with `GetName()` when retrieving the name of the country
WorldCountriesConfiguration.DefaultLanguage = `eng`;

// true to use the current CultureInfo language instead of DefaultLanguage
WorldCountriesConfiguration.UseCurrentCultureInfoForCountryName = false;
```

with that we can say that the implicit conversion of the country name to string is simply using the `GetName()` under the hood

```csharp
public static implicit operator string(LocalizedCountryName names) => names.GetName();
```

-2 working the countries data:

all countries are located in the `Data` namespace, and you can interact with it using the `CountriesService`.

```csharp
// init the service
var service = new CountriesService();

// to get the list of all countries:
var countries = service.GetAll();

// find the country with the given CCA2, CCA3, CCN3 or CIOC code:
var country = service.FindByCode("MA");

// find the country by the name:
var country = service.FindByName("Maroc");

// find list of countries in a given region:
var countries = service.FindByRegion(Region.Africa);

// find list of countries using the given language code:
var countries = service.FindByLanguage("ara");

// find list of countries using the given currency code:
var countries = service.FindByCurrency("MAD");

// get the list of countries as key-value, where the key is Country.CCA2 and the value is the name:
KeyValuePair<string, string> countries = service.GetAsKeyValue();
```

you can find the list of all supported countries [here](https://github.com/YoussefSell/Countries.Net/blob/master/Countries.md).

## Credits

Thanks to:

- [RestCountries](https://restcountries.com) api for the countries data.
