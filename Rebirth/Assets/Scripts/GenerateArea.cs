using UnityEngine;
using System.Collections;

public class GenerateArea : MonoBehaviour {

	//public GameObject sand;
	public Transform rock;
	//public GameObject soil;

	private GameObject newRockCube;

	//private bool done = false;

	public int zeroInnerL;
	public int zeroInnerW;

	// Use this for initialization
	void Start () {
		zeroInnerL = Random.Range (5, 8);
		zeroInnerW = Random.Range (3, 5);

		Generate ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Generate() {
		//if (!done) {
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 3; i++) {
					Instantiate (rock, new Vector3(i*10, 0 ,j*10), Quaternion.identity);
				}
			}
			//done = true;
		//}
	}
}
