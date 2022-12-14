using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// the factory injects IGreeter to GreetingConsumer, and resolve a new greeting consumer object
/// </summary>
public class Factory : PlaceholderFactory<GreetingConsumer>
{

}
