using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingConsumer : MonoBehaviour
{
    private IGreeter _greeter;
    private float timeBetweenMessage = 1.0f;
    private float timeSinceMessage = 0;
    
    /// <summary>
    /// Start is basically the MonoBehaviour constructor, inject the interface here so that every newly created game object
    /// can access the same greeter singleton information.
    /// </summary>
    /// <param name="greeter"></param>
    [Inject]
    public void Construct(IGreeter greeter)
    {
        _greeter = greeter;
    }

    private void Update()
    {
        timeSinceMessage += Time.deltaTime;
        if(timeSinceMessage > timeBetweenMessage)
        {
            Debug.Log(_greeter.Message);
            timeSinceMessage = 0;
        }
    }
}
