using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelection : MonoBehaviour
{
    Color Default;
    Button current;
    [SerializeField] List<Button> others;
    // Start is called before the first frame update
    void Start()
    {
        current = GetComponent<Button>();
        Default = current.colors.normalColor;
        current.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        var tmp = current.colors;
        tmp.normalColor = tmp.selectedColor;
        current.colors = tmp;

        foreach (var other in others)
        {
            var tmp2 = other.colors;
            tmp2.normalColor = Default;
            other.colors = tmp2;
        }
    }
}
