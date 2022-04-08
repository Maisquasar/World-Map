using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Text;
using System.Globalization;

public class GameManager : MonoBehaviour
{
    List<Country> countryToFind = new List<Country>();
    [SerializeField] public Text title;
    [SerializeField] public SpriteRenderer questionImage;
    [SerializeField] public Text questionText;
    [SerializeField] public Text rightAnswerText;
    [SerializeField] public Text AnswerText;
    [SerializeField] public Text NumberText;
    [SerializeField] public InputField input;

    string answer;
    private int index;
    private int sizeAtStart;

    void Start()
    {
        AnswerText.enabled = false;
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
        if (PlayerPrefs.GetString("By") != "Flag")
            questionImage.gameObject.SetActive(false);
        else
            questionText.gameObject.SetActive(false);
        sizeAtStart = countryToFind.Count;
        NewQuestion();
    }
    public void NewQuestion()
    {
        index = Random.Range(0, countryToFind.Count - 1);
        switch (PlayerPrefs.GetString("By"))
        {
            case "Country":
                questionText.text = countryToFind[index].Name;
                break;
            case "Capitale":
                questionText.text = countryToFind[index].Capitale;
                break;
            case "Flag":
                Texture2D tmp = (Texture2D)AssetDatabase.LoadAssetAtPath($"Assets/Flags/{countryToFind[index].Iso}.png", typeof(Texture2D));
                if (tmp == null)
                    Debug.LogWarning($"Flag Assets/Flags/{countryToFind[index].Iso}.png not found");
                if (countryToFind[index].Flag == null)
                    countryToFind[index].Flag = tmp;
                questionImage.sprite = Sprite.Create(countryToFind[index].Flag, new Rect(0, 0, countryToFind[index].Flag.width, countryToFind[index].Flag.height), new Vector2(0.5f, 0.5f));
                break;
        }
        switch (PlayerPrefs.GetString("Find"))
        {
            case "Country":
                answer = countryToFind[index].Name;
                break;
            case "Capitale":
                answer = countryToFind[index].Capitale;
                break;
        }
        AnswerText.text = answer;
    }

    private void Update()
    {
        input.ActivateInputField();
        NumberText.text = $"{sizeAtStart - countryToFind.Count}/{sizeAtStart}";
    }

    public void Check()
    {
        if (!endOfGoodAnswer)
            return;
        StartCoroutine(GoodAnswer(DiceCoefficient(input.text, answer) > 0.6f));
    }

    public void ShowAnswer()
    {
        AnswerText.enabled = !AnswerText.enabled;
    }

    public static double DiceCoefficient(string strA, string strB)
    {
        strA = RemoveDiacritics(strA.ToLower());
        strB = RemoveDiacritics(strB.ToLower());
        HashSet<string> setA = new HashSet<string>();
        HashSet<string> setB = new HashSet<string>();

        for (int i = 0; i < strA.Length - 1; ++i)
            setA.Add(strA.Substring(i, 2));

        for (int i = 0; i < strB.Length - 1; ++i)
            setB.Add(strB.Substring(i, 2));

        HashSet<string> intersection = new HashSet<string>(setA);
        intersection.IntersectWith(setB);

        return (2.0 * intersection.Count) / (setA.Count + setB.Count);
    }

    static string RemoveDiacritics(string text)
    {
        var normalizedString = text.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

        for (int i = 0; i < normalizedString.Length; i++)
        {
            char c = normalizedString[i];
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder
            .ToString()
            .Normalize(NormalizationForm.FormC);
    }

    bool endOfGoodAnswer = true;
    IEnumerator GoodAnswer(bool answer)
    {

        endOfGoodAnswer = false;
        Color tmp = input.textComponent.color;
        if (input.text != "")
        {
            if (answer)
            {
                if (countryToFind.Count >= 1)
                    countryToFind.RemoveAt(index);
                rightAnswerText.color = Colors.darkGreen;
                rightAnswerText.text = "Good Answer !";
                input.textComponent.color = Colors.darkGreen;
                input.text = this.answer;
            }
            else
            {
                rightAnswerText.color = Color.red;
                rightAnswerText.text = "Wrong Answer";
                input.textComponent.color = Color.red;
            }
            yield return new WaitForSecondsRealtime(1);
            rightAnswerText.text = "";
            input.textComponent.color = tmp;

            if (answer)
            {
                if (countryToFind.Count < 1)
                    SceneController.Load("Main");
                else
                {
                    NewQuestion();
                    input.text = "";
                }
            }
        }
        endOfGoodAnswer = true;
    }
}
