using UnityEngine;
using System.Collections;

public class levelMapper : MonoBehaviour {

    public GameObject[] tileMapSave;
    public GameObject[] toyMapSave;

    // Use this for initialization
    void Start ()
    {
        TileReader ActiveTiles = new TileReader();
        ToyReader ActiveToys = new ToyReader();
            
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

            int tileX = ActiveTiles.AssignArrayInteger(tile.transform.position.x, lowestXCoordinate);
            int tileY = ActiveTiles.AssignArrayInteger(tile.transform.position.y, lowestYCoordinate);

            //get the tile Id

            int tileId = ActiveTiles.GetTileId(tile);

            //generate the map

            levelMap[tileX, tileY] = tileId;


        }

        //get the toys

        foreach (GameObject toy in toyMapSave)
        {
            //get (x,y) position of the toy for the new array

            int toyX = ActiveToys.AssignArrayInteger(toy.transform.position.x, lowestXCoordinate);
            int toyY = ActiveToys.AssignArrayInteger(toy.transform.position.y, lowestYCoordinate);

            //get the toy Id

            int toyId = ActiveToys.GetToyId(toy);

            //overwrite the level map with toys

            levelMap[toyX, toyY] = toyId;
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
