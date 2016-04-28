using UnityEngine;
using System.Collections;

public class GenerateQuestion : MonoBehaviour {

	private GameObject Options;
	private GameObject question;

	// Use this for initialization
	void Start () {
		question = GameObject.Find ("Question");
		Options = GameObject.Find ("Options");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GenQ () {
		//write random generation of array of questions

		//for now just turn on dummy question
		question.SetActive (true);
		Debug.Log ("Here's a question...");
	}

	public void AnswerWrong () {

	}

	public void AnswerCorrect () {
		question.SetActive (false);
		if (Options.GetComponent<OptionsBehavior>().choseReed == true) {
			Options.GetComponent<OptionsBehavior>().ReedBehavior ();
		}
		if (Options.GetComponent<OptionsBehavior>().choseTrash == true) {
			Options.GetComponent<OptionsBehavior>().TrashBehavior ();
		}
		if (Options.GetComponent<OptionsBehavior>().choseClipM == true) {
//			Options.GetComponent<OptionsBehavior>().TrashBehavior ();
		}
		if (Options.GetComponent<OptionsBehavior>().chosePlantM == true) {
//			Options.GetComponent<OptionsBehavior>().TrashBehavior ();
		}
	}
}
