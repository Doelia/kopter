using UnityEngine;
using System.Collections;

class PartEnum {
	enum PartEnum { BODY, COLOR_BODY, EYES, NOSE, HANDS, LEGS, SKIN, FLYER};

	public ArrayList<PartEnum> getAll() {
		ArrayList<PartEnum> list;
		list.add(BODY);
		list.add(COLOR_BODY);
		list.add(EYES);
		list.add(NOSE);
		list.add(HANDS);
		list.add(LEGS);
		list.add(SKIN);
		list.add(FLYER);
		return list;
	}

	public PartEnum getRandomPart() {
		ArrayList<PartEnum> list = getAll();
		int iRandom = Random.Range(0, list.getSize());
		PartEnum p = list[iRandom];
		return p;
	}
	
}
