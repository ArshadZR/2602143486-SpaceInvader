using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 2f; // Lifetime of the bullet before it gets destroyed
    public ParticleSystem impactEffect; // Impact effect particle system

    void Start()
    {
        // Destroy the bullet after its lifetime
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Instantiate impact effect at the collision point and rotation
        if (impactEffect != null)
        {
            Instantiate(impactEffect, collision.contacts[0].point, Quaternion.identity);
        }

        // Destroy the bullet
        Destroy(gameObject);
    }
}

