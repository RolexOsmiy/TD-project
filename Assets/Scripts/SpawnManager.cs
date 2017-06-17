using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour {

    //Main code
    public GameObject WinOrLoseBar;
    public string[] StatusText;
    public GameObject[] Enemy;
    public Transform SpawnPossition;
    public int Enemy_Count = 5;
    public static int Enemy_Curr_Count;
    public float WaitMin = 15;
    bool waveOn = true;

    //UI
    Text ToWave;
    Text CurrentWave;
    float remainning_var;
    int curr_wave = 0;

    // Use this for initialization
    void Start()
    {
        remainning_var = WaitMin;
        ToWave = GameObject.Find("ToWave").gameObject.GetComponent<Text>();
        CurrentWave = GameObject.Find("CurrentWave").gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {               
        while (waveOn == true)
        {
            curr_wave++;            
            for (int i = 0; i < Enemy_Count; i++)
            {
                Instantiate(Enemy[0], SpawnPossition.transform.position, SpawnPossition.transform.rotation);
                Enemy_Curr_Count++;
            }
            waveOn = false;
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
        WinOrLoseBar.GetComponent<Text>().text = StatusText[0];
        WinOrLoseBar.SetActive(true);
        yield return new WaitForSeconds(WaitMin);
        WinOrLoseBar.SetActive(false);
    }
}

