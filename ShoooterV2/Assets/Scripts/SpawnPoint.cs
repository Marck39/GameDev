using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public int EnemyCounter;

    public Transform[] SpawnPoints;

    public GameObject[] EnemyPrefabs;

    
    private void FixedUpdate()
    {
        
        while (EnemyCounter>0)
        {
            int Enemy = Random.Range(0, EnemyPrefabs.Length);
            int Spawns = Random.Range(0, SpawnPoints.Length);

            Instantiate(EnemyPrefabs[Enemy], SpawnPoints[Spawns].position, transform.rotation);
            EnemyCounter--;
            Debug.Log("spawned");
        }

    }
        

}
