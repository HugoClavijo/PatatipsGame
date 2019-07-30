using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour
{
     public GameObject closePop;
    private Button close;

    // Start is called before the first frame update
    void Start()
    {
        //close.GetComponent<Button>();
        //close.onClick.AddListener(QuitGame);
    }

    private void QuitGame()
    {

        Application.Quit();
    }


    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
          //  Instantiate(closePop);
    }
}
