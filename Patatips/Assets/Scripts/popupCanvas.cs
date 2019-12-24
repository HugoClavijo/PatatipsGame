using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupCanvas : MonoBehaviour
{
     GameObject popup0;
     GameObject popup1;
     GameObject popup2;
     GameObject popup3;
     GameObject popup4;
    public GameObject dice;
    //private static GameObject popup;

    // Start is called before the first frame update
    void Start()
    {
        dice = GameObject.Find("Dice");
        popup0 = GameObject.Find("PanelInst");
        popup1 = GameObject.Find("PanelBath");
        popup2 = GameObject.Find("PanelFood");
        popup3 = GameObject.Find("PanelBrush");
        popup4 = GameObject.Find("PanelVet");
    }

    public void ClosePopup()
    {
        //popup = GameObject.Find(names);
        //popup.SetActive(false);
        //popup0.SetActive(false);
        dice.gameObject.SetActive(true);
        popup1.SetActive(false);
        popup2.SetActive(false);
        popup3.SetActive(false);
        popup4.SetActive(false);

    }

    public void OpenPop()
    {
      popup0.SetActive(true);
    }

    public void ClosePop()
    {
        popup0.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
