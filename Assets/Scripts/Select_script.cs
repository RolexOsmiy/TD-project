using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select_script : MonoBehaviour {
    //UI
    public Text currentHpText;
    float maxHpText;
    public Text damageText;
    public Text attackSpeedText;

    public GameObject selectUnit;   

    // Use this for initialization
    void Awake()
    {
        currentHpText = GameObject.Find("currentHp").gameObject.GetComponent<Text>();
        damageText = GameObject.Find("damage").gameObject.GetComponent<Text>();
        attackSpeedText = GameObject.Find("attackSpeed").gameObject.GetComponent<Text>();
    }



    // Update is called once per frame
    void Update()
    {
        currentHpText.text = selectUnit.GetComponent<Tower_Script>().currentHp + "/" + selectUnit.GetComponent<Tower_Script>().maxHp;
        damageText.text = selectUnit.GetComponent<Tower_Script>().damage + "";
        attackSpeedText.text = selectUnit.GetComponent<Tower_Script>().AttackSpeed + "";
        selectUnit.GetComponent<Tower_Script>().ShowUI();
    } 
}
