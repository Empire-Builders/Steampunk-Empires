using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GoldMine : Building {

    private Dictionary<int, float> goldPMPL;
	private float goldPerMinute;

	public GoldMine(int level)
    {
        Level = level;
        goldCostToLevel = new Dictionary<int, float>();
        timeCostToLevel = new Dictionary<int, float>();
        goldPMPL = new Dictionary<int, float>();
        for (int i = 1; i <=30; i++)
        {
            goldCostToLevel.Add(i, 100f);
            timeCostToLevel.Add(i, 5f);
            goldPMPL.Add(i, 10000f + ((float)i*(float)i));
        }
    }
	
	public float AddGold () 
	{
        return goldToAdd();
	}

    private float goldToAdd ()
    {
        goldPerMinute = goldPMPL[Level];
        return (goldPerMinute / 60f) * Time.deltaTime;
    }
}
