using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Village{

	public TownHall townhall;
	public Barracks barracks;
	public GoldMine goldMine;
	public Army army;
	public Button goldDisplay;
	public int population;
	public int gold;
	public int villageNo;
	public string owner;

    private TimingMananger timingManager;

	public Village(int VillageNo)
	{
		townhall = new TownHall (1);
		barracks = new Barracks (1);
		goldMine= new GoldMine (30);
		army = new Army ();
		population = 0;
		gold = 100;
		villageNo = VillageNo;
        timingManager = new TimingMananger(villageNo);
	}

	public void Update()
	{
		gold += goldMine.AddGold ();
        timingManager.Update();
	}

    public void Ugrade(Building building, float time)
    {
        timingManager.UpgradeBuilding(building, time);
    }

	public int points()
	{
		return townhall.Level + goldMine.Level + barracks.Level;
	}
}