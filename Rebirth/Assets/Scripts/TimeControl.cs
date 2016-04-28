using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour {

	// A time we use to make sure our input is framerate independent.
	float timer;
	float speedTime;
	float currentTime;
	private bool speedDone;
	private Coroutine timeChange;
	private float difference;


	// A reference to the DayNightController script.
	DayNightCycle controller;

	void Awake() {
		// Find the DayNightController game object by its name and get the DayNightController script on it.
		controller = GameObject.Find("GameMaster").GetComponent<DayNightCycle>();
		controller.timeMultiplier = 0f;
	}

	void Update() {
		
		if (Input.GetKeyDown (KeyCode.Delete)) {
			controller.timeMultiplier = 0f;
		}
		// Get the raw vertical axis input (W, S, Arrow key up and down by default).
		float input = Input.GetAxisRaw("Vertical");

		// Increase our timer.
		timer += Time.deltaTime;


	}


	public void TimeChange (float time) {

		if (timeChange == null) {
			timeChange = StartCoroutine (Speed (time));


		} 
	}

	public IEnumerator Speed(float wait)
	{	
		this.GetComponent<Fuel> ().bioMatterCount.color = new Color32 (58, 58, 19, 255);
		this.GetComponent<CameraViewControl>().mapCamera.transform.position = new Vector3 (30f, 100f, 15f);
		this.GetComponent<CameraViewControl>().mapCamera.GetComponent<Camera>().orthographicSize = 60;
		this.GetComponent<GameStats> ().hints.SetActive (true);
		this.GetComponent<GameStats> ().info.SetActive (false);
		this.GetComponent<OptionsBehavior> ().options.SetActive (false);
		speedDone = false;
		controller.timeMultiplier = 1f;
		speedTime = controller.currentTimeOfDay + wait;
//		difference = speedTime - controller.currentTimeOfDay;

		if (speedTime > 1) {
//			difference = speedTime - controller.currentTimeOfDay;
			speedTime = speedTime - 1.0f;

		}
		this.GetComponent<GameStats>().hintText.text = "Time is speeding up to " + (Mathf.Round(24 * speedTime)).ToString() + ":00";
		speedTime = speedTime * 10;
//		Debug.Log (controller.currentTimeOfDay + " starting, " + speedTime + " ending");
//		difference = speedTime - controller.currentTimeOfDay;

		while (speedDone == false) {
			currentTime = Mathf.Round (controller.currentTimeOfDay * 10);
//			Debug.Log (currentTime + " now, ending at" + speedTime);

			if (Mathf.Approximately(speedTime, currentTime)) {
				speedDone = true;
//				Debug.Log (speedDone + "; ended at " + speedTime + "; " + currentTime);

			} else {

				if (timer > 0.01f) {
					// Cap it to a sane value.
//					Debug.Log ("increasing speed to " + controller.timeMultiplier);
					if (controller.timeMultiplier < 2f) {
						controller.timeMultiplier += 0.1f;
					} else {
						controller.timeMultiplier = 2f;
//						Debug.Log ("speed capped");
//						Debug.Log (currentTime + " now, ending at" + speedTime);

					}
				}
			}
			yield return null;
		}
		this.GetComponent<GameStats> ().hints.SetActive (false);
		timer = 0;
		controller.timeMultiplier = 0f;
		this.GetComponent<Fuel> ().bioMatterCount.color = new Color32 (116, 144, 121, 255);
		Debug.Log ("current time is " + currentTime + ";  sped time was " + speedTime);
		controller.currentTimeOfDay = currentTime/10;
		this.GetComponent<CameraViewControl> ().player.transform.position = new Vector3 (0f, 10f, 0f);
		this.GetComponent<CameraViewControl>().ChooseTile();
//		this.GetComponent<GameStats> ().info.SetActive (true);

		timeChange = null;
	}
}
