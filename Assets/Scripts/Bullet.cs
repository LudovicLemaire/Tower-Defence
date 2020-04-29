﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 10;

    // Target (set by Tower)
    public Transform target;

    void FixedUpdate() {
        // Check if target still alive
        if (target) {
            // Fly towards the target
            Vector3 dir = target.position - transform.position;
            GetComponent<Rigidbody>().velocity = dir.normalized * speed;
        } else {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider co) {
    Health health = co.GetComponentInChildren<Health>();
    if (health) {
        health.decrease();
        Destroy(gameObject);
    }
}
}
