using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PlayerCrashed : MonoBehaviour
{
    public UiController uiController;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //await Task.Delay(TimeSpan.FromSeconds(1));
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            uiController.showEndGameMenu();
            uiController.suspendPointsAccumulation();
        }
    }

}
