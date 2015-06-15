using UnityEngine;
using System.Collections;

public class ObjectSwitcher :  Switcher {
	
	public GameObject[] objs;
	public GameObject curentActive = null;

	public void Start() {

		int cpt = 0;
		foreach (Transform child in this.transform) {
			cpt++;
		}
		objs = new GameObject[cpt];

		int i = 0;
		foreach (Transform child in this.transform) {
			objs[i] = child.gameObject;
			i++;
			child.gameObject.SetActive(false);
		}

	}
	
	override public void changeIt(int id) {
		if (curentActive != null) {
			curentActive.SetActive(false);
		}
		this.id = id;
		GameObject sp = objs[id-1];
		sp.SetActive(true);
		curentActive = sp;
	}
	
	override public int getSize() {
		return objs.Length;
	}
}
