using UnityEngine;
using System.Collections;

abstract public class Switcher : Element {

	virtual public void changeIt(int id) {
		this.id = id;
	}

	public abstract int getSize();

}
