using UnityEngine;
using System.Collections;

public class Egg : Entity {

	override public Switcher getColorBody() {
		return getPart("bg").GetComponent<ColorSwitcher>();
	}
	
	override public Switcher getBody() {
		return getPart("noeud").GetComponent<SpriteSwitcher>();
	}
	
	override public Switcher getEyes() {
		return getPart("bandeau").GetComponent<ColorSwitcher>();
	}
	
	override public Switcher getNose() {
		return getPart("motif").GetComponent<SpriteSwitcher>();
	}
	
	override public Switcher getHands() {
		return null;
	}
	
	override public Switcher getLegs() {
		return null;
	}
	
	override public Switcher getSkin() {
		return getPart("bandeau").GetComponent<SpriteSwitcher>();
	}
	
	override public Switcher getFlyer() {
		return getPart("motif").GetComponent<ColorSwitcher>();
	}

}
