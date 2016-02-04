using UnityEngine;
using System.Collections;
using System;

public class TileReader : MonoBehaviour
{
    public int AssignArrayInteger(float current, float low)
            {
                int convertedInt;

                convertedInt = (int) (current - low);
                return convertedInt;
            }
    // Use this for initialization
    public int GetTileId(GameObject obj)
    {
        string tileName;
        int tileId = 0;

        tileName = obj.name;

        if (tileName.StartsWith("Passable"))
        {
            tileId = 0;
        }
        else if (tileName.StartsWith("Wall"))
        {
            tileId = 1;
        }
        else if (tileName.StartsWith("CatBed"))
        {
            tileId = 2;
        }
        else if (tileName.StartsWith("GoldenHuman"))
        {
            tileId = 3;
        }
        else if (tileName.StartsWith("EmptyTile"))
        {
            tileId = 4;
        }
        else if (tileName.StartsWith("BlockPassage"))
        {
            tileId = 5;
        }
        else if (tileName.StartsWith("PressureTile"))
        {
            tileId = 1;
        }
        else if (tileName.StartsWith("OmenDoor"))
        {
            tileId = 1;
        }
        else if (tileName.StartsWith("PushTileUpRight"))
        {
            tileId = 10;
        }
        else if (tileName.StartsWith("PushTileUpLeft"))
        {
            tileId = 13;
        }
        else if (tileName.StartsWith("PushTileDownRight"))
        {
            tileId = 11;
        }
        else if (tileName.StartsWith("PushTileDownLeft"))
        {
            tileId = 12;
        }

        return tileId;
    }

        

    



    void Start()
    {
        



 


        
        

// sort array by x


    }

    // Update is called once per frame
    void Update()
    {

    }
}
