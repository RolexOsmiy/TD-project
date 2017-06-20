using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Select_script : MonoBehaviour
{
    public Text currentHpText;
    float maxHpText;
    public Text damageText;
    public Text attackSpeedText;
    public GameObject selectUnit;
    public GameObject UpgradeButton;
    public Text UpgradePrice;
    void Awake()
    {
        currentHpText = GameObject.Find("currentHp").gameObject.GetComponent<Text>();
        damageText = GameObject.Find("damage").gameObject.GetComponent<Text>();
        attackSpeedText = GameObject.Find("attackSpeed").gameObject.GetComponent<Text>();
    }
    void Update()
    {
        if (selectUnit && selectUnit.GetComponent<Tower_Script>().tower == true)
        {
            if (selectUnit.GetComponent<Tower_Script>().upgradet == false)
            {
                ShowUI();
            }
            else
            {
                HideUI();
            }
            UpgradePrice.text = selectUnit.gameObject.GetComponent<Tower_Script>().UpgradePrice + "";
            currentHpText.text = selectUnit.GetComponent<Tower_Script>().currentHp + "/" + selectUnit.GetComponent<Tower_Script>().maxHp;
            damageText.text = selectUnit.GetComponent<Tower_Script>().damage + "";
            attackSpeedText.text = selectUnit.GetComponent<Tower_Script>().AttackSpeed + "";
        }
        else
        {
            UpgradePrice.text = 0 + "";
            currentHpText.text = 0 + "/" + 0;
            damageText.text = 0 + "";
            attackSpeedText.text = 0 + "";
            HideUI();
        }
    }
    public void ShowUI()
    {
        UpgradeButton.SetActive(true);
    }

    public void HideUI()
    {
        UpgradeButton.SetActive(false);
    }

    public void UpgradeClick()
    {
        selectUnit.gameObject.GetComponent<Tower_Script>().Upgrade();
    }
}
