using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Map : MonoBehaviour {

    [Header("Map Info")]
    public string tilesetPath;
    public int mapWidth;
    public int mapHeight;
    public float tileSize;
    public List<Tile>[,] mapTiles;
        
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
