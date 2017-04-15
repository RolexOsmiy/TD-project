using UnityEngine;
using System.Collections;

public class Skill_Control : MonoBehaviour {

	public static int skillpoints = 5;

	public static int skill1 = 0;
	public static int skill2 = 0;
	public static int skill3 = 0;

	// Use this for initialization
	void Start () 
	{
		if ((gameObject.name == "Tier1_Spell2") && (skillpoints > 0)) 
		{
			GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0);
		}
		if ((gameObject.name == "Tier1_Spell3") && (skillpoints > 0)) 
		{
			GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0);
		}
		if ((gameObject.name == "Tier1_Spell3") && (skillpoints > 0)) 
		{
			GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
