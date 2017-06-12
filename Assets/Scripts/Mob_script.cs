using UnityEngine;
using System.Collections.Generic;

public class Mob_script : MonoBehaviour
{
    public float Hp = 100;
    public int Price = 5; //цена за убийство моба
    GameObject target;
    GameObject managers;
    UnityEngine.AI.NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
        target = GameObject.Find("Portal").gameObject;
        managers = GameObject.Find("managers").gameObject;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
        if (Hp < 1)
        {
            managers.GetComponent<GlobalVars_Script>().MobPrice(Price);
            Destroy(this.gameObject);
            SpawnManager.Enemy_Curr_Count--;
        }
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Portal")
        {
            SpawnManager.Enemy_Curr_Count--;
            Destroy(this.gameObject);
        }
    }

    public void Damage(float damage)
    {
        Hp -= damage;
    }
}