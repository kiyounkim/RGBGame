using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 60f;
    public float timeLeft;
    public bool startTime=false;
    // Start is called before the first frame update
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        Time.timeScale=1;
    }

    // Update is called once per frame
    void Update()
    {
        if(startTime){
            if(timeLeft>0){
                timeLeft-=Time.deltaTime;
                timerBar.fillAmount=timeLeft/maxTime;
            }
            else{
                Time.timeScale=0;
                GameObject.Find("Circle").GetComponent<Movement>().canMove=false;
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
            }
        }
    }
}
