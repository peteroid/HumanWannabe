using UnityEngine;
using System.Collections;
using System;

public class ToyReader : MonoBehaviour {

    public int AssignArrayInteger(float current, float low)
    {
        int convertedInt;

        convertedInt = (int) Math.Round(current - low);
        return convertedInt;
    }

    public int GetToyId(GameObject obj)
    {
        string tileName;
        int toyId = 0;

        tileName = obj.name;

        if (tileName.StartsWith("Chair"))
        {
            toyId = -1;
        }
        else if (tileName.StartsWith("ToyBall"))
        {
            toyId = -2;
        }
        else if (tileName.StartsWith("CatToy"))
        {
            toyId = -3;
        }
        else if (tileName.StartsWith("CommandBlock"))
        {
            toyId = -4;
        }
        else if (tileName.StartsWith("Character"))
        {
            toyId = -9;
        }
       
        return toyId;
    }




    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
