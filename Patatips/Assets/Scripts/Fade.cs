using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public Image splashImage;
    public Image splashImage2;
    public Image splashImage3;
    public Image splashImage4;
    
    public string loadLevel;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
        splashImage2.canvasRenderer.SetAlpha(0.0f);
        splashImage3.canvasRenderer.SetAlpha(0.0f);
        splashImage4.canvasRenderer.SetAlpha(0.0f); 

        FadeIn();
        yield return new WaitForSeconds(4.0f);
        FadeOut();
        yield return new WaitForSeconds(3.0f);
        FadeIn2();
        yield return new WaitForSeconds(4.0f);
        FadeOut2();
        yield return new WaitForSeconds(3.0f);
        FadeIn3();
        yield return new WaitForSeconds(4.0f);
        FadeOut3();
        yield return new WaitForSeconds(3.0f);
        FadeIn4();
        yield return new WaitForSeconds(4.0f);
        FadeOut4();
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(loadLevel);
    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeIn2()
    {
        splashImage2.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeIn3()
    {
        splashImage3.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeIn4()
    {
        splashImage4.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }

    void FadeOut2()
    {
        splashImage2.CrossFadeAlpha(0.0f, 2.5f, false);
    }

    void FadeOut3()
    {
        splashImage3.CrossFadeAlpha(0.0f, 2.5f, false);
    }

    void FadeOut4()
    {
        splashImage4.CrossFadeAlpha(0.0f, 2.5f, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
