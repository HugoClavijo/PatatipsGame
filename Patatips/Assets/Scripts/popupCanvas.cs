using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupCanvas : MonoBehaviour
{
    private static GameObject popup1;
    private static GameObject popup2;
    //string popupName;
    // Start is called before the first frame update
    void Start()
    {
        popup1 = GameObject.Find("PanelBath");
        popup2 = GameObject.Find("PanelFood");
    }

    public void ClosePopup()
    {     
      popup1.gameObject.SetActive(false);
      popup2.gameObject.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
