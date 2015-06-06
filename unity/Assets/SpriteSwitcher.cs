using UnityEngine;
using System.Collections;

public class SpriteSwitcher : Switcher {

	public Sprite[] sprites;
	
	override public void changeIt(int id) {
		this.id = id;
		Sprite sp = sprites[id-1];
		this.GetComponent<SpriteRenderer>().sprite = sp;
	}

	override public int getSize() {
		return sprites.Length;
	}
}
