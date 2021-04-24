using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed, damageValue;
    private Collider collider;

    public void Start()
    {
        collider = GetComponent<Collider>();
    }
    public void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Physics.IgnoreCollision(collision.collider, collider);
        }

        if (collision.gameObject.tag == "Car")
        {
            GameObject.FindObjectOfType<CarScript>().MakeDamage(damageValue);
            KillEnemy();
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerScript>().SetStartPosition();
            KillEnemy(); //really?
        }

    }

    public void KillEnemy()
    {
        Destroy(gameObject);
    }
}