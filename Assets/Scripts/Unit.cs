using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

	private NavMeshAgent _agent;
	private NavMeshAgent Agent;

	// Use this for initialization
	void Start () 
	{
		SelectUnits.unit.Add(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
