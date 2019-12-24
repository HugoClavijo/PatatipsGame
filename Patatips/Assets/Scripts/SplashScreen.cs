using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    public Image splashImage;
    public Image splashImage2;
    public string loadLevel;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
        splashImage2.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(2.5f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
       // FadeIn2();
       // yield return new WaitForSeconds(2.5f);
       // FadeOut2();
       // yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(loadLevel);
    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }


    void FadeIn2()
    {
        splashImage2.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut2()
    {
        splashImage2.CrossFadeAlpha(0.0f, 2.5f, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
