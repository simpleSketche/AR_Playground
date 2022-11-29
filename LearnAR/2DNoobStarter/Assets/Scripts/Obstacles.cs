using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Obstacle,
    Coin
}


public class Obstacles : MonoBehaviour
{
    private Vector3 direction = Vector3.down;

    public ItemType itemType;

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// move obstacle
    /// </summary>
    private void Move()
    {
        if (!GameManager.Instance.IsGameActive)
        {
            return;
        }
        Vector3 movement = direction * GameManager.Instance.obstacleSpeed / GameManager.Instance.spawnTimeInterval;
        transform.Translate(movement * Time.smoothDeltaTime); // moves transform to given direction
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(itemType == ItemType.Coin)
        {
            // check if coin collides with truck
            if (collision.gameObject.CompareTag("Trucks"))
            {
                // destroy coin
                Destroy(this.gameObject);

                // score + 1
                GameManager.Instance.Score += 1;
                HudPanelController.Instance.UpdateScore();
            }
            // else if the coin collides with end bar
            else
            {
                // destroy coin, and game over!
                GameController.Instance.StopGame();
            }
        }
        else if(itemType == ItemType.Obstacle)
        {
            if (collision.gameObject.CompareTag("Trucks"))
            {
                // destroy obstacle and game over!
                Destroy(this.gameObject);
                GameController.Instance.StopGame();
            }
            // if obstacle reach end bar
            else if(collision.gameObject.CompareTag("End"))
            {
                // destroy obstacle
                Destroy(this.gameObject);
            }
        }
    }
}
