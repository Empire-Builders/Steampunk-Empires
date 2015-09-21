using UnityEngine;
using System.Collections;

public class Army{

	public SteamSoldier steamSoldier;
	public Airship airship;

    public Army()
    {
        steamSoldier = new SteamSoldier();
        airship = new Airship();
    }
}
