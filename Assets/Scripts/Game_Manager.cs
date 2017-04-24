using UnityEngine;
using System.Collections;

public class Game_Manager : MonoBehaviour {

    public static int enemy_less = 0;
    public int coldown = 10;
    public int[] Wave;
    public GameObject[] Enemy;
    public Transform SpawnPoint;
    int j;
    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {         
        if (enemy_less >= 1)
        {
            Debug.Log("RIP");
        }
        for (int i = 0; i < Wave[i]; i++)
        {
            Instantiate(Enemy[j], SpawnPoint.transform.position, SpawnPoint.transform.rotation);
            Wave[j] -= 1;
        }
        j++;
        StartCoroutine(Coldown());
	}

    IEnumerator Coldown()
    {
        yield return new WaitForSeconds(coldown);
    }
}
