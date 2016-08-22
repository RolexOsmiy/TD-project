using UnityEngine;
using System.Collections;

public class EnemyNavigation : MonoBehaviour {

	private NavMeshAgent nav;
	public float range;

	void Start () 
	{
		EnemyCurrentNavigation.target = GameObject.FindGameObjectWithTag ("King").transform.position;
		//target = GameObject.FindGameObjectWithTag ("Player");
		nav = GetComponent<NavMeshAgent>();
	}

	void Update () 
	{
		EnemyCurrentNavigation.isPointer = nav.hasPath;
		nav.SetDestination(EnemyCurrentNavigation.target);
	}
}