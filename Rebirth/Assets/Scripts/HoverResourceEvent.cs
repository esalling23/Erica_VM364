using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class HoverResourceEvent : GameEvent {

	public IResource hoverResource;
	
	public HoverResourceEvent(IResource hoverResource) {
//		Debug.Log ("hover event");
		this.hoverResource = hoverResource;
	}
}
