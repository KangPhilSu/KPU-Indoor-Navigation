using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStartPoint : MonoBehaviour
{
    public string Startpoint = null;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void setPoint(string str)
    {
        Startpoint = str;
    }

    public string getPoint()
    {
        return Startpoint;
    }
}
