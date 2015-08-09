using UnityEngine;
using System.Collections;

public class GoldMine : Building {

	private float timeForGold;
	private int goldToAdd;

	public GoldMine(int level)
	{
		Level = level;
		timeForGold = 0.0f;
	}
	
	public int AddGold () 
	{
		if (timeForGold <= 0)
        {
			goldToAdd = 1;
			timeForGold = TimeTillNextGold();
		} 

        else 
        {
			timeForGold -= Time.deltaTime;
			goldToAdd = 0;
		}
        return goldToAdd;
	}

	private int TimeTillNextGold()
	{
		return (30 - Level);
	}
}
