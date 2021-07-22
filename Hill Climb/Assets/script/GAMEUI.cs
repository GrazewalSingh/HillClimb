using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEUI : MonoBehaviour
{
    public gameController gameController;


    public void OnGasButtonClicked()
    {
        gameController.Forward();
    }
    public void onBrakeButtonClicked()
    {
        gameController.Reverse();
    }
}
