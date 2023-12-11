using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pref : MonoBehaviour
{
    public int levelnum;
    void Start()
    {
        PlayerPrefs.SetInt("Level", levelnum);
    }

}
