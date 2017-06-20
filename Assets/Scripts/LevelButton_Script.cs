using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (MainMenu_script.CurrLevel + 1 >= int.Parse(this.gameObject.name))
        {
            this.GetComponent<Image>().color = new Vector4(40,0,110,255);
        }
        else
        {
            this.GetComponent<Image>().color = new Vector4(1, 1, 1, 1);
        }
    }
}
