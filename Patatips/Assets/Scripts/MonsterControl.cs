using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControl : MonoBehaviour
{

    Rigidbody2D rb;
    GameObject target;
    GameObject timer;

    float moveSpeed;
    Vector3 directionToTarget;
    //public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Cat");
        timer = GameObject.Find("CountdownText");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveMonster();
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {

            case "Player":
                MonstersSpawnerControl.spawnAllowed = false;
                //Instantiate(explosion, col.gameObject.transform.position, Quaternion.identity);
                //Instantiate(target, col.gameObject.transform.position, Quaternion.identity);
                Destroy(col.gameObject);
                //col.gameObject.SetActive(false);
                target = null;
                timer.SetActive(false);
                break;

        }
    }



    void MoveMonster()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directionToTarget.x * moveSpeed,
                                        directionToTarget.y * moveSpeed);
        }
        else
            rb.velocity = Vector3.zero;
    }


    private void OnMouseDown()
    {
        Destroy(gameObject);
    }


}
