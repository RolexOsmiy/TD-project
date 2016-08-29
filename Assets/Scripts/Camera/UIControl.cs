using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

public class UIControl : NetworkBehaviour {
	
	public GameObject human;

	public override void OnStartLocalPlayer ()
	{
		human = GameObject.Find("Human");
		SetRace();
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void SetRace()
	{
		if(isLocalPlayer)
		{
			human.SetActive(true);
		}
	}
}
