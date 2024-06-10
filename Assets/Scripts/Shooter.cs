using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab; // The bullet prefab to shoot
    public Transform bulletSpawnPoint; // The point where bullets are spawned
    public float bulletSpeed = 20f; // Speed of the bullets
    public ParticleSystem muzzleFlash; // Muzzle flash effect

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate the bullet
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        
        // Get the Rigidbody2D component of the bullet and set its velocity
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = bulletSpawnPoint.right * bulletSpeed;

        // Play the muzzle flash effect
        if (muzzleFlash != null)
        {
            muzzleFlash.Play();
        }
    }
}

