using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeController : MonoBehaviour
{

    public GameObject Escape;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Escape.SetActive(true);
            return;
        }
    }

    public void clickEscape()
    {
        Application.Quit();
    }

    public void noEscape()
    {
        Escape.SetActive(false);
    }
}
