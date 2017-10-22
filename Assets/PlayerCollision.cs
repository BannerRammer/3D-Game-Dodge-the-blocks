﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public Player_Movement movement;

	void OnCollisionEnter(Collision collisioninfo) {
		if (collisioninfo.collider.tag == "Obstacle") {
			movement.enabled = false;
		}
	}
}
