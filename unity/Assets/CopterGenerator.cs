using UnityEngine;
using System.Collections;

public class CopterGenerator : MonoBehaviour {

	public Switcher[] getSwitchers(string name) {
		if (this.name.Equals (name))
			return this.GetComponents<Switcher>();

		foreach (Transform child in transform) {
			if (child.name.Equals(name)) {
				return child.GetComponents<Switcher>();
			}
		}
		return null;
	}

	public void randomSwitcher(Switcher[] ts) {
		foreach (Switcher t in ts) {
			t.changeIt(Random.Range(1, t.getSize()));
		}
	}

	public void RandomIt() {
		randomSwitcher(getSwitchers("body"));
		randomSwitcher(getSwitchers("eyes"));
		randomSwitcher(getSwitchers("nose"));
	}
}
