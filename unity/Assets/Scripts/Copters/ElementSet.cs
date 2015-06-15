using UnityEngine;
using System.Collections;

abstract public class ElementSet {

	Dictionary<EnumPart, ArrayList<int>> datas;


	public ElementSet() {
		for (EnumPart p : EnumPart.getAll()) {
			datas.add(p, new ArrayList<int>());
		}
	}

	public void addElement(Switcher s) {
		if (!datas.get(s.idPart).contain(s.id)) {
			datas.get(s.idPart).add(s.id);
		}
	}

	public Element getRandomElementForPart(EnumPart p) {
		ArrayList<int> idPosibles = datas.get(p);
		int iRandom = Random.Range(0, idPosibles.getSize());
		return idPosibles[iRandom];
	}
}

