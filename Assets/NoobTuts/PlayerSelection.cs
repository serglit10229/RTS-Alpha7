﻿using UnityEngine;
using System.Collections;

public class PlayerSelection : MonoBehaviour {    
    // Selection Circle
    public GameObject circle;
    //public GameObject tc;

	public UIManager UM;

	public bool BotFactoryT1 = false;
	public bool TankFactoryT1 = false;

	public GameObject BotT1UI;
	public GameObject TankT1UI;

	void Update()
	{
		UM = GameObject.Find("UIManager").GetComponent<UIManager>();
	}

    // OnSelect is called by the RTS Selection System
    void OnSelect() {
        Debug.Log("OnSelect");
        circle.SetActive(true);
        //tc.GetComponent<Count>().selectedUnits++;

		if (BotFactoryT1 == true) 
		{
			UM.ShowUI ("Bot1",gameObject);
		}
		if (TankFactoryT1 == true) 
		{
			
		}
    }
    
    // OnDeselect is called by the RTS Selection System
    void OnDeselect() {
        Debug.Log("OnDeselect");
        circle.SetActive(false);
        //tc.GetComponent<Count>().selectedUnits--;

		if (BotFactoryT1 == true) 
		{
			UM.HideUI ("Bot1");
		}
		if (TankFactoryT1 == true) 
		{

		}
    }
}
