using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Fish;
    [SerializeField] private float spawnInterval = 5f;
    [SerializeField] private float spawnRange = 7f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnFish), 1f, spawnInterval);
    }

    private void SpawnFish()
    {
        Vector2 randomPos = new Vector2(Random.Range(-spawnRange, spawnRange), 0);

        Instantiate(Fish, randomPos, Quaternion.identity);
    }
}
