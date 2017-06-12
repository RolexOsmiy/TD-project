using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVars_Script : MonoBehaviour {

    public int money = 240;
    public Text MoneyText;
    public Transform[] EnemyArray;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoneyText.text = "Money: " + money;
	}

    public void MobPrice(int mobprice)
    {
        money += mobprice;
    }
}
