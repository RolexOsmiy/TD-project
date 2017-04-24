using UnityEngine;
using System.Collections;

public class qwrty : MonoBehaviour {

    public int speed = 5;
    Vector3 newpos;
	// Use this for initialization
	void Start () {
        newpos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-Vector3.left * speed * Time.deltaTime);
	}
}
