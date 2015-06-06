using UnityEngine;
using System.Collections;

public class ColorSwitcher : Switcher {

	public Color[] colors;
	
	override public void changeIt(int id) {
		Color sp = colors[id-1];
		setColor (sp);
	}
	
	override public int getSize() {
		return colors.Length;
	}

	public void setColor(Color c) {
		this.GetComponent<SpriteRenderer>().color = c;
	}

}
