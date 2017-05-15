using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFiring : Enemy {
    public GameObject firePrefab;
    private float fireRate = 3f; // Bullets/second
    private float timeToNextShot; // How much longer we have to wait.

    void Fire()
    {
        // Subtract the time since the last from TTNS .
        timeToNextShot -= Time.deltaTime;

        if (timeToNextShot <= 0)
        {
            // Reset the timer to next shot
            timeToNextShot = 1 / fireRate;

            //.... Your code
            GameObject bullet = (GameObject)Instantiate(firePrefab);
            //GameObject bullet = objectPool.GetPooledObject (); 
            bullet.transform.position = transform.position;
            bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.up * 14;
            Destroy(bullet, 2.0f);
        }
    }
}
