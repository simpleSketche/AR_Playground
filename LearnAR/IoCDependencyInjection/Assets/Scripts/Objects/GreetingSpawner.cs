using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingSpawner : MonoBehaviour
{
    public GreetingConsumer consumerPrefab;

    private Bounds bounds;
    public Vector3 boundsSize = new Vector3(1, 1, 0);
    public float timeBetweenSpawns = -1.0f;
    private float timeSinceSpawn = 0;
    private IGreeter _greeting;
    private Factory _factory;

    private void Start()
    {
        bounds = new Bounds(Vector3.zero, boundsSize);
    }

    [Inject]
    public void Construct(IGreeter greeting, Factory factory)
    {
        _greeting = greeting;
        _factory = factory;
    }

    private void Update()
    {
        timeSinceSpawn += Time.deltaTime;

        if(timeSinceSpawn > timeBetweenSpawns)
        {
            //spawn here through factory
            GreetingConsumer consumer = _factory.Create();
            consumer.transform.position = GetRandomSpawnPosition();

            timeSinceSpawn = 0;
        }
    }

    private Vector3 GetRandomSpawnPosition()
    {
        float xPos = (Random.value - 0.5f) * bounds.size.x;
        float yPos = (Random.value - 0.5f) * bounds.size.y;
        float zPos = (Random.value - 0.5f) * bounds.size.z;

        return new Vector3(xPos, yPos, zPos);
    }
}
