using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadPageTimer : MonoBehaviour
{
    public Text text;
    public string[][] hintArray = new string[][]
    {
        new string[]{"Player Hint: Try Fogetting About The Popularity Score On Some Of The Questions!"},
        new string[]{"Player Hint: Sometimes Being Neutral Is Just As Bad As Bullying!"},
        new string[]{"Player Hint: Remember To Consider Other Peoples Opinions!"},
        new string[]{"Player Hint: New Ideas Arent Always The Best Ideas!"},
        new string[]{"Player Hint: Think Before You Act!"},
        new string[]{"Player Hint: Think Before You Speak!"},
        new string[]{"Player Hint: Think More Of Others And Less Of Yourself!"},
        new string[]{"Player Hint: Remember Everyone Is Going Through Things In Their Lives!"},
    };

    public float targetTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0,8);
        string[] chosen = hintArray[rand];
        string stringChosen = chosen[0].ToString();
        text.text = stringChosen;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
 
        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    public void timerEnded()
    {
        SceneManager.LoadScene("Mainpage");

    }
}
