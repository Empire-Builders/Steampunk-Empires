using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Barracks : Building {

	public Barracks(int level)
	{
		Level = level;
        goldCostToLevel = new Dictionary<int, float>();
        timeCostToLevel = new Dictionary<int, float>();
        for (int i = 1; i <=30; i++)
        {
            goldCostToLevel.Add(i, 100f);
            timeCostToLevel.Add(i, 5f);
        }
	}
}
