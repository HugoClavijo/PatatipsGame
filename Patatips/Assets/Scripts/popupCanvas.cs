﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupCanvas : MonoBehaviour
{
   // private static GameObject popup1;
   // private static GameObject popup2;
   // private static GameObject popup3;
   // private static GameObject popup4;
    private static GameObject popup;

    // Start is called before the first frame update
    void Start()
    {
        //popup1 = GameObject.Find("PanelBath");
       // popup2 = GameObject.Find("PanelFood");
        //popup3 = GameObject.Find("PanelBrush");
        //popup4 = GameObject.Find("PanelVet");
    }

    public void ClosePopup(string names)
    {
        popup = GameObject.Find(names);
        popup.SetActive(false);

        // popup1.gameObject.SetActive(false);
        // popup2.gameObject.SetActive(false);
        // popup3.gameObject.SetActive(false);
        // popup4.gameObject.SetActive(false);

    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
