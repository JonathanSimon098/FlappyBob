using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipePrefab; // Reference to the pipe prefab
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe(); // Spawn the first pipe immediately
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
