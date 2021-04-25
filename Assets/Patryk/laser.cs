using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{

    public gracz lazer;

    public GameObject l1;
    public GameObject l2;

    public bool gotowe = false;
    // Start is called before the first frame update
    void Start()
    {
        l1.SetActive(false);
        l2.SetActive(false);
        gotowe = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("energy") == 1)
        {
            if (gotowe == true)
            {
                lazer.SwiatloStart();
                l1.SetActive(true);
                l2.SetActive(true);
                Debug.Log("dzia³a");
            }
        }

        if (gotowe == false)
        {
            lazer.SwiatloOff();
            l1.SetActive(false);
            l2.SetActive(false);
            Debug.Log("niedzia³a");
        }

        if (PlayerPrefs.GetInt("energy") == 0)
        {
            lazer.SwiatloOff();
            l1.SetActive(false);
            l2.SetActive(false);
            Debug.Log("niedzia³a");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            gotowe = !gotowe;
           
        }
    }
}
