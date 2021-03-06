﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {
	public float baseSpeed;
	public float speed;
	private int point;
	public GameObject gameController;

	// Use this for initialization
	void Start () {
		speed = baseSpeed;

	

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (0, -speed*Time.deltaTime, 0);
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.Rotate (0, 0, 45);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.Rotate (0, 0, -45);
		}
		getSpeed ();

}
	void getSpeed() {
		point = Mathf.RoundToInt (transform.rotation.eulerAngles.z);


		int angleDiff = Mathf.Abs(Mathf.RoundToInt(Mathf.DeltaAngle (point, gameController.GetComponent<GameController>().windDir)));
		Debug.Log (angleDiff);
		/*
		if (point == 225 || point == 135) {
			speed = 3;
		} else if (point == 180) {
			speed = 0.5f;
		} else if (point == 270 || point == 90) {
			speed = 4.5f;
		} else if (point == 315 || point == 45) {
			speed = 4f;
		} else if (point == 0) {
			speed = 3.5f;
		}
			*/
		if (angleDiff == 45) {
			speed = 3;
		} else if (angleDiff == 0) {
			speed = 0.5f;
		} else if (angleDiff == 90) {
			speed = 4.5f;
		} else if (angleDiff == 135) {
			speed = 4f;
		} else if (angleDiff == 180) {
			speed = 3.5f;

		}

	}
}
