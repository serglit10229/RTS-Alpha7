using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {


	public GameObject Bot1UI;
	public GameObject Tank1UI;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	public void ShowUI (string factoryID, GameObject factory) {
		if (factoryID == "Bot1") 
		{
			Bot1UI.SetActive (true);
			Bot1UI.GetComponent<ButtonController>().Factory = factory;
		}
	}

	public void HideUI(string factoryID)
	{
		if (factoryID == "Bot1") 
		{
			Bot1UI.GetComponent<ButtonController>().Factory = null;
			Bot1UI.SetActive (false);
		}
	}
}
