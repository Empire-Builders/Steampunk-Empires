using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoldDisplay : MonoBehaviour {

	public Image button;

	// Update is called once per frame
	void Update () 
	{
		button.GetComponentInChildren<Text>().text = "Gold: " + GameController.control.getVillage(GameController.control.currentVillage).gold.ToString();
	}
}
