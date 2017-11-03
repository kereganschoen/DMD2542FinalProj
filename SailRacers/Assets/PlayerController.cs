using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	public int point;
	public float windSpeed;
	public int windDir;
	public float totalSpeed;
	private int variwind;
	public GameObject windMarker;
	// Use this for initialization
	void Start () {
		point = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
		variwind = Mathf.Abs ((Mathf.RoundToInt(gameObject.transform.localEulerAngles.z) - windDir) %360 )/45;
		totalSpeed = (speed * windSpeed) - variwind;

		if (totalSpeed <= 1)
			totalSpeed = 1;
		transform.Translate(Vector2.up *(-totalSpeed) * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			point += 1;
			transform.Rotate (0, 0, -45);

		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			point -= 1;
			transform.Rotate (0, 0, 45);
		}
		Debug.Log(windMarker.transform.rotation.eulerAngles.z );
		if (windMarker.transform.rotation.eulerAngles.z < 0) {
			
			windMarker.transform.rotation = Quaternion.Euler (0, 0, -windDir);
		} else {
			windMarker.transform.rotation = Quaternion.Euler (0, 0, -windDir);
		}
	
	}
}
