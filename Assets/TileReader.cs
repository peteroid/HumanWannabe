using UnityEngine;
using System.Collections;
using System;

public class TileReader : MonoBehaviour
{
    public GameObject[] tileMapSave;
    public GameObject[] toyMapSave;
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

        public int AssignArrayInteger(float current, float low)
        {
            int convertedInt;

            convertedInt = (int) (current - low);
            return convertedInt;
        }

    



    void Start()
    {
        tileMapSave = GameObject.FindGameObjectsWithTag("Tile");
        toyMapSave = GameObject.FindGameObjectsWithTag("Placeable");
        int tileCount = tileMapSave.Length;
        float lowestXCoordinate = 0f;
        float lowestYCoordinate = 0f;
        int levelWidth = 0;
        int levelHeight = 0;


        //get the lowest x and y in the array

        for (int i = 0; i < tileCount; ++i)
        {
            if (tileMapSave[i].transform.position.x < lowestXCoordinate)
                lowestXCoordinate = tileMapSave[i].transform.position.x;

            if (tileMapSave[i].transform.position.y < lowestYCoordinate)
                lowestYCoordinate = tileMapSave[i].transform.position.y;
        }

        //get the number of elements in each row and column

        for (int i = 0; i < tileCount; ++i)
        {
            if (tileMapSave[i].transform.position.x == lowestXCoordinate)
                levelWidth += 1;
            if (tileMapSave[i].transform.position.y == lowestXCoordinate)
                levelHeight += 1;
        }

        //create an array of correct proportions for the level
        int[,] levelMap = new int[levelHeight, levelWidth];

        foreach (GameObject tile in tileMapSave)
        {
            // get the (x,y) position ofthe tile for the new array

            int x = AssignArrayInteger(tile.transform.position.x, lowestXCoordinate);
            int y = AssignArrayInteger(tile.transform.position.y, lowestYCoordinate);

            //get the tile Id

            int tileId = GetTileId(tile);

            //generate the map

            levelMap[x, y] = tileId;


        }



Array.Sort(tileMapSave, delegate (GameObject tile1, GameObject tile2) 
{
    return tile1.transform.position.x.CompareTo(tile2.transform.position.x);
});
 


        
        

// sort array by x


    }

    // Update is called once per frame
    void Update()
    {

    }
}
