using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPacket_Script : MonoBehaviour {

    public float damage = 60;
    public float speed = 1;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Target(gameObject);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<Mob_script>().Damage(damage);
            Destroy(this.gameObject);
        }
    }

    public void Target(GameObject target)
    {
        this.transform.LookAt(target.transform);
    }
}
