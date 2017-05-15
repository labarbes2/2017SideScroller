using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

    public Transform Player;
    public float ChaseSpeed = 1f;
    public float Range = 6f;
    float CurrentSpeed;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {

        if (Vector3.Distance(transform.position, Player.position) <= Range) 
        {
            CurrentSpeed = ChaseSpeed * Time.deltaTime; 
            transform.position = Vector3.MoveTowards(transform.position, Player.position, CurrentSpeed);  
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
       
        var player = coll.gameObject.GetComponent<Player>();
        if (player != null)
        { 
            player.GetOut();
        }
    }
}
