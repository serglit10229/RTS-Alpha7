using UnityEngine;
using System.Collections;

public class PlayerSelection : MonoBehaviour {    
    // Selection Circle
    public GameObject circle;
    //public GameObject tc;

	public UIManager UM;

	public UnitManager unitManager;

	public bool BotFactoryT1 = false;
	public bool TankFactoryT1 = false;

	public GameObject BotT1UI;
	public GameObject TankT1UI;

	void Update()
	{
		UM = GameObject.Find("UIManager").GetComponent<UIManager>();
		unitManager = GameObject.Find("UnitManager").GetComponent<UnitManager>();
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
            UM.ShowUI("Tank1", gameObject);
        }
		if (TankFactoryT1 == false && BotFactoryT1 == false) 
		{
			if (!unitManager.units.Contains (gameObject)) 
			{
				unitManager.units.Add(gameObject);
			}
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
            UM.HideUI("Tank1");
        }
		if (TankFactoryT1 == false && BotFactoryT1 == false) 
		{
			if (unitManager.units.Contains (gameObject)) 
			{
				unitManager.units.Remove(gameObject);
			}
		}
    }
}
