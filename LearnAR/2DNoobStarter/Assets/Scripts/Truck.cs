using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    public Vector3 leftLane;
    public Vector3 rightLane;
    public Vector3 leftRotation;
    public Vector3 rightRotation;
    public float smoothness;

    public void ChangeLane()
    {
        if (transform.position.x == leftLane.x)
        {
            StartCoroutine(GoToRight());
            StartCoroutine(Rotate(rightRotation));
        }
        else if (transform.position.x == rightLane.x)
        {
            StartCoroutine(GoToLeft());
            StartCoroutine(Rotate(leftRotation));
        }
    }

    IEnumerator GoToRight()
    {
        // move truck from left to right lane
        while (transform.position.x < rightLane.x - 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, rightLane, Time.deltaTime * smoothness);
            yield return null;
        }
        transform.position = rightLane;
    }

    IEnumerator GoToLeft()
    {
        // move truck from right to left lane
        while (transform.position.x < leftLane.x + 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, leftLane, Time.deltaTime * smoothness);
            yield return null;
        }
        transform.position = leftLane;
    }

    IEnumerator Rotate(Vector3 rotation)
    {
        // rotate to given angle
        while(Mathf.Round(transform.localEulerAngles.z) != rotation.z)
        {
            float angle = Mathf.LerpAngle(transform.localEulerAngles.z, rotation.z, Time.deltaTime * smoothness);

            transform.localEulerAngles = Vector3.forward * angle;
            yield return null;
        }
        // Rotate back to zero
        while(Mathf.Round(transform.localEulerAngles.z) != Vector3.zero.z)
        {
            float angle = Mathf.LerpAngle(transform.localEulerAngles.z, Vector3.zero.z, Time.deltaTime * smoothness);
            transform.localEulerAngles = Vector3.forward * angle;
            yield return null;
        }
    }
}
