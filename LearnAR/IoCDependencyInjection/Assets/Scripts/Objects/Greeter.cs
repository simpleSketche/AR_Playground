using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greeter : IGreeter
{
    private string message = "Hello, Welcome!";

    public string Message
    {
        get
        {
            return message;
        }
    }
}
