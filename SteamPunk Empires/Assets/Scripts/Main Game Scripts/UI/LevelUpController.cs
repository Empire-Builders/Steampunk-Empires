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

    void Awake () 
    {
        Leveller = this;
        setVillage();
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
        village.Ugrade(village.townhall, 10);
        workingImage = UpdateTownHallButton;
    }

    public void UpgradeBarracks()
    {
        village.Ugrade(village.barracks, 10);
        workingImage = UpdateBarracksButton;
    }

    public void UpgradeGoldMine()
    {
        village.Ugrade(village.goldMine, 10);
        workingImage = UpdateGoldMineButton;
    }

    public void ResetText(Building buildingFinishedUpgrading)
    {
        if (buildingFinishedUpgrading == village.townhall && UpdateTownHallButton != null)
           UpdateTownHallButton.GetComponentInChildren<Text>().text = "Level Up Town Hall";
        if (buildingFinishedUpgrading == village.barracks && UpdateBarracksButton != null)
            UpdateBarracksButton.GetComponentInChildren<Text>().text = "Level Up Barracks";
        if (buildingFinishedUpgrading == village.goldMine && UpdateGoldMineButton != null)
            UpdateGoldMineButton.GetComponentInChildren<Text>().text = "Level Up Gold Mine";
    }
}
