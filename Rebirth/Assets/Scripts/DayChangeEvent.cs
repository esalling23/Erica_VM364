using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class DayChangeEvent : GameEvent {

	public IResource resource;

	public DayChangeEvent(IResource resource) {
		this.resource = resource;
	}
}
