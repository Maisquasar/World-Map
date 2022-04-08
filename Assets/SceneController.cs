using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Main")
            PlayerPrefs.DeleteAll();
    }

    public void Quit()
    {
        Application.Quit();
    }


    public void Return()
    {
        Load(PlayerPrefs.GetString("PrecedentScene"));
    }

    static public void Load(string sceneName)
    {
        PlayerPrefs.SetString("PrecedentScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(sceneName);
    }

    public void CheckGamemodeAndLaunch()
    {
        bool launch = false;
        string Find = PlayerPrefs.GetString("Find");
        string By = PlayerPrefs.GetString("By");
        if (Find != "" && By != "")
        {
            if (Find == "Country" && By == "Country")
            {
                launch = false;
            }
            else
            {
                if (PlayerPrefs.GetString("Continent") != "")
                    launch = true;
            }
        }
        if (launch)
        {
            if (By == "Map")
                Load("SampleScene");
            else
                Load("Questions");
        }
    }

    public void Select(int id)
    {
        if (id == 0)
        {
            PlayerPrefs.SetString("Find", EventSystem.current.currentSelectedGameObject.name);
        }
        else
        {
            PlayerPrefs.SetString("By", EventSystem.current.currentSelectedGameObject.name);
        }
    }
}
