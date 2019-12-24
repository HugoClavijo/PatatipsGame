using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;
    public GameObject popupbath, popupfood, popupbrush, popupvet, dice;
    // public GameObject popupInst, popupInst1, popupInst2, popupInst3;
    public static GameObject player1, player2;
    public static Animator anim;
    //public GameObject sonidoUp;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int lastWaypointP1 = 0;
    public static int lastWaypointP2 = 0;

    public static bool gameOver = false;
    public static bool gameReplay = false;
    public static bool gameReplay2 = false;
    // public static bool miniGame = true;
    public static bool isPaused = false;
    public static bool isPaused2 = false;
    public static bool isPaused3 = false;
    public static bool isPaused4 = false;
    Scene scene;
    Scene scene2;


    // Use this for initialization
    void Start () {

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");

      //  popupInst = GameObject.Find("PanelInst");
       // popupInst1 = GameObject.Find("PanelInst1");
       // popupInst2 = GameObject.Find("PanelInst2");
       // popupInst3 = GameObject.Find("PanelInst3");

        popupbath = GameObject.Find("PanelBath");
       popupfood = GameObject.Find("PanelFood");
       popupbrush = GameObject.Find("PanelBrush");
       popupvet = GameObject.Find("PanelVet");
        dice = GameObject.Find("Dice");
        // oneUP = GameObject.Find("oneUp");
        // anim = GetComponent<Animator>();

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        scene = SceneManager.GetActiveScene();
        scene2 = SceneManager.GetActiveScene();

        player1StartWaypoint = 0;
            player2StartWaypoint = 0;
            gameOver = false;
        //miniGame = true;
        //anim = GetComponent<Animator>();


        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
          
        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);

     //   popupInst1.gameObject.SetActive(false);
      //  popupInst2.gameObject.SetActive(false);
      //  popupInst3.gameObject.SetActive(false);
        popupbath.gameObject.SetActive(false);
       popupfood.gameObject.SetActive(false);
      popupbrush.gameObject.SetActive(false);
      popupvet.gameObject.SetActive(false);
     // oneUP.gameObject.SetActive(false);

        isPaused = false;
        isPaused2 = false;
        isPaused3 = false;
        isPaused4 = false;



        if (gameReplay == false)
        {
            gameReplay2 = false;
        }

        if (gameReplay == true)
        {
            //popupInst.gameObject.SetActive(false);
            player1.GetComponent<FollowThePath>().waypointIndex = lastWaypointP1;
            player1.GetComponent<FollowThePath>().StartGame();
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex;
      
            player2.GetComponent<FollowThePath>().waypointIndex = lastWaypointP2;
            player2.GetComponent<FollowThePath>().StartGame();
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex;
   
        }

        if (gameReplay2 == true)
        {
          
            player1.GetComponent<FollowThePath>().waypointIndex = lastWaypointP1;
            player1.GetComponent<FollowThePath>().StartGame();
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex;
          
            player2.GetComponent<FollowThePath>().waypointIndex = lastWaypointP2;
            player2.GetComponent<FollowThePath>().StartGame();
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex;
           
        }


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
            //whoWinsTextShadow.gameObject.SetActive(true);
            //whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;

            

            if (scene.name == "BoardScene")
            {
               // ResetGame();
                SceneManager.LoadScene("WinDogScene", LoadSceneMode.Single);
            }
            else
            {
                //ResetGame();
                SceneManager.LoadScene("WinCatScene", LoadSceneMode.Single);
            }
                
        }

 
        if (player1.GetComponent<FollowThePath>().waypointIndex == 5)
        {
           

            if (gameReplay == false)
            {


                if (isPaused == false)
                {
                    dice.gameObject.SetActive(false);
                    popupbath.gameObject.SetActive(true);
                    Time.timeScale = 0;
                    isPaused = true;
                }

               

            }

                //gameReplay = true;

        }



        if (player1.GetComponent<FollowThePath>().waypointIndex == 6)
        {


            if (gameReplay == false)
            {

                Scene scene2 = SceneManager.GetActiveScene();

                if (scene2.name == "BoardScene2")
                {
                    MonsterControl.loser = false;
                    MonsterControl.winner = false;
                    Time.timeScale = 1;
                    MiniGameCat();
                }

                if (scene2.name == "BoardScene")
                {
                    MonsterControl.loser = false;
                    MonsterControl.winner = false;
                    Time.timeScale = 1;
                    MiniGameDog();
                }

            }

            //gameReplay = true;

        }



      //  if (gameReplay == true)
       // {
           // oneUP.gameObject.SetActive(true);
           // Instantiate(sonidoUp);

          //  if (null != anim)
          //  {
                // play Bounce but start at a quarter of the way though
             //   anim.Play("oneUp", 0, 0.25f);
           // }
     //   }



        if (player1.GetComponent<FollowThePath>().waypointIndex == 10)
        {
               
            if (isPaused2 == false)
            {
                dice.gameObject.SetActive(false);
                popupbrush.gameObject.SetActive(true);
                Time.timeScale = 0;       
                isPaused2 = true;
            }

         
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 15)
        {
            if (isPaused3 == false)
            {
                dice.gameObject.SetActive(false);
                popupfood.gameObject.SetActive(true);
                Time.timeScale = 0;
                isPaused3 = true;
            }               
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 20)
        {

            if (isPaused4 == false)
            {
                dice.gameObject.SetActive(false);
                popupvet.gameObject.SetActive(true);
                Time.timeScale = 0;
                isPaused4 = true;
            }
            
        }


        if (player1.GetComponent<FollowThePath>().waypointIndex == 21)
        {


            if (gameReplay2 == false)
            {

                Scene scene2 = SceneManager.GetActiveScene();

                if (scene2.name == "BoardScene2")
                {
                    MonsterControl.loser = false;
                    MonsterControl.winner = false;
                    Time.timeScale = 1;
                    MiniGameCat2();
                }

                if (scene2.name == "BoardScene")
                {
                    MonsterControl.loser = false;
                    MonsterControl.winner = false;
                    Time.timeScale = 1;
                    MiniGameDog2();
                }

            }

            //gameReplay = true;

        }



        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            //whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            //whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;

            //string scene = SceneManager.GetActiveScene().name;
      
            if (scene2.name == "BoardScene") {
               // ResetGame();
                SceneManager.LoadScene("LoseDogScene", LoadSceneMode.Single);
            }
            else
            {
                //ResetGame();
                SceneManager.LoadScene("LoseCatScene", LoadSceneMode.Single);
            }

               
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
        //Dice.whosTurn = 1;
        ResetGame();
    SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void MiniGameCat()
    {
        SceneManager.LoadScene("MiniGameCat");
    }

    public void MiniGameDog()
    {
        SceneManager.LoadScene("MiniGameDog");
    }


    public void MiniGameCat2()
    {
        SceneManager.LoadScene("MiniGameCat2");
    }

    public void MiniGameDog2()
    {
        SceneManager.LoadScene("MiniGameDog2");
    }

    public void ResetGame()
    {
        gameReplay = false;
        gameReplay2 = false;
        lastWaypointP1 = 0;
        lastWaypointP2 = 0;
    }

}
