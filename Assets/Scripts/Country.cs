using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static CountriesDatas;

public class Country : MonoBehaviour
{
    [HideInInspector] public string Name;
    [HideInInspector] public string Capitale;
    [HideInInspector] public string Continent;
    [HideInInspector] public string Iso;
    [HideInInspector] public Texture2D Flag;

    GameManagerMap GMmap;

    public void Start()
    {
        Name = name;
        GMmap = FindObjectOfType<GameManagerMap>();
    }
#pragma warning disable
    public Country(string country, string capitale, string continent, string iso)
    {
        Name = country;
        Capitale = capitale;
        Continent = continent;
        Iso = iso;
    }
#pragma warning restore
    public void SetCountry(Country tmp)
    {
        Debug.Log(Name);
        Name = tmp.Name;
        Debug.Log(tmp.Name);
        Capitale = tmp.Capitale;
        Continent = tmp.Continent;
        Iso = tmp.Iso;
    }

    private void OnMouseUpAsButton()
    {
        GMmap.Check(Name);
    }

}
