using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawningTrigger : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemiesNumber;
    public float nextEnemySpawningDelay, spawningPlaceDistanceToCarX, spawningPlacePositionY, spawningPlacePositionZ;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            StartCoroutine(SpawnEnemies());
        }
    }

    private IEnumerator SpawnEnemies()
    {
        Transform car = GameObject.FindGameObjectWithTag("Car").transform;
        for(int i = 0; i < enemiesNumber; i++)
        {
            Instantiate(enemyPrefab, new Vector3(car.position.x + spawningPlaceDistanceToCarX, spawningPlacePositionY, spawningPlacePositionZ), enemyPrefab.transform.rotation);
            yield return new WaitForSeconds(nextEnemySpawningDelay);
        }
    }
}
