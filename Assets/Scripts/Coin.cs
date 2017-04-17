using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

     
     public int points = 1;

    void OnCollisionEnter2D(Collision2D coll)
    {
        var player = coll.gameObject.GetComponent<Player>();
        if (player != null)
        { // !=not
            gameObject.SetActive(false);
            FindObjectOfType<GM>().SetPoints(FindObjectOfType<GM>().GetPoints() + points);
        }
     
    }
}
