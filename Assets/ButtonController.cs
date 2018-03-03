using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonController : MonoBehaviour
{


    public GameObject Bot1;
    public GameObject Bot2;
    public GameObject Bot3;
    public GameObject Bot4;
    public GameObject Bot5;
    public GameObject Bot6;
    public GameObject Bot7;
    public GameObject Bot8;
    public GameObject Bot9;
    public GameObject Bot10;

    public bool BotFactoryT1 = false;
    public bool TankFactoryT1 = false;

    public GameObject Factory;

    // Use this for initialization
    void Update()
    {
        if (Factory != null)
        {
            /*
            if (Unit1.GetComponent<Button> ().onClick) {
             Factory.GetComponent<UnitSpawner> ().SpawnUnitBot1 ();
            }
            if (Unit2.GetComponent<Button> ().onClick) {
             Factory.GetComponent<UnitSpawner> ().SpawnUnitBot1 ();
            }
            if (Unit3.GetComponent<Button> ().onClick) {
             Factory.GetComponent<UnitSpawner> ().SpawnUnitBot1 ();
            }
            if (Unit4.GetComponent<Button> ().onClick) {
             Factory.GetComponent<UnitSpawner> ().SpawnUnitBot1 ();
            }
            */
        }
    }

    public void Unit1()
    {
        if (BotFactoryT1 == true)
        {
            Factory.GetComponent<UnitSpawner>().unit = Bot1;
            Factory.GetComponent<UnitSpawner>().prodTime = 5.0f;
            //Factory.GetComponent<UnitSpawner>().unitRequestAmount = 1;
            Factory.GetComponent<UnitSpawner>().UnitRequest(1);
        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit2()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit3()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit4()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit5()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit6()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit7()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit8()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit9()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
    void Unit10()
    {
        if (BotFactoryT1 == true)
        {

        }
        if (TankFactoryT1 == true)
        {

        }
    }
}