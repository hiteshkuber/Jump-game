using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float heightOffset = 10.0f;
    private float spawnRate = 2.5f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        pipeSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            pipeSpawn();
            timer = 0.0f;
        }
    }

    void pipeSpawn()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
