using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRange_Script : MonoBehaviour {

    public float Radius = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.GetComponent<SphereCollider>().radius = Radius;
	}

    public void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Enemy" && Tower_Script.Target == null)
        {
            Tower_Script.Target = col.gameObject;
        }
    }

    public void OnCollisionExit(Collision col)
    {
        Tower_Script.Target = null;        
    }
}
