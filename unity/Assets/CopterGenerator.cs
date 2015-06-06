using UnityEngine;
using System.Collections;

public class CopterGenerator : MonoBehaviour {

	public SpriteSwitcher getSpriteSwitcher(string name) {
		if (this.name.Equals (name))
			return this.GetComponent<SpriteSwitcher>();

		foreach (Transform child in transform) {
			if (child.name.Equals(name)) {
				return child.GetComponent<SpriteSwitcher>();
			}
		}
		return null;
	}

	public ColorSwitcher getColorSwitcher(string name) {
		if (this.name.Equals (name))
			return this.GetComponent<ColorSwitcher>();
		
		foreach (Transform child in transform) {
			if (child.name.Equals(name)) {
				return child.GetComponent<ColorSwitcher>();
			}
		}
		return null;
	}

	public void randomSwitcher(Switcher ts) {
		ts.changeIt(Random.Range(1, ts.getSize()+1));
	}

	public ColorSwitcher getColorBody() {
		return getColorSwitcher("body");
	}

	public SpriteSwitcher getBody() {
		return getSpriteSwitcher("body");
	}

	public SpriteSwitcher getEyes() {
		return getSpriteSwitcher("eyes");
	}

	public SpriteSwitcher getNose() {
		return getSpriteSwitcher("nose");
	}

	public SpriteSwitcher getHands() {
		return getSpriteSwitcher("hands");
	}

	public SpriteSwitcher getLegs() {
		return getSpriteSwitcher("legs");
	}

	public ColorSwitcher getColorsHands() {
		return getColorSwitcher("hands");
	}

	public void setColorsHands() {
		Color c = getColorBody().GetComponent<SpriteRenderer>().color;
		getColorsHands().setColor(c);
	}


	public void RandomIt() {
		randomSwitcher(getBody());
		randomSwitcher(getColorBody());
		randomSwitcher(getEyes());
		randomSwitcher(getNose());
		randomSwitcher(getHands());
		randomSwitcher(getLegs());

		setColorsHands();
	}
}
