using UnityEngine;
using System.Collections;

public class Copter : MonoBehaviour {

	private Transform parts;

	public void Start() {
		foreach (Transform child in transform) {
			if (child.name.Equals("parts")) {
				parts = child;
			}
		}
	}

	public GameObject getPart(string name) {
		if (this.name.Equals (name))
			return this.gameObject;
		
		foreach (Transform child in parts.transform) {
			if (child.name.Equals(name)) {
				return child.gameObject;
			}
		}
		return null;
	}

	public ColorSwitcher getColorBody() {
		return getPart("body").GetComponent<ColorSwitcher>();
	}

	public SpriteSwitcher getBody() {
		return getPart("body").GetComponent<SpriteSwitcher>();
	}

	public SpriteSwitcher getEyes() {
		return getPart("eyes").GetComponent<SpriteSwitcher>();
	}

	public SpriteSwitcher getNose() {
		return getPart("nose").GetComponent<SpriteSwitcher>();
	}

	public SpriteSwitcher getHands() {
		return getPart("hands").GetComponent<SpriteSwitcher>();
	}

	public SpriteSwitcher getLegs() {
		return getPart("legs").GetComponent<SpriteSwitcher>();
	}

	public SpriteSwitcher getSkin() {
		return getPart("skin").GetComponent<SpriteSwitcher>();
	}

	public ColorSwitcher getColorsHands() {
		return getPart("hands").GetComponent<ColorSwitcher>();
	}

	public ObjectSwitcher getFlyer() {
		return getPart("flyer").GetComponent<ObjectSwitcher>();
	}





}
