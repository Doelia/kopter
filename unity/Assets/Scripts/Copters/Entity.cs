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

	public string getKey() {
		string ab = "";
		Entity copter = this;
		ab += copter.getBody().id + "-";
		ab += copter.getColorBody().id + "-";
		ab += copter.getEyes().id + "-";
		ab += copter.getNose().id + "-";
		ab += copter.getSkin().id + "-";
		ab += copter.getFlyer().id + "-";
		return ab;
	}

	public Array<Element> getElements() {
		Array<Element> tab;
		tab.add(copter.getBody());
		tab.add(copter.getColorBody());
		tab.add(copter.getEyes());
		tab.add(copter.getNose());
		tab.add(copter.getSkin());
		tab.add(copter.getFlyer());
		return tab;
	}

	public Switcher getSwitcher(EnumPart part) {
		switch(part) {
			case BODY:
				return copter.getBody();
			case BODY_COLOR:
				return copter.getColorBody();
			case EYES:
				return copter.getEyes();
			case NOSE:
				return copter.getEyes();
			case HANDS:
				return copter.getHands();
			case LEGS:
				return copter.getLegs();
			case SKIN:
				return copter.getSkin();
			case FLYER:
				return copter.getFlyer();
		}
		return null;
	}

}