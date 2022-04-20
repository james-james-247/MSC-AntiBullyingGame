using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
        public Text speechBox;

    public static int selectedGame;

    public static int currentDay;

    //Score counter
    public int bullyScore;
    public int popularity;

    //Which section to get from
    public int changer;

    void start()
    {
        speechBox.text = "hi";
        loadingDetails();
    }

    public void loadingDetails()
    {
        StreamReader reader = new StreamReader("data.txt");
        string lines = reader.ReadLine();
        string[] split = lines.Split(',');
        selectedGame = int.Parse(split[0]);
        currentDay = int.Parse(split[1]);
        bullyScore = int.Parse(split[2]);
        popularity = int.Parse(split[3]);
        changer = int.Parse(split[4]);
        reader.Close();
    }

    public void awfulButton()
    {
        changer = changer + 1;
        bullyScore = bullyScore + 70;
        popularity = popularity + 10;

        savingData();
        changerFunc();
    }

    public void badButton()
    {
        changer = changer + 1;
        bullyScore = bullyScore + 35;

        savingData();
        changerFunc();
     }

    public void okayButton()
    {
        changer = changer + 1;
        bullyScore = bullyScore + 10;
        popularity = popularity - 10;

        savingData();
        changerFunc();
    }

    public void goodButton()
    {
        changer = changer + 1;
        bullyScore = bullyScore - 55;
        popularity = popularity - 60;

        savingData();
        changerFunc();
    }

    public void savingData()
    {
        string data = selectedGame.ToString() + "," + currentDay.ToString() + "," + bullyScore.ToString() + "," +popularity.ToString() + "," + changer.ToString();    
        StreamWriter writer = new StreamWriter("data.txt", false);
        writer.Write(data);
        writer.Close();
        loadingDetails();
    }

    public void changerFunc()
    {
        if(changer == 2 || changer == 4 || changer == 6 || changer == 8){
            toLoad();
        }
        else if(changer == 10){
            toResults();
        }
    }


    //
    //Chosing game to play
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

    public void toLoad()
    {
        SceneManager.LoadScene("LoadingPage");
    }
    public void toResults(){
        SceneManager.LoadScene("Results");
    }
}
