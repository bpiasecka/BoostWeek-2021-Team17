using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogien : MonoBehaviour
{

    public GameObject colider;

    public gracz fire;
    // Start is called before the first frame update
    void Start()
    {
        colider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("energy") == 0)
        {
            fire.OgienOff();
            colider.SetActive(false);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.Q))
        {
            if (PlayerPrefs.GetInt("energy") == 1)
            {
                fire.OgienStart();
                colider.SetActive(true);
            }
            
            //particle Play()
        }

        if (Input.GetKey(KeyCode.E))
        {
            //if (PlayerPrefs.GetInt("energy") == 1)
            //{
                fire.OgienOff();
                colider.SetActive(false);
            //}

            //particle Play()
        }
    }
}
