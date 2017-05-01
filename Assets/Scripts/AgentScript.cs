using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour {

    public GameObject target;
    UnityEngine.AI.NavMeshAgent agent;
	// Use this for initialization
	void Start ()
    {
        target = GameObject.Find("Portal").gameObject;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    agent.SetDestination(target.transform.position);
	}

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Portal")
        {
            Destroy(this.gameObject);
        }
    }
}
