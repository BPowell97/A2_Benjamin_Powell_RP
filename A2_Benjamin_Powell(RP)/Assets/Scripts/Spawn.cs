using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject fish;
    public Vector3 spawnValues;
    public int enemyCount;
    public int fishCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float fishspawnWait;
    public float fishstartWait;
    public float fishwaveWait;

    void Start()
    {
        StartCoroutine(SpawnWaves());
        StartCoroutine(FishSpawnWaves());
        //SpawnWaves();
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < enemyCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(enemy, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }

    IEnumerator FishSpawnWaves()
    {
        yield return new WaitForSeconds(fishstartWait);
        while (true)
        {
            for (int i = 0; i < fishCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(fish, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(fishspawnWait);
            }
            yield return new WaitForSeconds(fishwaveWait);
        }
    }
}

