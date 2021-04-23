using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveButtonScript : MonoBehaviour
{
    private CarScript car;
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.collider.gameObject.GetComponent<PlayerScript>() == null)
            return;
        if (car == null)
            car = GameObject.FindObjectOfType<CarScript>();
        car.OnDriveButtonClicked();
    }
}
