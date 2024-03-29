﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class CountriesDatas : MonoBehaviour
{
    public CountriesDatas() { }

    public static Country GetCountryById(int id)
    {
        return countriesDatas[id];
    }

    public static Country GetCountryByName(string name)
    {
        foreach (var country in countriesDatas)
        {
            if (country.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                return country;
            }
        }
        Debug.Log($"Country {name} not found !");
        return null;
    }

    private void Start()
    {
        Country[] tmpCountries = FindObjectsOfType<Country>();
        for (int i = 0; i < tmpCountries.Length; i++)
        {
            tmpCountries[i].SetCountry(GetCountryByName(tmpCountries[i].Name));
        }
    }
#pragma warning disable
    public static List<Country> countriesDatas = new List<Country>(){
                new Country("Afghanistan"                      , "Kaboul"              , "Asie"    , "af"),
                new Country("Afrique du Sud"                   , "Pretoria"            , "Afrique" , "za"),
                new Country("Albanie"                          , "Tirana"              , "Europe"  , "al"),
                new Country("Algérie"                          , "Alger"               , "Afrique" , "dz"),
                new Country("Allemagne"                        , "Berlin"              , "Europe"  , "de"),
                new Country("Andorre"                          , "Andorre-la-Vieille"  , "Europe"  , "ad"),
                new Country("Angola"                           , "Luanda"              , "Afrique" , "ao"),
                new Country("Antigua-et-Barbuda"               , "Saint John's"        , "Amérique", "ag"),
                new Country("Arabie Saoudite"                  , "Riyad"               , "Asie"    , "sa"),
                new Country("Argentine"                        , "Buenos Aires"        , "Amérique", "ar"),
                new Country("Arménie"                          , "Erevan"              , "Asie"    , "am"),
                new Country("Australie"                        , "Canberra"            , "Océanie" , "au"),
                new Country("Autriche"                         , "Vienne"              , "Europe"  , "at"),
                new Country("Azerbaïdjan"                      , "Bakou"               , "Asie"    , "az"),
                new Country("Bahamas"                          , "Nassau"              , "Amérique", "bs"),
                new Country("Bahreïn"                          , "Manama"              , "Asie"    , "bh"),
                new Country("Bangladesh"                       , "Dacca"               , "Asie"    , "bd"),
                new Country("Barbade"                          , "BridGetown"          , "Amérique", "bb"),
                new Country("Belgique"                         , "Bruxelles"           , "Europe"  , "be"),
                new Country("Belize"                           , "Belmopan"            , "Amérique", "bz"),
                new Country("Bénin"                            , "Porto-Novo"          , "Afrique" , "bj"),
                new Country("Bhoutan"                          , "Thimbu"              , "Asie"    , "bt"),
                new Country("Biélorussie"                      , "Minsk"               , "Europe"  , "by"),
                new Country("Birmanie"                         , "Naypyidaw"           , "Asie"    , "mm"),
                new Country("Bolivie"                          , "Sucre"               , "Amérique", "bo"),
                new Country("Bosnie-Herzégovine"               , "Sarajevo"            , "Europe"  , "ba"),
                new Country("Botswana"                         , "Gaborone"            , "Afrique" , "bw"),
                new Country("Brésil"                           , "Brasilia"            , "Amérique", "br"),
                new Country("Brunei"                           , "Bandar Seri Begawan" , "Asie"    , "bn"),
                new Country("Bulgarie"                         , "Sofia"               , "Europe"  , "bg"),
                new Country("Burkina Faso"                     , "Ouagadougou"         , "Afrique" , "bf"),
                new Country("Burundi"                          , "Bujumbura"           , "Afrique" , "bi"),
                new Country("Cambodge"                         , "Phnom Penh"          , "Asie"    , "kh"),
                new Country("Cameroun"                         , "Yaounde"             , "Afrique" , "cm"),
                new Country("Canada"                           , "Ottawa"              , "Amérique", "ca"),
                new Country("Cap-Vert"                         , "Praia"               , "Afrique" , "cv"),
                new Country("Chili"                            , "Santiago"            , "Amérique", "cl"),
                new Country("Chine"                            , "Pekin"               , "Asie"    , "cn"),
                new Country("Chypre"                           , "Nicosie"             , "Europe"  , "cy"),
                new Country("Colombie"                         , "Bogota"              , "Amérique", "co"),
                new Country("Comores"                          , "Moroni"              , "Afrique" , "km"),
                new Country("Congo"                            , "Brazzaville"         , "Afrique" , "cg"),
                new Country("Corée du Nord"                    , "Pyongyang"           , "Asie"    , "kp"),
                new Country("Corée du Sud"                     , "Seoul"               , "Asie"    , "kr"),
                new Country("Costa Rica"                       , "San Jose"            , "Amérique", "cr"),
                new Country("Côte d'Ivoire"                    , "Yamoussoukro"        , "Afrique" , "ci"),
                new Country("Croatie"                          , "Zagreb"              , "Europe"  , "hr"),
                new Country("Cuba"                             , "La Havane"           , "Amérique", "cu"),
                new Country("Danemark"                         , "Copenhague"          , "Europe"  , "dk"),
                new Country("Djibouti"                         , "Djibouti"            , "Afrique" , "dj"),
                new Country("Dominique"                        , "Roseau"              , "Amérique", "dm"),
                new Country("Egypte"                           , "Le Caire"            , "Afrique" , "eg"),
                new Country("Émirats Arabes Unis"              , "Abu Dhabi"           , "Asie"    , "ae"),
                new Country("Équateur"                         , "Quito"               , "Amérique", "ec"),
                new Country("Érythree"                         , "Asmara"              , "Afrique" , "er"),
                new Country("Espagne"                          , "Madrid"              , "Europe"  , "es"),
                new Country("Estonie"                          , "Tallinn"             , "Europe"  , "ee"),
                new Country("Eswatini"                         , "Mbabane"             , "Afrique" , "sz"),
                new Country("États-Unis"                       , "Washington"          , "Amérique", "us"),
                new Country("Éthiopie"                         , "Addis-Abeba"         , "Afrique" , "et"),
                new Country("Fidji"                            , "Suva"                , "Océanie" , "fj"),
                new Country("Finlande"                         , "Helsinki"            , "Europe"  , "fi"),
                new Country("France"                           , "Paris"               , "Europe"  , "fr"),
                new Country("Gabon"                            , "Libreville"          , "Afrique" , "ga"),
                new Country("Gambie"                           , "Banjul"              , "Afrique" , "gm"),
                new Country("Géorgie"                          , "Tbilissi"            , "Asie"    , "ge"),
                new Country("Ghana"                            , "Accra"               , "Afrique" , "gh"),
                new Country("Grèce"                            , "Athenes"             , "Europe"  , "gr"),
                new Country("Grenade"                          , "Saint George's"      , "Amérique", "gd"),
                new Country("Guatémala"                        , "Guatemala"           , "Amérique", "gt"),
                new Country("Guinee"                           , "Conakry"             , "Afrique" , "gn"),
                new Country("Guinee equatoriale"               , "Malabo"              , "Afrique" , "gq"),
                new Country("Guinee-Bissau"                    , "Bissau"              , "Afrique" , "gw"),
                new Country("Guyana"                           , "Georgetown"          , "Amérique", "gy"),
                new Country("Haïti"                            , "Port-au-Prince"      , "Amérique", "ht"),
                new Country("Honduras"                         , "Tegucigalpa"         , "Amérique", "hn"),
                new Country("Hongrie"                          , "Budapest"            , "Europe"  , "hu"),
                new Country("Maurice"                          , "Port Louis"          , "Afrique" , "mu"),
                new Country("Inde"                             , "New Delhi"           , "Asie"    , "in"),
                new Country("Indonésie"                        , "Jakarta"             , "Asie"    , "id"),
                new Country("Irak"                             , "Bagdad"              , "Asie"    , "iq"),
                new Country("Iran"                             , "Teheran"             , "Asie"    , "ir"),
                new Country("Irlande"                          , "Dublin"              , "Europe"  , "ie"),
                new Country("Islande"                          , "Reykjavik"           , "Europe"  , "is"),
                new Country("Israël"                           , "Jerusalem"           , "Asie"    , "il"),
                new Country("Italie"                           , "Rome"                , "Europe"  , "it"),
                new Country("Jamaïque"                         , "Kingston"            , "Amérique", "jm"),
                new Country("Japon"                            , "Tokyo"               , "Asie"    , "jp"),
                new Country("Jordanie"                         , "Amman"               , "Asie"    , "jo"),
                new Country("Kazakhstan"                       , "Astana"              , "Asie"    , "kz"),
                new Country("Kenya"                            , "Nairobi"             , "Afrique" , "ke"),
                new Country("Kirghizistan"                     , "Bichkek"             , "Asie"    , "kg"),
                new Country("Kiribati"                         , "Tarawa"              , "Océanie" , "ki"),
                new Country("Kosovo"                           , "Pristina"            , "Europe"  , "xk"),
                new Country("Koweit"                           , "Koweit"              , "Asie"    , "kw"),
                new Country("Laos"                             , "Vientiane"           , "Asie"    , "la"),
                new Country("Lesotho"                          , "Maseru"              , "Afrique" , "ls"),
                new Country("Lettonie"                         , "Riga"                , "Europe"  , "lv"),
                new Country("Liban"                            , "Beyrouth"            , "Asie"    , "lb"),
                new Country("Liberia"                          , "Monrovia"            , "Afrique" , "lr"),
                new Country("Libye"                            , "Tripoli"             , "Afrique" , "ly"),
                new Country("Liechtenstein"                    , "Vaduz"               , "Europe"  , "li"),
                new Country("Lituanie"                         , "Vilnius"             , "Europe"  , "lt"),
                new Country("Luxembourg"                       , "Luxembourg"          , "Europe"  , "lu"),
                new Country("Macédoine du Nord"                , "Skopje"              , "Europe"  , "mk"),
                new Country("Madagascar"                       , "Antananarivo"        , "Afrique" , "mg"),
                new Country("Malaisie"                         , "Kuala Lumpur"        , "Asie"    , "my"),
                new Country("Malawi"                           , "Lilongwe"            , "Afrique" , "mw"),
                new Country("Maldives"                         , "Male"                , "Asie"    , "mv"),
                new Country("Mali"                             , "Bamako"              , "Afrique" , "ml"),
                new Country("Malte"                            , "La Valette"          , "Europe"  , "mt"),
                new Country("Maroc"                            , "Rabat"               , "Afrique" , "ma"),
                new Country("Marshall"                         , "Majuro"              , "Océanie" , "mh"),
                new Country("Mauritanie"                       , "Nouakchott"          , "Afrique" , "mr"),
                new Country("Mexique"                          , "Mexico"              , "Amérique", "mx"),
                new Country("Micronésie"                       , "Palikir"             , "Océanie" , "fm"),
                new Country("Moldavie"                         , "Chisinau"            , "Europe"  , "md"),
                new Country("Monaco"                           , "Monaco"              , "Europe"  , "mc"),
                new Country("Mongolie"                         , "Oulan-Bator"         , "Asie"    , "mn"),
                new Country("Monténégro"                       , "Podgorica"           , "Europe"  , "me"),
                new Country("Mozambique"                       , "Maputo"              , "Afrique" , "mz"),
                new Country("Namibie"                          , "Windhoek"            , "Afrique" , "na"),
                new Country("Nauru"                            , "Yaren"               , "Océanie" , "nr"),
                new Country("Nepal"                            , "Katmandou"           , "Asie"    , "np"),
                new Country("Nicaragua"                        , "Managua"             , "Amérique", "ni"),
                new Country("Niger"                            , "Niamey"              , "Afrique" , "ne"),
                new Country("Nigeria"                          , "Abuja"               , "Afrique" , "ng"),
                new Country("Norvège"                          , "Oslo"                , "Europe"  , "no"),
                new Country("Nouvelle-Zélande"                 , "Wellington"          , "Océanie" , "nz"),
                new Country("Oman"                             , "Mascate"             , "Asie"    , "om"),
                new Country("Ouganda"                          , "Kampala"             , "Afrique" , "ug"),
                new Country("Ouzbekistan"                      , "Tachkent"            , "Asie"    , "uz"),
                new Country("Pakistan"                         , "Islamabad"           , "Asie"    , "pk"),
                new Country("Palaos"                           , "Melekeok"            , "Océanie" , "pw"),
                new Country("Palestine"                        , "Jerusalem-Est"       , "Asie"    , "ps"),
                new Country("Panama"                           , "Panama"              , "Amérique", "pa"),
                new Country("Papouasie-Nouvelle-Guinee"        , "Port Moresby"        , "Océanie" , "pg"),
                new Country("Paraguay"                         , "Asuncion"            , "Amérique", "py"),
                new Country("Pays-Bas"                         , "Amsterdam"           , "Europe"  , "nl"),
                new Country("Pérou"                            , "Lima"                , "Amérique", "pe"),
                new Country("Philippines"                      , "Manille"             , "Asie"    , "ph"),
                new Country("Pologne"                          , "Varsovie"            , "Europe"  , "pl"),
                new Country("Portugal"                         , "Lisbonne"            , "Europe"  , "pt"),
                new Country("Qatar"                            , "Doha"                , "Asie"    , "qa"),
                new Country("République Centrafricaine"        , "Bangui"              , "Afrique" , "cf"),
                new Country("République Democratique du Congo" , "Kinshasa"            , "Afrique" , "cd"),
                new Country("République Dominicaine"           , "Saint-Domingue"      , "Amérique", "do"),
                new Country("Tchéquie"                         , "Prague"              , "Europe"  , "cz"),
                new Country("Roumanie"                         , "Bucarest"            , "Europe"  , "ro"),
                new Country("Royaume-Uni"                      , "Londres"             , "Europe"  , "gb"),
                new Country("Russie"                           , "Moscou"              , "Europe"  , "ru"),
                new Country("Rwanda"                           , "Kigali"              , "Afrique" , "rw"),
                new Country("Saint-Christophe-et-Niévès"       , "BasSeterre"          , "Amérique", "kn"),
                new Country("Saint-Marin"                      , "Saint-Marin"         , "Europe"  , "sm"),
                new Country("Saint-Vincent-et-les-Grenadines"  , "Kingstown"           , "Amérique", "vc"),
                new Country("Sainte-Lucie"                     , "Castries"            , "Amérique", "lc"),
                new Country("Salomon"                          , "Honiara"             , "Océanie" , "sb"),
                new Country("Salvador"                         , "San Salvador"        , "Amérique", "sv"),
                new Country("Samoa"                            , "Apia"                , "Océanie" , "ws"),
                new Country("Sao Tomé et Principe"             , "Sao Tome"            , "Afrique" , "st"),
                new Country("Sénégal"                          , "Dakar"               , "Afrique" , "sn"),
                new Country("Serbie"                           , "Belgrade"            , "Europe"  , "rs"),
                new Country("Seychelles"                       , "Victoria"            , "Afrique" , "sc"),
                new Country("Sierra Leone"                     , "Freetown"            , "Afrique" , "sl"),
                new Country("Singapour"                        , "Singapour"           , "Asie"    , "sg"),
                new Country("Slovaquie"                        , "Bratislava"          , "Europe"  , "sk"),
                new Country("Slovénie"                         , "Ljubljana"           , "Europe"  , "si"),
                new Country("Somalie"                          , "Mogadiscio"          , "Afrique" , "so"),
                new Country("Soudan"                           , "Khartoum"            , "Afrique" , "sd"),
                new Country("Soudan du Sud"                    , "Djouba"              , "Afrique" , "ss"),
                new Country("Sri Lanka"                        , "Sri Jayawardenapura" , "Asie"    , "lk"),
                new Country("Suède"                            , "Stockholm"           , "Europe"  , "se"),
                new Country("Suisse"                           , "Berne"               , "Europe"  , "ch"),
                new Country("Suriname"                         , "Paramaribo"          , "Amérique", "sr"),
                new Country("Syrie"                            , "Damas"               , "Asie"    , "sy"),
                new Country("Tadjikistan"                      , "Douchanbe"           , "Asie"    , "tj"),
                new Country("Taiwan"                           , "Taipei"              , "Asie"    , "tw"),
                new Country("Tanzanie"                         , "Dodoma"              , "Afrique" , "tz"),
                new Country("Tchad"                            , "N'Djamena"           , "Afrique" , "td"),
                new Country("Thailande"                        , "Bangkok"             , "Asie"    , "th"),
                new Country("Timor-Oriental"                   , "Dili"                , "Océanie" , "tl"),
                new Country("Togo"                             , "Lome"                , "Afrique" , "tg"),
                new Country("Tonga"                            , "Nukualofa"           , "Océanie" , "to"),
                new Country("Trinité-et-Tobago"                , "Port d'Espagne"      , "Amérique", "tt"),
                new Country("Tunisie"                          , "Tunis"               , "Afrique" , "tn"),
                new Country("Turkménistan"                     , "Achgabat"            , "Asie"    , "tm"),
                new Country("Turquie"                          , "Ankara"              , "Asie"    , "tr"),
                new Country("Tuvalu"                           , "Fanafuti"            , "Océanie" , "tv"),
                new Country("Ukraine"                          , "Kiev"                , "Europe"  , "ua"),
                new Country("Uruguay"                          , "Montevideo"          , "Amérique", "uy"),
                new Country("Vanuatu"                          , "Port-Vila"           , "Océanie" , "vu"),
                new Country("Vatican"                          , "Vatican"             , "Europe"  , "va"),
                new Country("Venezuela"                        , "Caracas"             , "Amérique", "ve"),
                new Country("Viêt Nam"                         , "Hanoi"               , "Asie"    , "vn"),
                new Country("Yémen"                            , "Sanaa"               , "Asie"    , "ye"),
                new Country("Zambie"                           , "Lusaka"              , "Afrique" , "zm"),
                new Country("Zimbabwe"                         , "Harare"              , "Afrique" , "zw"),
            };
#pragma warning restore
}

