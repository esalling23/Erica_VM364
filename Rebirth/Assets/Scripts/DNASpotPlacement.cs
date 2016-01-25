using UnityEngine;
using System.Collections;

public class DNASpotPlacement : MonoBehaviour {

	private GameObject explorableOcean;
	public GameObject oceanDNAPrefab;
	public float exploreWidth;
	public float exploreLength;

	private float randomWidth;
	private float randomLength;

	private float islandBoundsW;
	private float islandBoundsL;

	public int loopRandom;
	public int loopMin;
	public int loopMax;

	// Use this for initialization
	void Start () {
		explorableOcean = GameObject.FindGameObjectWithTag ("ExploreOcean");
		exploreWidth = Mathf.Round(Random.Range (80F, 160F));
		exploreLength = Mathf.Round(Random.Range (80F, 180F));
		explorableOcean.transform.localScale += new Vector3 (exploreWidth, 0F, exploreLength);
		Debug.Log (explorableOcean.transform.localScale.x.ToString ()); 
		Debug.Log (explorableOcean.transform.localScale.z.ToString ()); 
		randomWidth = Random.Range (-exploreWidth, exploreWidth);
		randomLength = Random.Range(-exploreLength, exploreLength);


		loopMin = Random.Range (3, 12);
		loopMax = Random.Range (24, 32);
		loopRandom = Random.Range (loopMin, loopMax);
		Debug.Log (loopMin.ToString ());
		Debug.Log (loopMax.ToString ());
		Debug.Log (loopRandom.ToString ());
		for (int i = 0; i < loopRandom; i++) {
			SpawnDNASpot ();

		}

	}

	void SpawnDNASpot(){
		Vector3 position = new Vector3(randomWidth, -4, Random.Range(-exploreLength, exploreLength));

		Instantiate (oceanDNAPrefab, position, Quaternion.identity);
	}


	// Update is called once per frame
	void Update () {
		
	}
}
