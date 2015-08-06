using UnityEngine;
using System.Collections;

public class Village : MonoBehaviour{

	public Headquarters headquarters;
	public Barracks barracks;
	public GoldPit goldPit;

	void Start()
	{
		Headquarters headquarters = new Headquarters(1);
		Barracks barracks = new Barracks (1);
		GoldPit goldPit = new GoldPit (1);
	}


	public int points()
	{
		return headquarters.Level + goldPit.Level + barracks.Level;
	}


}
