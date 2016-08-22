// NULLcode Studio © 2015
// null-code.ru

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(NavMeshAgent))]

public class PlayerNavigation : MonoBehaviour {
	
	private NavMeshAgent nav;

	void Start () 
	{
		nav = GetComponent<NavMeshAgent>();
		CurrentNavigation.target = transform.position;
		//SelectUnits.unitSelected = transform.position;
	}

	void Update () 
	{
		CurrentNavigation.isPointer = nav.hasPath;
		nav.SetDestination(CurrentNavigation.target); //движение
		//SelectUnits.unitSelected;
	}
}
