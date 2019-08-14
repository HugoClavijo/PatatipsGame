using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiniGameControl : MonoBehaviour
{
    private static GameObject whoWinsTxt, whoLoseTxt, whoWinsBtn, whoLoseBtn;

    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public GameObject audioBack;

    public static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        whoWinsTxt = GameObject.Find("WinTxt");
        whoWinsBtn = GameObject.Find("Play");
        whoLoseTxt = GameObject.Find("LoseTxt");
        whoLoseBtn = GameObject.Find("Replay");

        whoWinsTxt.gameObject.SetActive(false);
        whoWinsBtn.gameObject.SetActive(false);
        whoLoseTxt.gameObject.SetActive(false);
        whoLoseBtn.gameObject.SetActive(false);

        audioBack = GameObject.Find("BackgroundMini");

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (null != anim)
        {
            // play Bounce but start at a quarter of the way though
            anim.Play("Intro", 0, 0.25f);
        }


        if (MonsterControl.loser == true)
        {
            whoLoseBtn.gameObject.SetActive(true);
            whoLoseTxt.gameObject.SetActive(true);
            audioBack.GetComponent<AudioSource>().Stop();
        }

        if (MonsterControl.winner == true)
        {           
            whoWinsTxt.gameObject.SetActive(true);
            whoWinsBtn.gameObject.SetActive(true);
            audioBack.GetComponent<AudioSource>().Stop();

        }
    }

    public void ReplayMiniGame(string scene)
    {
        MonsterControl.loser = false;
        MonsterControl.winner = false;
        SceneManager.LoadScene(scene);     
    }

    public void BackScene(string scene)
    {
        MonsterControl.loser = false;
        MonsterControl.winner = false;
        GameControl.gameReplay = true;
        //GameControl.gameReplay2 = true;
        //GameControl.player1StartWaypoint = player1StartWaypoint;
        //GameControl.player2StartWaypoint = player2StartWaypoint;
        //Dice.ChangeTurn

        SceneManager.LoadScene(scene);

       // SceneManager.UnloadSceneAsync("MiniGameCat");
        //SceneManager.LoadSceneAsync(scene, LoadSceneMode.Additive);
    }

}
