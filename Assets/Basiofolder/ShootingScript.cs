using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public float energyUsage;
    private CarScript car;
    public void Start()
    {
        car = GameObject.FindObjectOfType<CarScript>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnShotClicked();
        }
    }

    public void OnShotClicked()
    {
        if (car.energyLevel < energyUsage)
            return;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            Fireworks();
        }
        else
        {
            GameObject nearestEnemy = null;
            foreach (GameObject enemy in enemies)
            {
                if (nearestEnemy == null || nearestEnemy.transform.position.x > enemy.transform.position.x)
                {
                    nearestEnemy = enemy;
                }
            }
            nearestEnemy.GetComponent<EnemyScript>().KillEnemy();
            car.energyLevel -= energyUsage;
        }
    }

    private void Fireworks()
    {

    }
}