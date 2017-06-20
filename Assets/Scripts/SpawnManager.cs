using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour {
    public GameObject WinOrLoseBar;
    public GameObject Win;
    public GameObject Lose; 
    public static GameObject LosePrivate;
    public string StatusText;
    public GameObject[] Enemy;
    public Transform SpawnPossition;
    public int Enemy_Count = 5;
    public static int Enemy_Curr_Count;
    public float WaitMin = 15;
    bool waveOn = true;
    Text ToWave;
    Text CurrentWave;
    float remainning_var;
    public int curr_wave = 4;
    public int lastWave = 5;
    public GameObject EscMenu;
    void Start()
    {
        Time.timeScale = 1;
        LosePrivate = Lose;
        remainning_var = WaitMin;
        ToWave = GameObject.Find("ToWave").gameObject.GetComponent<Text>();
        CurrentWave = GameObject.Find("CurrentWave").gameObject.GetComponent<Text>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscMenu.SetActive(true);
            Time.timeScale = 0;
        }
        if (curr_wave == lastWave)
        {
            WinFunction();
        }
        else
        {
            while (waveOn == true)
            {
                curr_wave++;
                for (int i = 0; i < Enemy_Count; i++)
                {
                    Instantiate(Enemy[curr_wave - 1], SpawnPossition.transform.position, SpawnPossition.transform.rotation);
                    Enemy_Curr_Count++;
                }
                waveOn = false;
            }
        }
        if (Enemy_Curr_Count < 1)
        {
            StartCoroutine(TimeToNextWave());
            remainning_var = remainning_var - 1 * Time.deltaTime;            
            if (remainning_var < 1)
            {
                waveOn = true;
                remainning_var = WaitMin;                
            }            
        }        
        ToWave.text = "To Wave: " + (Mathf.RoundToInt(remainning_var));
        CurrentWave.text = "Current wave: " + curr_wave;
    }

    IEnumerator TimeToNextWave()
    {
        WinOrLoseBar.GetComponent<Text>().text = StatusText;
        WinOrLoseBar.SetActive(true);
        yield return new WaitForSeconds(WaitMin);
        WinOrLoseBar.SetActive(false);
    }

    public void WinFunction()
    {
        PlayerPrefs.SetInt("CurrentLevel", 1);
        PlayerPrefs.Save();
        Win.SetActive(true);
        Time.timeScale = 0;
    }

    public static void LoseFunction()
    {
        LosePrivate.SetActive(true);
        Time.timeScale = 0;
    }

    public void Next()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("CurrentLevel", +1);
        PlayerPrefs.Save();
        SceneManager.LoadScene(i + 1);
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        GlobalVars_Script.currMissed = 0;
        GlobalVars_Script.money = 240;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ClickQuit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void ClickReturn()
    {
        Time.timeScale = 1;
        EscMenu.SetActive(false);
    }
}

