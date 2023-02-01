using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float timeRemaining = 60;
    [SerializeField]
    bool timerIsRunning = false;
    [SerializeField]
    TextMeshProUGUI timeText;
    [SerializeField]
    GameObject timeOver;
    [SerializeField]
    GameObject button;
    [SerializeField]
    GameObject button1;
    [SerializeField]
    GameObject button2;
    [SerializeField]
    GameObject startbutton;

    private void Start()
    {
        
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeOver.SetActive(true);
                timeRemaining = 0;
                timerIsRunning = false;
                button.SetActive(false);
                button1.SetActive(false);
                button2.SetActive(false);
                startbutton.SetActive(true);

                //GameOver();
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    //public void GameOver()
    //{
        //Application.Quit();
    //}
}


