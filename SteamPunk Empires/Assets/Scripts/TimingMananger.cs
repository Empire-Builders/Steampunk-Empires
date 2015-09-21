using UnityEngine;
using System.Collections;

public class TimingMananger {

    private Building buildingBeingUpgraded;
    private Unit unitBeingBuilt;
    private bool isBuildingUpgrading;
    private bool isBuildingUnits;
    private float timeToFinishUpgrading;
    private float timeToFinishBuildingUnit;
    private float buildTimePerUnit;
    private int unitsToFinish;
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
        if (isBuildingUnits)
        {
            if(timeToFinishBuildingUnit <= 0)
            {
                if (unitsToFinish == 0)
                {
                    isBuildingUnits = false;
                    unitBeingBuilt.quantityOfUnit += 1;
                    UnitBuildingController.Builder.ResetText(unitBeingBuilt);
                }
                else 
                {
                    unitsToFinish -= 1;
                    timeToFinishUpgrading = buildTimePerUnit;
                    unitBeingBuilt.quantityOfUnit += 1;
                }
            }
            else 
            {
                timeToFinishUpgrading -= Time.deltaTime;
                UnitBuildingController.Builder.DisplayTimeAndNumberRemaining(unitBeingBuilt, unitsToFinish, timeToFinishBuildingUnit);
            }
        }
	}

    public void UpgradeBuilding(Building building, float timeToUpgrade)
    {
        isBuildingUpgrading = true;
        timeToFinishUpgrading = timeToUpgrade;
        buildingBeingUpgraded = building;
    }

    public void BuildUnits(Unit unit, int numberToBuild, float timePerUnit)
    {
        isBuildingUnits = true;
        unitBeingBuilt = unit;
        unitsToFinish = numberToBuild;
        buildTimePerUnit = timePerUnit;
    }
}
