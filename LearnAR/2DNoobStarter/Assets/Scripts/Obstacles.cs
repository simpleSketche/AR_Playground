using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private Vector3 direction = Vector3.down;

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// move obstacle
    /// </summary>
    private void Move()
    {
        Vector3 movement = direction * GameManager.Instance.obstacleSpeed / GameManager.Instance.spawnTimeInterval;
        transform.Translate(movement * Time.smoothDeltaTime); // moves transform to given direction
    }
}
