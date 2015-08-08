using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Village{

	public TownHall townhall;
	public Barracks barracks;
	public GoldPit goldPit;
	public Army army;
	public Button goldDisplay;
	public int population;
	public int gold;
	public int villageNo;
	public string owner;

	public Village(int VillageNo)
	{
		townhall = new TownHall (1);
		barracks = new Barracks (1);
		goldPit = new GoldPit (1);
		army = new Army ();
		population = 0;
		gold = 100;
		villageNo = VillageNo;
	}

	public int points()
	{
		return townhall.Level + goldPit.Level + barracks.Level;
	}
}
