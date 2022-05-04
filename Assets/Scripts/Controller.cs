using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Text speechBox;

    string selectedGame;

    //
    //Travelling
    public void toSettings()
    {
        SceneManager.LoadScene("Settings");    
    }

    public void toHome()
    {
        SceneManager.LoadScene("Homepage");
    }

    public void toLoad(int value)
    {
        if(value == 0){
            selectedGame = "storyoneArray";
        }
        else if(value == 1){
            selectedGame = "storytwoArray";
        }
        else if(value == 2){
            selectedGame = "storythreeArray";
        }

        StreamWriter writer = new StreamWriter("Assets/story.txt", false);
        writer.WriteLine(selectedGame);
        writer.Close();
        
        SceneManager.LoadScene("LoadingPage");
    }

    public void toResults()
    {
        SceneManager.LoadScene("Results");
    }

    public void close()
    {
        Application.Quit();
    }
}
