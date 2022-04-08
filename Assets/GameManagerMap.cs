using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManagerMap : MonoBehaviour
{
    List<Country> countryToFind = new List<Country>();
    [SerializeField] public Text title;
    [SerializeField] public Text questionText;
    [SerializeField] public Text rightAnswerText;
    private int index;
    private string answer;
    // Start is called before the first frame update
    void Start()
    {
        rightAnswerText.text = "";
        switch (PlayerPrefs.GetString("Continent"))
        {
            case "All":
                for (int j = 0; j < CountriesDatas.countriesDatas.Count; j++)
                {
                    countryToFind.Add(CountriesDatas.GetCountryById(j));
                }
                break;
            case "Europe":
                for (int j = 0; j < CountriesDatas.countriesDatas.Count; j++)
                {
                    if (CountriesDatas.GetCountryById(j).Continent == "Europe")
                    {
                        countryToFind.Add(CountriesDatas.GetCountryById(j));
                    }
                }
                break;
            case "Amérique":
                for (int j = 0; j < CountriesDatas.countriesDatas.Count; j++)
                {
                    if (CountriesDatas.GetCountryById(j).Continent == "Amérique")
                    {
                        countryToFind.Add(CountriesDatas.GetCountryById(j));
                    }
                }
                break;
            case "Afrique":
                for (int j = 0; j < CountriesDatas.countriesDatas.Count; j++)
                {
                    if (CountriesDatas.GetCountryById(j).Continent == "Afrique")
                    {
                        countryToFind.Add(CountriesDatas.GetCountryById(j));
                    }
                }
                break;
            case "Océanie":
                for (int j = 0; j < CountriesDatas.countriesDatas.Count; j++)
                {
                    if (CountriesDatas.GetCountryById(j).Continent == "Océanie")
                    {
                        countryToFind.Add(CountriesDatas.GetCountryById(j));
                    }
                }
                break;
            case "Asie":
                for (int j = 0; j < CountriesDatas.countriesDatas.Count; j++)
                {
                    if (CountriesDatas.GetCountryById(j).Continent == "Asie")
                    {
                        countryToFind.Add(CountriesDatas.GetCountryById(j));
                    }
                }
                break;
        }
        title.text = "Find " + PlayerPrefs.GetString("Find");
        NewQuestion();
    }
    public void NewQuestion()
    {
        index = Random.Range(0, countryToFind.Count - 1);
        switch (PlayerPrefs.GetString("Find"))
        {
            case "Country":
                answer = countryToFind[index].Name;
                questionText.text = countryToFind[index].Name;
                break;
            case "Capitale":
                answer = countryToFind[index].Name;
                questionText.text = countryToFind[index].Capitale;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Check(string name)
    {
        Debug.Log(name);
        if (name == answer)
        {
            if (countryToFind.Count > 1)
            {
                countryToFind.RemoveAt(index);
                NewQuestion();
                StartCoroutine(GoodAnswer(true));
            }
            else
                SceneController.Load("Main");
        }
        else
        {
            StartCoroutine(GoodAnswer(false));
        }
    }


    IEnumerator GoodAnswer(bool answer)
    {
        if (answer)
        {
            rightAnswerText.color = new Color(0, 133, 29);
            rightAnswerText.text = "Good Answer !";
        }
        else
        {
            rightAnswerText.color = Color.red;
            rightAnswerText.text = "Wrong Answer";
        }
        yield return new WaitForSecondsRealtime(1);
        rightAnswerText.text = "";
    }
}
