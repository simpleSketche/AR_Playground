using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    public Vector3 leftLane;
    public Vector3 rightLane;
    public float smoothness;

    public void ChangeLane()
    {
        if(transform.position.x == leftLane.x)
        {
            StartCoroutine(GoToRight());
        }
        else if(transform.position.x == rightLane.x)
        {
            StartCoroutine(GoToLeft());
        }
    }

    IEnumerator GoToRight()
    {
        // move truck from left to right lane
        while(transform.position.x < rightLane.x - 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, rightLane, Time.deltaTime * smoothness);
            yield return null;
        }
    }

    IEnumerator GoToLeft()
    {
        // move truck from right to left lane
        while(transform.position.x < leftLane.x + 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, leftLane, Time.deltaTime * smoothness);
            yield return null;
        }
    }
}
