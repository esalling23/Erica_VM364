using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class InvasiveReedBehavior : MonoBehaviour, IPointerDownHandler, IResource {

	public GameObject roots;
	public GameObject hoverRoots;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Behavior () {
		
	} 

	public void OnMouseEnter () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 4f)) {
			Debug.DrawLine (ray.origin, hit.point);
			if (hit.collider) {
				Events.instance.Raise (new HoverResourceEvent (this));
				hoverRoots.SetActive (true);
			}
		}
	}

	public void OnMouseExit () {
		hoverRoots.SetActive (false);
	}

	public void OnPointerDown(PointerEventData e)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 4f)) {
			Debug.DrawLine (ray.origin, hit.point);
			if (hit.collider) {
				Events.instance.Raise (new ClickLandEvent (this));
				Debug.Log ("clicked roots of reed!");
				Behavior();
			}
		}
	}
}
