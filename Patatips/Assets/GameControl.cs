﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;
    GameObject popupbath, popupfood, popupbrush, popupvet;

    private static GameObject player1, player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;
    public static bool isPaused = false;
    public static bool isPaused2 = false;
    public static bool isPaused3 = false;
    public static bool isPaused4 = false;

    // Use this for initialization
    void Start () {

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");
       popupbath = GameObject.Find("PanelBath");
       popupfood = GameObject.Find("PanelFood");
       popupbrush = GameObject.Find("PanelBrush");
       popupvet = GameObject.Find("PanelVet");
       
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1StartWaypoint = 0;
        player2StartWaypoint = 0;
        gameOver = false;

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);

       popupbath.gameObject.SetActive(false);
       popupfood.gameObject.SetActive(false);
      popupbrush.gameObject.SetActive(false);
      popupvet.gameObject.SetActive(false);

        isPaused = false;
        isPaused2 = false;
        isPaused3 = false;
        isPaused4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }

 
        if (player1.GetComponent<FollowThePath>().waypointIndex == 5)
        {

            if (isPaused == false)
            {
                popupbath.gameObject.SetActive(true);
                Time.timeScale = 0;
                isPaused = true;
            }

           

        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 10)
        {
               
            if (isPaused2 == false)
            {
                popupbrush.gameObject.SetActive(true);
                Time.timeScale = 0;       
                isPaused2 = true;
            }

         
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 15)
        {
            if (isPaused3 == false)
            {
                popupfood.gameObject.SetActive(true);
                Time.timeScale = 0;
                isPaused3 = true;
            }               
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 20)
        {

            if (isPaused4 == false)
            {
                popupvet.gameObject.SetActive(true);
                Time.timeScale = 0;
                isPaused4 = true;
            }
            
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }


    public void ContinueGame()
    {
            Time.timeScale = 1;
    }

    public void CloseGame()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
