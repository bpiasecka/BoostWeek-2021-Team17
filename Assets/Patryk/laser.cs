using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{

    public gracz lazer;

    public GameObject l1;
    public GameObject l2;

    public bool gotowe;
    // Start is called before the first frame update
    void Start()
    {
        gotowe = false;
        l1.SetActive(false);
        l2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(gotowe == false)
            {
                gotowe = true;
                lazer.SwiatloStart();
                l1.SetActive(true);
                l2.SetActive(true);
            }

            if (gotowe == true)
            {
                gotowe = false;
                lazer.SwiatloOff();
                l1.SetActive(false);
                l2.SetActive(false);
            }
        }
    }
}
