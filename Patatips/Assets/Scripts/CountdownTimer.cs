using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 20f;

    public GameObject target;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Cat");
        currentTime = startingTime;
        countdownText.text = currentTime.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            MonsterControl.winner = true;
            MonstersSpawnerControl.spawnAllowed = false;
            DeleteAll();
        }

    }


    public void DeleteAll()
    {
        Destroy(GameObject.FindWithTag("Enemy"));
        Destroy(target);
        Destroy(countdownText);
    }



}
