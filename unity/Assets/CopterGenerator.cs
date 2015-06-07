using UnityEngine;
using System.Collections;

public class CopterGenerator : MonoBehaviour {

	private Copter copter;

	public void Start() {
		this.copter = this.gameObject.GetComponent<Copter>();
	}

	public void randomSwitcher(Switcher ts) {
		ts.changeIt(Random.Range(1, ts.getSize()+1));
	}

	public void disableHandIfNeedle() {
		if (copter.getFlyer().id <= 5) {
			copter.getHands().changeIt(1);
		}
	}

	public void setColorsHands() {
		Color c = copter.getColorBody().GetComponent<SpriteRenderer>().color;
		float nR = c.r-0.1f; if (nR > 1) nR = 1f;
		float nG = c.g-0.1f; if (nG > 1) nG = 1f;
		float nB = c.b-0.1f; if (nB > 1) nB = 1f;
		c = new Color(nR,nG,nB);
		copter.getColorsHands().setColor(c);
	}

	public void RandomIt() {
		randomSwitcher(copter.getBody());
		randomSwitcher(copter.getColorBody());
		randomSwitcher(copter.getEyes());
		randomSwitcher(copter.getNose());
		randomSwitcher(copter.getHands());
		randomSwitcher(copter.getLegs());
		randomSwitcher(copter.getSkin());
		randomSwitcher(copter.getFlyer());

		this.disableHandIfNeedle();
		this.setColorsHands();
	}

}
