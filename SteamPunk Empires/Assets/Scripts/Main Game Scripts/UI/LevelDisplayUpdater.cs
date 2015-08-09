using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelDisplayUpdater: MonoBehaviour {
	
	public Image townHallLvlButton;
	public Image barracksLvlButton;
	public Image goldMineLvlButton;
	
	// Update is called once per frame
	void Update () 
	{
		townHallLvlButton.GetComponentInChildren<Text>().text = "Level: " + GameController.control.getVillage(GameController.control.currentVillage).townhall.Level.ToString();
		barracksLvlButton.GetComponentInChildren<Text>().text = "Level: " + GameController.control.getVillage(GameController.control.currentVillage).barracks.Level.ToString();
		goldMineLvlButton.GetComponentInChildren<Text>().text = "Level: " + GameController.control.getVillage(GameController.control.currentVillage).goldMine.Level.ToString();
	}
}
