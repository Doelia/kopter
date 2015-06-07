using UnityEngine;
using System.Collections;

public class CopterGenerator : MonoBehaviour {

	private Transform parts;

	public void Start() {
		foreach (Transform child in transform) {
			if (child.name.Equals("parts")) {
				parts = child;
			}
		}
	}

	public SpriteSwitcher getSpriteSwitcher(string name) {
		if (this.name.Equals (name))
			return this.GetComponent<SpriteSwitcher>();

		foreach (Transform child in parts.transform) {
			if (child.name.Equals(name)) {
				return child.GetComponent<SpriteSwitcher>();
			}
		}
		return null;
	}

	public ColorSwitcher getColorSwitcher(string name) {
		if (this.name.Equals (name))
			return this.GetComponent<ColorSwitcher>();
		
		foreach (Transform child in parts.transform) {
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

	public SpriteSwitcher getSkin() {
		return getSpriteSwitcher("skin");
	}

	public ColorSwitcher getColorsHands() {
		return getColorSwitcher("hands");
	}

	public void setColorsHands() {
		Color c = getColorBody().GetComponent<SpriteRenderer>().color;
		float nR = c.r-0.1f; if (nR > 1) nR = 1f;
		float nG = c.g-0.1f; if (nG > 1) nG = 1f;
		float nB = c.b-0.1f; if (nB > 1) nB = 1f;
		c = new Color(nR,nG,nB);
		getColorsHands().setColor(c);
	}


	public void RandomIt() {
		randomSwitcher(getBody());
		randomSwitcher(getColorBody());
		randomSwitcher(getEyes());
		randomSwitcher(getNose());
		randomSwitcher(getHands());
		randomSwitcher(getLegs());
		randomSwitcher(getSkin());

		setColorsHands();
	}
}
