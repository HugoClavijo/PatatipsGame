using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCanvas : MonoBehaviour
{

    string nameScene;

   // public void ChangeScene(string sceneName)
    // {
        //SceneManager.LoadScene(sceneName);
     //}

     ///<summary>Opens the scene immediately.</summary>
    public void OpenScene()    {
        // put your logic to open the scene here
        SceneManager.LoadScene(nameScene);
        
    }

    ///<summary>Opens the scene after a 0.3 second delay.</summary>
    public void OpenSceneWithWait(string sceneName)
    {
        nameScene = sceneName;
        Invoke("OpenScene", 0.2f);

    }

  

}
