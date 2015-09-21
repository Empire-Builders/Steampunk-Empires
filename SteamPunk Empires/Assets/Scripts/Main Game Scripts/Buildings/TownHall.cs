using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TownHall : Building {

	public TownHall(int level)
    {
        Level = level;
        goldCostToLevel = new Dictionary<int, float>();
        timeCostToLevel = new Dictionary<int, float>();
        for (int i = 1; i <=30; i++)
        {
            goldCostToLevel.Add(i, 110f);
            timeCostToLevel.Add(i, 5f);
        }
    }
}
