using Unity.VisualScripting;
using UnityEngine;
public class SpikeSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float distanceHeight;

    public float spawnDelay;
    private float nextTimeSpawn;
    public Vector3 spawnRotation;
    public Transform GameObject;
    public float minZ;
    public float maxZ;
    public float minX;
    public float maxX;

    private void Update()
    {
        if (Time.time >= nextTimeSpawn)
        {
            Vector3 playerPosition = transform.position;

            Instantiate(enemyPrefab, playerPosition + new Vector3(Random.Range(minX, maxX), distanceHeight, Random.Range(minZ,maxZ)), Quaternion.Euler(spawnRotation));
            nextTimeSpawn = Time.time + spawnDelay;

        }
    }
}