using UnityEngine;
using System.Collections;

abstract public class Entity : MonoBehaviour {

	protected Transform parts;

	abstract public Switcher getColorBody();
	abstract public Switcher getBody();
	abstract public Switcher getEyes();
	abstract public Switcher getNose();
	abstract public Switcher getHands();
	abstract public Switcher getLegs();
	abstract public Switcher getSkin();
	abstract public Switcher getFlyer();
	
	public void Start() {
		foreach (Transform child in transform) {
			if (child.name.Equals("parts")) {
				parts = child;
			}
		}
	}
	
	protected GameObject getPart(string name) {
		if (this.name.Equals (name))
			return this.gameObject;
		
		foreach (Transform child in parts.transform) {
			if (child.name.Equals(name)) {
				return child.gameObject;
			}
		}
		return null;
	}



}
