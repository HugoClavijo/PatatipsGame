using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unPauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TogglePause();
        }

    }

    void TogglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            //return (false);
        }       
    }
}
