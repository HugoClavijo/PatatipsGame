using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameControl2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void BackScene2()
    {     
        GameControl.gameReplay2 = true;
        //SceneManager.LoadScene(scene);
    }

    public void Reset2()
    {
        GameControl.gameReplay2 = false;
        //SceneManager.LoadScene(scene);
    }


}
