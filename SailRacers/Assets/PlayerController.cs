using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	public int point;

	// Use this for initialization
	void Start () {
		point = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector2.up *(-speed) * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			point += 1;
			transform.Rotate (0, 0, -45);
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			point -= 1;
			transform.Rotate (0, 0, 45);
		}
	}
}
