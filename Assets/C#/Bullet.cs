﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private Rigidbody BulletRigidbody;
    void Start()
    {
        BulletRigidbody = GetComponent<Rigidbody>();
        BulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }

    
}

