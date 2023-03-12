using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    public GameObject enemyPrefab; // The enemy prefab to spawn
    public int enemyCount = 10; // The number of enemies to spawn
    public float minDistanceFromSurface = 1f; // The minimum distance from the sphere's surface at which to spawn enemies
    public float maxDistanceFromSurface = 5f; // The maximum distance from the sphere's surface at which to spawn enemies

    private MeshFilter meshFilter;
    private Mesh mesh;
    private List<GameObject> enemyPool = new List<GameObject>(); // The pool of enemy game objects

    

    void Start()
    {
        
        // Get a reference to the sphere's mesh filter component
        meshFilter = GetComponent<MeshFilter>();
        mesh = meshFilter.mesh;

        // Create the pool of enemy game objects
        for (int i = 0; i < enemyCount; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab, Vector3.zero, new Quaternion(0, Random.Range(1, 360), 0, 0));
            enemy.SetActive(false); // Deactivate the enemy so it's not visible in the scene
            enemyPool.Add(enemy);
        }

        // Spawn the enemies
        for (int i = 0; i < enemyCount; i++)
        {
            Vector3 randomPoint = GetRandomPointOnMesh(mesh);

            // Calculate a random distance from the sphere's surface
            float distanceFromSurface = Random.Range(minDistanceFromSurface, maxDistanceFromSurface);

            // Calculate the spawn position based on the random point and distance from the surface
            Vector3 spawnPosition = randomPoint + distanceFromSurface * (randomPoint - transform.position).normalized;

            // Activate an enemy from the pool and set its position and rotation
            GameObject enemy = enemyPool[i];
            enemy.transform.position = spawnPosition;
            enemy.transform.rotation = Quaternion.identity;
            enemy.SetActive(true);
        }
    }

    Vector3 GetRandomPointOnMesh(Mesh mesh)
    {
        // Get a random vertex from the mesh
        Vector3[] vertices = mesh.vertices;
        int randomIndex = Random.Range(0, vertices.Length);
        Vector3 randomVertex = vertices[randomIndex];

        // Transform the vertex position from local space to world space
        Vector3 randomPoint = transform.TransformPoint(randomVertex);

        return randomPoint;
    }

   
}
