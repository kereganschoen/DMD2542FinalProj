using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public int windDir;
	private int[] windChoices;
	// Use this for initialization
	void Start () {
		windChoices = new int[] {0, 45, 90, 135, 180, 225, 270, 315};
	}
	
	// Update is called once per frame
	void Update () {
		changeWind ();
	}
	void changeWind(){
		if (Input.GetKeyDown(KeyCode.Space)) {
			int choice = Random.Range (0, 8);
			windDir = windChoices [choice];
			transform.eulerAngles  = new Vector3 (0,0,windDir-180);

		}
	}
}
