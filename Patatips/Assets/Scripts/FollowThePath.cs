﻿using UnityEngine;

public class FollowThePath : MonoBehaviour {

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;
    public GameObject moverficha;
    
	// Use this for initialization
	private void Start () {

        StartGame();


    }
	
	// Update is called once per frame
	private void Update () {
        if (moveAllowed)
            Move();
	}

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                Instantiate(moverficha);
                waypointIndex += 1;
                //GameControl.lastWaypoint = waypointIndex;
            }
        }
    }


    public void StartGame()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }



}
