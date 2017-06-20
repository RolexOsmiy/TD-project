using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPacket_Script : MonoBehaviour {

    public float damage;
    public float speed = 1;
    public static Transform target;
	void Start ()
    {
        StartCoroutine(Die());
	}
	void FixedUpdate ()
    {
        Target(gameObject);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<Mob_script>().Damage(damage);
            Destroy(this.gameObject);
        }
    }

    public void Target(GameObject _target)
    {        
        target = _target.transform;
        transform.LookAt(target);
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
