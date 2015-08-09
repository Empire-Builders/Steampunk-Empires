using UnityEngine;
using System.Collections;

public class TimingMananger {

    private Building buildingBeingUpgraded;
    private bool isBuildingUpgrading;
    private float timeToFinishUpgrading;
    private Village village;

    public TimingMananger(int villageNumber)
    {
        village = GameController.control.getVillage(villageNumber);
        isBuildingUpgrading = false;
    }

	public void Update () {
	    if (isBuildingUpgrading)
        {
            if (timeToFinishUpgrading <= 0)
            {
                isBuildingUpgrading = false;
                buildingBeingUpgraded.Level += 1;
                LevelUpController.Leveller.ResetText(buildingBeingUpgraded);
            }
            else 
            {
                timeToFinishUpgrading -= Time.deltaTime;
                LevelUpController.Leveller.DisplayTimeRemaining(buildingBeingUpgraded, timeToFinishUpgrading);
            }
        }
	}

    public void UpgradeBuilding(Building building, float timeToUpgrade)
    {
        isBuildingUpgrading = true;
        timeToFinishUpgrading = timeToUpgrade;
        buildingBeingUpgraded = building;
    }
}
