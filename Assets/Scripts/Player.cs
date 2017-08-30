﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {
    const float SPEED = 0.1f;
	// Use this for initialization
    Player() : base(100, 10) { }

    protected override void Move()
    {
        float horizontalDir = Input.GetAxis("Horizontal");
        float verticalDir = Input.GetAxis("Vertical");
        if (horizontalDir == 0.0f && verticalDir == 0.0f)
            return;
        Transform player = GetComponent<Transform>();

        // Update position
        Vector3 newLocation = new Vector3(horizontalDir * SPEED + player.position.x, verticalDir * SPEED + player.position.y);
        player.position = Vector3.MoveTowards(player.position, newLocation, SPEED); ;
    }
}