using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InputMethods
{
    Keyboard,
    Mouse,
    Touch
}

public class PlayerController : MonoBehaviour
{
    public InputMethods inputMethod;
    public Truck redTruck;
    public Truck blueTruck;

    private void Update()
    {
        if(inputMethod == InputMethods.Keyboard)
        {
            KeyboardControl();
        }
        else if(inputMethod == InputMethods.Mouse)
        {
            MouseControl();
        }
        else if(inputMethod == InputMethods.Touch)
        {
            TouchControl();
        }
    }

    private void KeyboardControl()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // move red truck
            redTruck.ChangeLane();

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // move blue truck
            blueTruck.ChangeLane();
        }
    }

    private void MouseControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Input.mousePosition.x < Screen.width / 2)
            {
                // move red truck
                redTruck.ChangeLane();
            }
            else
            {
                // move blue truck
                blueTruck.ChangeLane();
            }
        }
    }

    private void TouchControl()
    {
        foreach(Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                if(touch.position.x < Screen.width / 2)
                {
                    // move red truck
                    redTruck.ChangeLane();
                }
                else
                {
                    // move blue truck
                    blueTruck.ChangeLane();
                }
            }
        }
    }
}
