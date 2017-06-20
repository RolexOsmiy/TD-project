using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRange_Script : MonoBehaviour {

    public float Radius = 5;
	void Update ()
    {
        this.GetComponent<SphereCollider>().radius = Radius;
	}

    public void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Enemy" && transform.parent.GetComponent<Tower_Script>().Target == null)
        {
            transform.parent.GetComponent<Tower_Script>().Target = col.gameObject;
        }
    }    
}
