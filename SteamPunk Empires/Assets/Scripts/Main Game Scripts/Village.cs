using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Village : MonoBehaviour{

	public Headquarters headquarters;
	public Barracks barracks;
	public GoldPit goldPit;
	public Army army;
	public int population;
	public int gold;
	public Button goldDisplay;

	void Start()
	{
		headquarters = new Headquarters (1);
		barracks = new Barracks (1);
		goldPit = new GoldPit (1);
		army = new Army ();
		population = 0;
		gold = 13;
	}

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}

	void Update()
	{
		UpdateGold ();
	}


	public int points()
	{
		return headquarters.Level + goldPit.Level + barracks.Level;
	}

	private void UpdateGold()
	{
		
	}


}
