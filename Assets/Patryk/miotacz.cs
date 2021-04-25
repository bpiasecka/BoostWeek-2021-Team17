using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miotacz : MonoBehaviour
{
    public gracz fire;

    public GameObject ogien1;
    public GameObject ogien2;





    public bool gotowe = false;
    // Start is called before the first frame update
    void Start()
    {
        ogien1.SetActive(false);
        ogien2.SetActive(false);
        
        gotowe = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (PlayerPrefs.GetInt("energy") == 1)
        //{
        //    if (gotowe == true)
        //    {
        //        lazer.SwiatloStart();
        //        l1.SetActive(true);
        //        l2.SetActive(true);

        //        f1.SetActive(false);
        //        f2.SetActive(false);

        //        efect.Stop();
        //        efect1.Stop();
        //        Debug.Log("dzia³a");
        //    }
        //}

        if (gotowe == false)
        {
            fire.OgienOff();
            ogien1.SetActive(false);
            ogien2.SetActive(false);

        

            Debug.Log("niedzia³a");
        }

        if (PlayerPrefs.GetInt("energy") == 0)
        {
            fire.OgienOff();
            ogien1.SetActive(false);
            ogien2.SetActive(false);
            Debug.Log("niedzia³a");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            gotowe = !gotowe;

        }

        if (PlayerPrefs.GetInt("energy") == 1)
        {
            if (gotowe == true)
            {
                fire.OgienStart();
                ogien1.SetActive(true);
                ogien2.SetActive(true);
                Debug.Log("dzia³a");
            }
        }
    }
}
