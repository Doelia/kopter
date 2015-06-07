using UnityEngine;
using System.Collections;

abstract public class Switcher : MonoBehaviour {

	public int id;
	public int idPart;

	virtual public void changeIt(int id) {
		this.id = id;
	}

	public abstract int getSize();

}
