using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] redObstacles;
    public GameObject[] blueObstacles;

    private float LL = -4.05f;
    private float LR = -1.35f;
    private float RL = 1.35f;
    private float RR = 4.05f;

    /// <summary>
    /// automatically start when run in unity
    /// </summary>
    private void Start()
    {
        
    }

    // startSpawn method to start spawn
    public void StartSpawn()
    {
        StartCoroutine(SpawnRedObstacles());
        StartCoroutine(SpawnBlueObstacles());
    }

    public void StopSpawn()
    {
        // stops all corountines running on this gameobject
        StopAllCoroutines();
    }

    // generate obstacle for red truck
    IEnumerator SpawnRedObstacles()
    {
        yield return new WaitForSeconds(Random.Range(0, 1f));

        while (GameManager.Instance.IsGameActive)
        {
            // decide which item to be spawned as obstacle
            int type = Random.Range(0, 2);

            // decide which lane to spawn
            int lane = Random.Range(0, 2);

            float positionX;
            positionX = lane == 0 ? LL : LR;

            // Instantiate obstacles
            GameObject item = Instantiate(redObstacles[type], new Vector3(positionX, 10.5f, 0), Quaternion.identity) as GameObject;

            // make child of spawn manager
            item.transform.SetParent(transform); // transform refers SpawnManager

            yield return new WaitForSeconds(GameManager.Instance.spawnTimeInterval);
        }
        yield break;
    }

    // generate obstacle for blue truck
    IEnumerator SpawnBlueObstacles()
    {
        yield return new WaitForSeconds(Random.Range(0, 1f));

        while (GameManager.Instance.IsGameActive)
        {
            // decide which item to be spawned as obstacle
            int type = Random.Range(0, 2);

            // decide which lane to spawn
            int lane = Random.Range(0, 2);

            float positionX;
            positionX = lane == 0 ? RL : RR;

            // Instantiate obstacles
            GameObject item = Instantiate(blueObstacles[type], new Vector3(positionX, 10.5f, 0), Quaternion.identity) as GameObject;

            // make child of spawn manager
            item.transform.SetParent(transform); // transform refers SpawnManager

            yield return new WaitForSeconds(GameManager.Instance.spawnTimeInterval);
        }
        yield break;
    }
}
