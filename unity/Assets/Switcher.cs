using UnityEngine;
using System.Collections;

abstract public class Switcher : MonoBehaviour {

	public abstract void changeIt(int id);
	public abstract int getSize();

}
