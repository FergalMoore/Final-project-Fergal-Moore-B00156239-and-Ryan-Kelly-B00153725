using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject[] roadPrefabs;
    public float zSpawn = 0;
    public float roadLength = 30;
    public int roadCount = 5;

    // Private list to store active road GameObjects.
    private List<GameObject> activeRoads = new List<GameObject>();
    public Transform playerTransform;

    // Spawns a specified number of roads at the start.
    void Start()
    {
        for (int i = 0; i < roadCount; i++) {

            SpawnRoad(Random.Range(0, roadPrefabs.Length));

        }

    }

    // Checks if the player's position triggers road spawning and deletion.
    void Update()
    {
        if(playerTransform.position.z - 35 > zSpawn - (roadCount * roadLength)) {

            SpawnRoad(Random.Range(0, roadPrefabs.Length));
            DeleteRoad();
        }
    }
    // Spawns a road at the specified index and updates the active roads list.
    public void SpawnRoad(int roadIndex)
    {

       GameObject go = Instantiate(roadPrefabs[roadIndex], transform.forward * zSpawn, transform.rotation);
        activeRoads.Add(go);
        zSpawn += roadLength;
    }
    // Deletes the oldest road from the active roads list.
    private void DeleteRoad()
    {
        Destroy(activeRoads[0]);
        activeRoads.RemoveAt(0);
    }
}
