using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywithdelay : MonoBehaviour {
    public float delay;


	// destory bullet after delay
	void Start () {
        Destroy(gameObject, delay);
	}
	
}
