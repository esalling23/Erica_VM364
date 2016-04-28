using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ResourceStats: MonoBehaviour {

	public GameObject accessGM;

//	public GameObject hover;
//	public Text resourceStat;
	public Text resourceName;
//	public Text resourceType;



//	public GameObject OilInfo;
//	public GameObject TrashInfo;
//	public GameObject GrassInfo;
//	public GameObject FernInfo;
//	public GameObject PalmInfo;
//	public GameObject PineInfo;
//	public GameObject MangroveInfo;


	// Use this for initialization
	void Awake () {
		//hover.SetActive(false);
		Events.instance.AddListener<HoverResourceEvent>
			(OnHoverResourceEvent);
	}

	void OnHoverResourceEvent(HoverResourceEvent e) {
		
		if (e.hoverResource is InvasiveReedBehavior) {
			Debug.Log ("hovering invasive reed");
//			resourceName.text = "invasive reed species detected";
		}
//		
      if (e.hoverResource is TrashBehavior) {
			Debug.Log ("hovering trash");
//			resourceName.text = "TRASH: ";
//			resourceType.text = "POLLUTION";
//			resourceStat.text = "CLEAN_UP_REWARDS\n + 2 FUEL";
		}
//		
//       
    }
}
