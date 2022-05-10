using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{

    [SerializeField]
    private GameObject zombiePrefab;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(PublicVars.zombieInterval,zombiePrefab));
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval,GameObject enemy) {
        yield return new WaitForSeconds(interval);
        //GameObject newenemy = Instantiate(enemy, new Vector3(Random.Range(-30f,30),Random.Range(-30f,30f),0),Quaternion.identity);
        GameObject newenemy = Instantiate(enemy, new Vector3(Random.Range(-5f,5),Random.Range(-6f,6f),0),Quaternion.identity);
        StartCoroutine(spawnEnemy(interval,enemy));
    }
}
