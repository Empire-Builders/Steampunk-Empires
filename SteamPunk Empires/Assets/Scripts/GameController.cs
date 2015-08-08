using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public static GameController control;

	public Village[] villages;
	public int currentVillage;

	void Awake () 
	{
		if (control == null) 
		{
			DontDestroyOnLoad (gameObject);
			control = this;
		} 
		else if (control != this) 
		{
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		villages = new Village[4];
		villages[0] = new Village (0);
		villages[1] = new Village (1);
		villages[2] = new Village (2);
		villages[3] = new Village (3);
	}
	
	public Village getVillage(int i)
	{
		return villages [i];
	}
}
