using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public static int selectedGame;

    public static int currentDay = 0;

    //Score counter
    public int bullyScore = 0;
    public int popularity = 500;

    void start(){
        print("here");
    }
    public void awfulButton()
    {
        print("here");
        bullyScore = bullyScore + 70;
        popularity = popularity + 10;
    }

    public void badButton()
    {
        bullyScore = bullyScore + 35;
 
     }

    public void okayButton()
    {
        bullyScore = bullyScore + 10;
        popularity = popularity - 10;
    }

    public void goodButton()
    {
        bullyScore = bullyScore - 55;
        popularity = popularity - 60;
    }

    public void chosenGame(int value)
    {
        if(value == 0){
            selectedGame = value;
        }
        else if(value == 1){
            print("mmhmm");
        }
        else if(value == 2){
            print("okay");
        }
        print(selectedGame);
    }

    //Travelling
    public void toSettings()
    {
        SceneManager.LoadScene("Settings");    
    }

    public void toHome()
    {
        SceneManager.LoadScene("Homepage");
    }

    public void toLoad()
    {
        SceneManager.LoadScene("LoadingPage");
    }
}
