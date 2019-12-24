using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public Image splashImage;
    // Start is called before the first frame update
    IEnumerator Start()
    {

        splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(1.5f);
        FadeOut();
       // yield return new WaitForSeconds(1.0f);
    }

    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
