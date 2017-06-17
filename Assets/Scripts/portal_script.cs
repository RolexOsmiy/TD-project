using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_script : MonoBehaviour {
    [SerializeField]
    Vector3 size;

    void Start()
    {
        StartCoroutine(Check());
    }

    IEnumerator Check()
    {
        while (true)
        {
            Collider[] objs = Physics.OverlapBox(transform.position, size);
            foreach (var item in objs)
            {
                if (item.tag == "Enemy")
                {
                    SpawnManager.Enemy_Curr_Count--;
                    Destroy(item.gameObject);
                }
            }
            yield return new WaitForSeconds(0.2f);
        }
    }

    void OnDrawGizmos()
    {
        //Gizmos.DrawCube(transform.position, size);
    }

	//void OnTriggerEnter(Collider col)
 //   {
 //       if (col.tag == "Enemy")
 //       {
 //           Destroy(col.gameObject);
 //       }
 //   }


}
