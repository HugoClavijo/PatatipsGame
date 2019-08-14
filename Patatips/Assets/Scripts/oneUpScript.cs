using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneUpScript : MonoBehaviour
{
   // Rigidbody2D rb;
    //GameObject target;
    //Vector3 directionToTarget;
    public GameObject oneUp;

    // Start is called before the first frame update
    void Start()
    {
       // target = GameObject.Find("Cat");
       // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {

            case "Player":
                Instantiate(oneUp, transform.position, Quaternion.identity);
                // MonstersSpawnerControl.spawnAllowed = false;
                //Instantiate(explosion, col.gameObject.transform.position, Quaternion.identity);
                // Destroy(col.gameObject);
                //col.gameObject.SetActive(false);
                //target = null;
                // loser = true;
                // timer.SetActive(false);
                break;

        }
    }



}
