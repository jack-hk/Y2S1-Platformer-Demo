using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//JackHK

public static class InputManager
{
    public enum MoveDirection
    {
        none,
        left = -1,
        right = 1
    }

    public static MoveDirection Walk()
    {
        switch (Input.GetAxisRaw("Horizontal"))
        {
            case -1:
                Debug.Log("left");
                return MoveDirection.left;
            case 1:
                Debug.Log("right");
                return MoveDirection.right;
            default:
                return MoveDirection.none;
        }
    }

    public static bool Attack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
