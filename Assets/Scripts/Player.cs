﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int health = 100;
    public float speed = 5;
    public float jumpSpeed = 5;
    public float deadZone = -3;

    new Rigidbody2D rigidbody;
    GM _GM;
    private Vector3 startingPosition;

    private Animator anim;
    public bool air;

	// Use this for initialization
	void Start () {
        startingPosition = transform.position; 
        rigidbody = GetComponent<Rigidbody2D>();
        _GM = FindObjectOfType<GM>();

        anim = GetComponent<Animator>();
        air = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        // Apply Movement
        float x = Input.GetAxisRaw("Horizontal");
        Vector2 v = rigidbody.velocity;
        v.x = x * speed;

        if (v.x != 0)
        {
            anim.SetBool("Running", true);
        }
        else { anim.SetBool("Running", false);
        }

        if(Input.GetButtonDown("Jump")) {
            v.y = jumpSpeed;
        }

        if (air) {
            anim.SetBool("Air", true);
        }
        else { anim.SetBool("Air", false);
        }

        rigidbody.velocity = v;

        //Check for out
        if(transform.position.y < deadZone) {
            Debug.Log("Current Position" + transform.position.y + "is lower than" + deadZone);
            GetOut();
        }

        //rigidbody.AddForce(new Vector2(x * speed, 0)); (could have done this too)
	    }

    public void GetOut() {
        _GM.SetLives( _GM.GetLives() - 1);
        transform.position = startingPosition;
        Debug.Log("You're Out");
    }

    void OnCollisionEnter2D(Collision2D col){
        air = false;
    }
    void OnCollisionExit2D(Collision2D col){
        air = true;
    } 
}
