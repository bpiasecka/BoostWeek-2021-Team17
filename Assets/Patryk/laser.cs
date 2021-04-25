using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class laser : MonoBehaviour
{

    public gracz lazer;

    public GameObject l1;
    public GameObject l2;

    public GameObject f1;
    public GameObject f2;

    public VisualEffect efect;
    public VisualEffect efect1;

    public bool gotowe = false;
    // Start is called before the first frame update
    void Start()
    {
        l1.SetActive(false);
        l2.SetActive(false);
        f1.SetActive(true);
        f2.SetActive(true);
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
            lazer.SwiatloOff();
            l1.SetActive(false);
            l2.SetActive(false);

            f1.SetActive(true);
            f2.SetActive(true);
            Debug.Log("niedzia³a");
        }

        if (PlayerPrefs.GetInt("energy") == 0)
        {
            lazer.SwiatloOff();
            l1.SetActive(false);
            l2.SetActive(false);

            f1.SetActive(true);
            f2.SetActive(true);
            Debug.Log("niedzia³a");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            gotowe = !gotowe;
           
        }

        if (PlayerPrefs.GetInt("energy") == 1)
        {
            if (gotowe == true)
            {
                lazer.SwiatloStart();
                l1.SetActive(true);
                l2.SetActive(true);

                f1.SetActive(false);
                f2.SetActive(false);

                efect.Stop();
                efect1.Stop();
                Debug.Log("dzia³a");
            }
        }
    }
}
