using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public Axle2D[] axles;
    public float speed;
    public void Reverse()
    {
        MoveCar(speed);
    }
    public void Forward()
    {
        MoveCar(-speed);
    }
    public void MoveCar(float speed)
    {
        foreach(Axle2D axle in axles)
        {
            if (axle.hasMotor)
            {
                axle.rigidbody.AddTorque(speed * axle.speedMultiplier);
            }
        }
    }
}
[System.Serializable]

public struct Axle2D
{
    public bool hasMotor;
    public Rigidbody2D rigidbody;
    public float speedMultiplier;
}

