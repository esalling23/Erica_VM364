using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ClickResourceEvent : GameEvent {

	public IResource resource;

	public ClickResourceEvent(IResource resource) {
		this.resource = resource;
	}
}
