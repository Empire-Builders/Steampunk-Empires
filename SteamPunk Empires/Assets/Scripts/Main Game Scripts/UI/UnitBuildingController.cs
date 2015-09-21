using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class UnitBuildingController : MonoBehaviour {
    
    public static UnitBuildingController Builder;
    
    public Image BuildSteamSoldiersButton;
    public int SoldiersToBuild;
    
    private Village village;
    private bool buildingUnit;
    
    void Start () 
    {
        Builder = this;
        setVillage();
        buildingUnit = false;
    }

    public void DisplayTimeAndNumberRemaining(Unit unit, int numberRemaning, float timer)
    {
        //stuff
    }

    public void BuildSteamSoldiers()
    {
        if(SoldiersToBuild != 0)
        {
            if (!buildingUnit)
            {
                village.BuildUnits(village.standingArmy.steamSoldier, SoldiersToBuild);
                buildingUnit = true;
            }
        }
    }

    public void SetSoldiersToBuild(InputField input)
    {
        if (!string.IsNullOrEmpty(input.text))
        {
            SoldiersToBuild = Convert.ToInt32(input.text);
        } else 
            SoldiersToBuild = 0;
    }

    public void ResetText(Unit unitFinishedBuilding)
    {
        // stuff
        buildingUnit = false;
    }

    private void setVillage()
    {
        village = GameController.control.getVillage(GameController.control.currentVillage);
    }
}