using UnityEngine;
using System.Collections;

public class Game_Manager : MonoBehaviour
{
    public GameObject Enemy_1;
    public Transform spawnValues;
    public int Enemy_1Count;
    public float spawnWait;
    public float startWait;
	//public float spawnWaveWait;
	public bool nextWaveOn = true;
	public GameObject[] enemyArray;
	public bool arrayCheck = false;

    void Start()
    {        
		
    }

	void Update()
	{
		foreach (var item in enemyArray) 
		{
			if (item != null) 
			{
				nextWaveOn = false;
			} 
		}

		if (nextWaveOn == true) 
		{
			StartCoroutine(SpawnWaves());
		}
	}

    IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds(startWait);
		while (nextWaveOn == true)
		{
            for (int i = 0; i < Enemy_1Count; i++)
            {           
				enemyArray[i] = Instantiate(Enemy_1, spawnValues.transform.position, spawnValues.transform.rotation);
                yield return new WaitForSeconds(spawnWait);
            }       
		}
	}
}

