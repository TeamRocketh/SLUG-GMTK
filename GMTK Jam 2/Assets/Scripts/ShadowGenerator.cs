﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowGenerator : MonoBehaviour
{
    public GameObject shadow;
    public float ShadowDelay = 0.2f;

    float timer;

    private void Start()
    {
        timer = ShadowDelay;
    }

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            if (timer > 0)
                timer -= Time.deltaTime;
            else
            {
                GameObject temp = Instantiate(shadow, transform.position, transform.rotation);
                timer = ShadowDelay;
                Destroy(temp, 0.5f);
            }
        }
    }
}
