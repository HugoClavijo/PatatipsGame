using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupInst2 : MonoBehaviour
{
    public GameObject popup0;
    public GameObject popup1;
    public GameObject popup2;
    public GameObject popup3;
    // Start is called before the first frame update
    void Start()
    {
        popup0 = GameObject.Find("PanelInst");
        popup1 = GameObject.Find("PanelInst1");
        //popup0.SetActive(true);
        //popup1.SetActive(false);

        popup2 = GameObject.Find("PanelInst2");
        popup3 = GameObject.Find("PanelInst3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OpenPop1()
    {
        //popup = GameObject.Find(name);
        popup1.SetActive(true);
        popup0.SetActive(false);
        //popup2.SetActive(false);
        //popup3.SetActive(false);
        //popup3.SetActive(false);
    }

    public void OpenPop2()
    {
        //popup = GameObject.Find(name);
        popup2.SetActive(true);
        popup1.SetActive(false);
    }

    public void OpenPop3()
    {
        //popup = GameObject.Find(name);
        popup3.SetActive(true);
        popup2.SetActive(false);
    }


    public void ClosePop3()
    {
        //popup = GameObject.Find(name);
        popup3.SetActive(false);
        // popup2.SetActive(false);
    }



}
