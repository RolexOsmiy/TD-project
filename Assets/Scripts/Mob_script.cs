using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;

public class Mob_script : MonoBehaviour
{
    public Animator myAnimator;
    private float Hp = 100;
    public float maxHp = 100;
    public int Price = 5; //цена за убийство моба
    public Image HealthBar;
    GameObject target;
    GameObject managers;
    UnityEngine.AI.NavMeshAgent agent;
    bool death;
    void Start()
    {        
        maxHp = Hp;
        target = GameObject.Find("Portal").gameObject;
        managers = GameObject.Find("managers").gameObject;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    void Update()
    {
        if (Hp > 1)
        {
            myAnimator.SetBool("Death", false);
            HealthBar.rectTransform.localScale = new Vector3(Hp / maxHp, 1, 1);
            agent.SetDestination(target.transform.position);
        }
        else if (Hp < 1)
        {
            gameObject.tag = "Untagged";            
            StartCoroutine(Death());
            if (death == false)
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                agent.Stop(true);
                managers.GetComponent<GlobalVars_Script>().MobPrice(Price);
                myAnimator.SetBool("Death", true);
                SpawnManager.Enemy_Curr_Count--;                
                death = true;
            }
        }
    }    

    public void OnTriggerExit(Collider col)
    {
        col.transform.parent.GetComponent<Tower_Script>().Target = null;
    }

    public void Damage(float damage)
    {       
        Hp -= damage;
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}