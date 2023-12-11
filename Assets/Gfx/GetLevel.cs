using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLevel : MonoBehaviour
{
    int level = 0;
    public GameObject level2, level2Locked, level3, level3locked, level4, level4locked, level5, level5locked, level6, level6locked, level7, level7locked, level8, level8locked, level9, level9Locked;


    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey ("Level"))
        {
            PlayerPrefs.SetInt("Level", level);  
        } 
        else
        {
             level = PlayerPrefs.GetInt("Level");
        }
       


        if(level < 2)
        {
            GameObject.Find("Level 1").SetActive(true);
        }

        if (level >= 2)
        {
            level2.SetActive(true);
            level2Locked.SetActive(false);
        }
        if (level >= 3)
        {
            level3.SetActive(true);
            level3locked.SetActive(false);
        }
         if (level >= 4)
        {
            level4.SetActive(true);
            level4locked.SetActive(false);
        }
         if (level >= 5)
        {
            level5.SetActive(true);
            level5locked.SetActive(false);
        }
         if (level >= 6)
        {
            level6.SetActive(true);
            level6locked.SetActive(false);
        }
         if (level >= 7)
        {
            level7.SetActive(true);
            level7locked.SetActive(false);
        }
         if (level >= 8)
        {
            level8.SetActive(true);
            level8locked.SetActive(false);
        }
         if (level >= 9)
        {
            level9.SetActive(true);
            level9Locked.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
