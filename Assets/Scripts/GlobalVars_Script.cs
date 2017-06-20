using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVars_Script : MonoBehaviour {

    public int maxMissedPub;
    public static int maxMissed = 10;
    public static int currMissed = 0;
    public static int money = 240;
    public Text MoneyText;
    public Text MissedText;
    public Transform[] EnemyArray;
	void Update ()
    {
        if (currMissed == maxMissed)
        {
            SpawnManager.LoseFunction();
        }
        maxMissed = maxMissedPub;
        MissedText.text = "Missed: " + currMissed + "/" + maxMissed;
        MoneyText.text = "Money: " + money;
	}

    public void MobPrice(int mobprice)
    {
        money += mobprice;
    }
}
