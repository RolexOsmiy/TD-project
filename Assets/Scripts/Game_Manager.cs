using UnityEngine;
using System.Collections;

public class Game_Manager : MonoBehaviour
{
    public GameObject Enemy_1;
    public Transform spawnValues;
    public int Enemy_1Count;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    static bool nextWaveOn = true;

    void Start()
    {
        StartCoroutine(SpawnWaves());
        StartCoroutine(BetweenWave());
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (nextWaveOn == true)
        {
            for (int i = 0; i < Enemy_1Count; i++)
            {           
                Instantiate(Enemy_1, spawnValues.transform.position, spawnValues.transform.rotation);
                yield return new WaitForSeconds(spawnWait);
            }
           yield return new WaitForSeconds(waveWait);            
        }
        nextWaveOn = false;
    }

    IEnumerator BetweenWave()
    {
        yield return new WaitForSeconds(waveWait);
        nextWaveOn = true;        
    }
}
