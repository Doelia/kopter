using UnityEngine;
using System.Collections;

public class Copter : Entity {

	override public Switcher getColorBody() {
		return getPart("body").GetComponent<ColorSwitcher>();
	}

	override public Switcher getBody() {
		return getPart("body").GetComponent<SpriteSwitcher>();
	}

	override public Switcher getEyes() {
		return getPart("eyes").GetComponent<SpriteSwitcher>();
	}

	override public Switcher getNose() {
		return getPart("nose").GetComponent<SpriteSwitcher>();
	}

	override public Switcher getHands() {
		return getPart("hands").GetComponent<SpriteSwitcher>();
	}

	override public Switcher getLegs() {
		return getPart("legs").GetComponent<SpriteSwitcher>();
	}

	override public Switcher getSkin() {
		return getPart("skin").GetComponent<SpriteSwitcher>();
	}

	override public Switcher getFlyer() {
		return getPart("flyer").GetComponent<ObjectSwitcher>();
	}

	public GameObject getHandsObject() {
		return getPart("hands");
	}

	public void setColorsHands() {
		Color c = this.getColorBody().GetComponent<SpriteRenderer>().color;
		float nR = c.r-0.1f; if (nR > 1) nR = 1f;
		float nG = c.g-0.1f; if (nG > 1) nG = 1f;
		float nB = c.b-0.1f; if (nB > 1) nB = 1f;
		c = new Color(nR,nG,nB);
		this.getHands().GetComponent<SpriteRenderer>().color = c;
	}





}
