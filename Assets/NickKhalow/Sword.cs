using System;
using System.Collections;
using System.Collections.Generic;
using NickKhalow;
using UnityEngine;

public class Sword : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent<Enemy>(out var enemy))
        {
            enemy.TakeDamage(10);
        }
    }
}