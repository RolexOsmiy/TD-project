using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildInfo_script : MonoBehaviour {

    public string Name;
    public string Description;
    public Text NameText;
    public Text DescriptionText;
    public Text Damage;
    public Text AttackSpeed;
    public GameObject Panel;
    public GameObject Tower;
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        Panel.transform.position = Input.mousePosition;
	}

    public void Show()
    {
        NameText.text = this.Name;
        DescriptionText.text = this.Description;
        Damage.text = "Damage: " + this.Tower.GetComponent<Tower_Script>().damage;
        AttackSpeed.text = "Attack speed: " + this.Tower.GetComponent<Tower_Script>().AttackSpeed;
        Panel.SetActive(true);
    }

    public void Hide()
    {
        Debug.Log("Hide");
        Panel.SetActive(false);
    }
}
