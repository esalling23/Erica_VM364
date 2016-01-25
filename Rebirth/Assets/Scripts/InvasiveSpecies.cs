using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class InvasiveSpecies : MonoBehaviour, IPointerDownHandler, IResource {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


	}



	public void Behavior () {
		if (gameObject.tag == "Reed") {
			Debug.Log ("invasive reed species detected. analyzing threat level...");
		}
		if (gameObject.tag == "Palm") {
			Debug.Log ("invasive palm tree species detected. analyzing threat level...");
		}

	} 

	public void OnMouseEnter () {
		Events.instance.Raise (new HoverResourceEvent (this));

	}

	public void OnPointerDown(PointerEventData e)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 4f)) {
			Debug.DrawLine (ray.origin, hit.point);
			if (hit.collider) {
				Events.instance.Raise (new ClickLandEvent (this));
				Debug.Log ("clicked invasive species");
				Behavior();
			}
		}
	}
}