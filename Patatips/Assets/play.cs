using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public GameObject playPop;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("ChangeScene", 2);
    }

    public void ChangeScsene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    ///<summary>Opens the scene immediately.</summary>
    public void OpenScene()    {
        // put your logic to open the scene here
        SceneManager.LoadScene("SelectPlayer");
    }

    ///<summary>Opens the scene after a 0.3 second delay.</summary>
    public void OpenSceneWithWait()
    {
        Invoke("OpenScene", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(playPop);
            OpenSceneWithWait();
        }
           
    }
}
