using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public Text gameOverText;
    public Button restartGameButton;

    public Text pointsText;
    float points = 0;

    private bool pointsSuspended = false;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pointsSuspended)
        {
            points++;
        }
        pointsText.text = points.ToString();
    }

    public void suspendPointsAccumulation()
    {
        pointsSuspended = true;
    }
    public void resumePointsAccumulation()
    {
        pointsSuspended = false;
    }

    public void showEndGameMenu()
    {
        gameOverText.gameObject.SetActive(true);
             restartGameButton.gameObject.SetActive(true);

    }

    public void restartGame()
    {
        points = 0;
        SceneManager.LoadScene(0);
        //resumePointsAccumulation();
        Debug.Log("restart game");
    }

}
