using UnityEngine;
using System.Collections;

public class CopterGenerator : MonoBehaviour {

	private Entity copter;
	public Entity parent;

	public void Start() {
		this.copter = this.gameObject.GetComponent<Entity>();
	}

	public void randomSwitcher(Switcher ts) {
		ts.changeIt(Random.Range(1, ts.getSize()+1));
	}

	public void disableHandIfNeedle() {
		if (copter.getFlyer().id <= 5) {
		//	copter.getHands().changeIt(1);
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

		if (copter.GetComponent<Egg>() != null) {
			copter.GetComponent<Egg>().setColorNoed();
		}

	}

	public void RandomKey() {

	}

	public void generateFromKey(string key) {
		string[] tab = key.Split('-');
		copter.getBody().changeIt(int.Parse(tab[0]));
		copter.getColorBody().changeIt(int.Parse(tab[1]));
		copter.getEyes().changeIt(int.Parse(tab[2]));
		copter.getNose().changeIt(int.Parse(tab[3]));
		copter.getSkin().changeIt(int.Parse(tab[4]));
		copter.getFlyer().changeIt(int.Parse(tab[5]));

		if (copter.GetComponent<Copter>() != null) {
			copter.GetComponent<Copter>().setColorsHands();
		}
		
		if (copter.GetComponent<Egg>() != null) {
			copter.GetComponent<Egg>().setColorNoed();
		}
	}

	public void generateFromParent() {
		string key = parent.getKey();
		Debug.Log ("key = "+key);
		this.generateFromKey(key);
	}

	public void generateFromElementSet(ElementSet set) {
		for (PartEnum p in PartEnum.getAll()) {
			copter.getPart(p).changeIt(set.getRandomElementForPart(p));
		}
	}

	/**
	 * Probabilité de transformation à faire en dehors
	 */
	public void doGeneticMutation() {
		PartEnum partChanged = PartEnum.randomtIt();
		Switcher s = copter.getPart(partChanged);
		this.randomSwitcher(s);
	}



}
