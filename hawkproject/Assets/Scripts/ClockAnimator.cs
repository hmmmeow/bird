using UnityEngine;
using System;
using System.Collections;

public class ClockAnimator : MonoBehaviour {


	public Transform hours, minutes;
	public float startTime;
	public float newMinuteTime;
	public float newHourTime;
	public float speedMultiplier;


	void Awake () {

		startTime = 9;
		speedMultiplier = 0.1f;


		// Dont touch below here

		newMinuteTime = 0;
		newHourTime = startTime * 30;

		}

	void RunClock(){
		if (newMinuteTime < 360) {
			newMinuteTime = newMinuteTime + speedMultiplier;
		} else {
			newMinuteTime = newMinuteTime - 360;
			newHourTime = newHourTime + 30;
		}
	}

	void UpdateClockHands(){
		hours.localRotation = Quaternion.Euler(0f, 0f, -newHourTime);
		minutes.localRotation = Quaternion.Euler(0f, 0f, -newMinuteTime);
	}


	void FixedUpdate() {
		RunClock ();
	}


	void Update () {
		UpdateClockHands ();

	}

}
