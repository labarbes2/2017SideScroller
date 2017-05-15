using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipetransport : MonoBehaviour {

    public float speed;
   

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            var player = GameObject.Find("Pipe");
            player.transform.position = new Vector2(-5, -3);
        }
    }
    void OnCollisionEnter(Collision2D other)
    {
        if (GetComponent<Rigidbody2D>().velocity.y <= -3)
        {
            if (other.gameObject.tag == "Pipe")
            { }
        }
        else { }
    }



}
