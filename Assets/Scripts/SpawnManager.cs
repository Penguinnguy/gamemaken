using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int yPos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        // Start the enemy spawns
        StartCoroutine(EnemySpawn());
    }
    //Spawns enemies in a while loop
    IEnumerator EnemySpawn()
    {
        while(true)
        {
            //Random range spawner
            xPos = Random.Range(-9, 9);
            yPos = Random.Range(-5, 5);
            Instantiate(enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            enemyCount += 1;
        }
    }
}