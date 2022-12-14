using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GreetingConsumer : MonoBehaviour
{
    private IGreeter _greeter;
    
    /// <summary>
    /// Start is basically the MonoBehaviour constructor, inject the interface here so that every newly created game object
    /// can access the same greeter singleton information.
    /// </summary>
    /// <param name="greeter"></param>
    [Inject]
    public void Start(IGreeter greeter)
    {
        _greeter = greeter;
    }

    private void Update()
    {
        Debug.Log(_greeter.Message);
    }
}
