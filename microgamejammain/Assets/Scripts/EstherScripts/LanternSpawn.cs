using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LanternSpawn : MonoBehaviour
{
    Tilemap tilemap;
    public List<Vector3> tileWorldLocations;
    public GameObject lantern;
    // Start is called before the first frame update
    void Start()
    {
        tilemap = FindObjectOfType<Tilemap>(); 
        lanternspawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void lanternspawn()
    {
        //select quadrant



        //get tiles to spawn in
        foreach (var pos in tilemap.cellBounds.allPositionsWithin)
        {
            Vector3Int localPlace = new Vector3Int(pos.x, pos.y, pos.z);
            Vector3 place = tilemap.CellToWorld(localPlace);
            if (tilemap.HasTile(localPlace) != true)
            {
                tileWorldLocations.Add(place);
            }
        }
        float randrange = Mathf.Floor(Random.Range(0f, tileWorldLocations.Count));
        //randomly spawns between 2-5 lanterns
        for (int i = 0; i <= Random.Range(2f, 5f); i++)
        {
            randrange += 2 * i;
            if (randrange>tileWorldLocations.Count)
            {
                randrange -= 10 * i; 
            }
            Vector3 lanternpos = tileWorldLocations[((int)randrange)];
            lanternpos.x += 0.5f;
            lanternpos.y += 0.5f;
            lanternpos.z -= 1f;
            Instantiate(lantern, lanternpos, Quaternion.identity);
        }

    }
}
