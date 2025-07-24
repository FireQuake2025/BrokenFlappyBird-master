using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject PipePrefab;
    public float SpawnRate = .1f;
    public float RandomVariable = 1f;
    public Transform PrefabStartLocation;

    private float introTimer = float.MaxValue;
    private bool isSpawning = false;

    void Update()
    {
        introTimer += Time.deltaTime;
        if (introTimer >= SpawnRate)
        {
            StartSpawning();
            SpawnPipe();
            introTimer = 0f;
        }
    }

    public void StartSpawning()
    {
        isSpawning = true;
    }

    void SpawnPipe()
    {
        if (isSpawning)
        {
            float yOffset = Random.Range(-RandomVariable, RandomVariable);
            Vector3 spawnPosition = PrefabStartLocation.position + Vector3.up * yOffset;
            Instantiate(PipePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
