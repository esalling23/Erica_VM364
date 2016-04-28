using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Fuel : MonoBehaviour {

	public int currentfuel;
//	public int maxfuel = 10;
//	public Slider fuelslider;
	public Text fuelcount;
	public int bioMatter;
	public Text bioMatterCount;
	public bool converting = false;


	void Awake () {
		currentfuel = 10;
		bioMatter = 0;
		bioMatterCount.text = bioMatter.ToString ();
		fuelcount.text = currentfuel.ToString ();
	}

	public void Fueling(int num) {
		currentfuel += num;
		fuelcount.text = currentfuel.ToString ();
	}

	public void Convert() {
		currentfuel += (bioMatter / 2);
		bioMatter = 0;
		fuelcount.text = currentfuel.ToString ();
		bioMatterCount.text = bioMatter.ToString ();
		this.GetComponent<CameraViewControl> ().ChooseTile ();
		this.GetComponent<TimeControl> ().TimeChange (0.1f);
	}

	public void BioMatter(int num) {
		bioMatter += num;
		bioMatterCount.text = bioMatter.ToString ();
	}

}
