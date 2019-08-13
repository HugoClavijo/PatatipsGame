using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    public static int whosTurn = 1;
    private bool coroutineAllowed = true;
    public GameObject sonidoDados;


	// Use this for initialization
	private void Start () {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
	}

    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
            StartCoroutine("RollTheDice");
    }

    public IEnumerator RollTheDice()
    {
        Instantiate(sonidoDados);
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
            GameControl.lastWaypointP1 += randomDiceSide + 1;
        } else if (whosTurn == -1)
        {
            GameControl.MovePlayer(2);
            GameControl.lastWaypointP2 += randomDiceSide + 1;         
        }
        whosTurn *= -1;
        coroutineAllowed = true;
    }

    

}
