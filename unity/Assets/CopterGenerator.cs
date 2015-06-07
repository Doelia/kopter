using UnityEngine;
using System.Collections;

public class CopterGenerator : MonoBehaviour {

	private Entity copter;

	public void Start() {
		this.copter = this.gameObject.GetComponent<Entity>();
	}

	public void randomSwitcher(Switcher ts) {
		ts.changeIt(Random.Range(1, ts.getSize()+1));
	}

	public void disableHandIfNeedle() {
		if (copter.getFlyer().id <= 5) {
			copter.getHands().changeIt(1);
		}
	}

	public void RandomIt() {
		randomSwitcher(copter.getBody());
		randomSwitcher(copter.getColorBody());
		randomSwitcher(copter.getEyes());
		randomSwitcher(copter.getNose());
		randomSwitcher(copter.getSkin());
		randomSwitcher(copter.getFlyer());
		//randomSwitcher(copter.getHands());
		//randomSwitcher(copter.getLegs());

		this.disableHandIfNeedle();

		if (copter.GetComponent<Copter>() != null) {
			copter.GetComponent<Copter>().setColorsHands();
		}

	}

	public string getKey() {
		string ab = "";
		ab += copter.getBody().id + "-";
		ab += copter.getColorBody().id + "-";
		return ab;
	}

}
