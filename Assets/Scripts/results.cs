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
    public Text bestScore;
    // Start is called before the first frame update
    void Start()
    {
        StreamReader reader = new StreamReader("Assets/bullyScore.txt"); 
        string bully = reader.ReadToEnd();
        reader.Close();

        StreamReader readerTwo = new StreamReader("Assets/popularity.txt"); 
        string pop = readerTwo.ReadToEnd();
        readerTwo.Close();

        StreamReader readerThree = new StreamReader("Assets/bestResult.txt"); 
        string best = readerThree.ReadToEnd();
        readerThree.Close();

        bullyScore.text = "Your Bully Score: " + bully;
        popScore.text = "Your Popularity Score: " + pop;
        bestScore.text = "Your Previous Best Score: " + best;

        if(int.Parse(best) > int.Parse(bully)){
            StreamWriter writer = new StreamWriter("Assets/bestResult.txt", false);
            writer.WriteLine(bully.ToString());
            writer.Close();
        }
    }

    public void clicked()
    {
        SceneManager.LoadScene("Homepage");
    }
}
