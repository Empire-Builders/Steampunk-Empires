using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Building{

    public int Level;
    public int MaxLevel;

    public Dictionary<int, float> goldCostToLevel;
    public Dictionary<int, float> timeCostToLevel;

    public float GoldCostToLevel()
    {
        return goldCostToLevel[Level];
    }

    public float TimeCostToLevel()
    {
        return timeCostToLevel[Level];
    }
}

