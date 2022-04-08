using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuSettings : MonoBehaviour
{
    [SerializeField] bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(isActive);
    }

    public void ShowMenu()
    {
        isActive = !isActive;
        gameObject.SetActive(isActive);
    }

    public void SelectContinent()
    {
        PlayerPrefs.SetString("Continent", EventSystem.current.currentSelectedGameObject.name);
        ShowMenu();
    }
}
