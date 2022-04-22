using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class results : MonoBehaviour
{

    public Text bullyScore;
    public Text popScore;
    // Start is called before the first frame update
    void Start()
    {
        StreamReader reader = new StreamReader("Assets/bullyScore.txt"); 
        string bully = reader.ReadToEnd();
        reader.Close();

        StreamReader readerTwo = new StreamReader("Assets/popularity.txt"); 
        string pop = readerTwo.ReadToEnd();
        readerTwo.Close();

        bullyScore.text = "Your Bully Score: " + bully;
        popScore.text = "Your Popularity Score: " + pop;
    }

    public void clicked()
    {
        SceneManager.LoadScene("Homepage");
    }
}
