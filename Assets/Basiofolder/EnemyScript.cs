using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed, damageValue;
    private Collider collider;
    private Rigidbody rb;
    private CarScript car;

    public void Start()
    {
        collider = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        car = GameObject.FindObjectOfType<CarScript>();
    }
    public void Update()
    {
        transform.Translate(new Vector3(Time.deltaTime * (car.transform.position.x < transform.position.x ? -speed : speed), 0f, 0f));
        //transform.RotateAround(transform.position, new Vector3(0f, 0f, 1f), (car.transform.position.x < transform.position.x ? speed : -speed) * 5 * Time.deltaTime);
        //transform.localEulerAngles += new Vector3(0f, 0f, (car.transform.position.x < transform.position.x ? speed : -speed) * 5 * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Physics.IgnoreCollision(collision.collider, collider);
        }

        if (collision.gameObject.tag == "Car")
        {
            car.MakeDamage(damageValue);
            KillEnemy();
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerScript>().SetStartPosition();
            KillEnemy();
        }

    }

    public void KillEnemy()
    {
        Destroy(gameObject);
    }
}