using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public car car;

    public void Forward()
    {
        car.Forward();
    }
    public void Reverse()
    {
        car.Reverse();
    }
}
