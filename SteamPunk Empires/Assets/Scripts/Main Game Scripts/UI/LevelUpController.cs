using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelUpController : MonoBehaviour {

    public static LevelUpController Leveller;

    public Image UpdateTownHallButton;
    public Image UpdateBarracksButton;
    public Image UpdateGoldMineButton;

    private Village village;
    private Image workingImage;
    private bool updating;

    void Start () 
    {
        Leveller = this;
        setVillage();
        updating = false;
    }

    public void DisplayTimeRemaining(Building buildingBeingUpgraded, float timer)
    {
        if (UpdateTownHallButton != null && buildingBeingUpgraded == village.townhall)
            UpdateTownHallButton.GetComponentInChildren<Text>().text = "Time Left: " + timer.ToString("n2");
        if (UpdateBarracksButton != null && buildingBeingUpgraded == village.barracks)
            UpdateBarracksButton.GetComponentInChildren<Text>().text = "Time Left: " + timer.ToString("n2");
        if (UpdateGoldMineButton != null && buildingBeingUpgraded == village.goldMine)
            UpdateGoldMineButton.GetComponentInChildren<Text>().text = "Time Left: " + timer.ToString("n2");
    }

    private void setVillage()
    {
        village = GameController.control.getVillage(GameController.control.currentVillage);
    }

    public void UpgradeTownHall()
    {
        if (!updating)
        {
            if (village.CanAfford(village.townhall))
            {
                village.Ugrade(village.townhall, village.townhall.TimeCostToLevel());
                village.gold -= village.townhall.GoldCostToLevel();
                workingImage = UpdateTownHallButton;
                updating = true;
            }
        }
    }

    public void UpgradeBarracks()
    {
        if (!updating)
        {
            if (village.CanAfford(village.barracks))
            {
                village.Ugrade(village.barracks, village.barracks.TimeCostToLevel());
                village.gold -= village.barracks.GoldCostToLevel();
                workingImage = UpdateBarracksButton;
                updating = true;
            }
        }
    }

    public void UpgradeGoldMine()
    {
        if (!updating)
        {
            if (village.CanAfford(village.barracks))
            {
                village.Ugrade(village.goldMine, village.goldMine.TimeCostToLevel());
                village.gold -= village.goldMine.GoldCostToLevel();
                workingImage = UpdateBarracksButton;
                updating = true;
            }
        }
    }

    public void ResetText(Building buildingFinishedUpgrading)
    {
        if (buildingFinishedUpgrading == village.townhall && UpdateTownHallButton != null)
           UpdateTownHallButton.GetComponentInChildren<Text>().text = "Level Up Town Hall";
        if (buildingFinishedUpgrading == village.barracks && UpdateBarracksButton != null)
            UpdateBarracksButton.GetComponentInChildren<Text>().text = "Level Up Barracks";
        if (buildingFinishedUpgrading == village.goldMine && UpdateGoldMineButton != null)
            UpdateGoldMineButton.GetComponentInChildren<Text>().text = "Level Up Gold Mine";
        updating = false;
    }
}
