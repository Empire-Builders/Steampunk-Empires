using UnityEngine;
using System.Collections;

public class VillageLoad : MonoBehaviour {
	
	public GameObject loadingImage;
	public int villageNo;
	
	public void LoadScene(int level)
	{
		loadingImage.SetActive(true);
		GameController.control.currentVillage = villageNo;
		Application.LoadLevel(level);
	}
}