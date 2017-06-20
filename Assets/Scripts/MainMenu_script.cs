using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu_script : MonoBehaviour {

    public GameObject Play;
    public GameObject Exit;
    public GameObject Levels;
    public GameObject[] LevelButtons;
    public static int CurrLevel = 1;
	void Start ()
    {
        CurrLevel = PlayerPrefs.GetInt("CurrentLevel");
    }
	void Update ()
    {
        
    }

    public void ClickPlay()
    {
        Play.SetActive(false);
        Exit.SetActive(false);
        Levels.SetActive(true);
    }

    public void ClickBack()
    {
        Play.SetActive(true);
        Exit.SetActive(true);
        Levels.SetActive(false);
    }

    public void ClickExit()
    {
        Application.Quit();
    }

    public void ResetProgress()
    {
        CurrLevel = 0;
    }
}
