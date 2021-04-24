using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    public float speed;
    public float energyLevel, energyUsage, health;
    public bool isDriving = false;
    public gracz engine;

    void Start()
    {
    }

    void Update()
    {
        if(isDriving)
        {
            engine.SilnikStart();
            Drive();
        }

        if (PlayerPrefs.GetInt("energy") == 0)
        {
            isDriving = false;
        }

        if (!isDriving)
        {
            engine.SilnikOff();
        }
    }

    private void Drive()
    {
        //if (energyLevel > 0f)
        if (PlayerPrefs.GetInt("energy") == 1) 
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            energyLevel = Mathf.Max(energyLevel - energyUsage * Time.deltaTime, 0f);
        }
        else 
        {
            isDriving = false;
        }
    }

    public void OnDriveButtonClicked()
    {
        isDriving = !isDriving;
    }

    public void MakeDamage(float damageValue)
    {
        health -= damageValue;
        if (health <= 0)
            RestartLevel();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
