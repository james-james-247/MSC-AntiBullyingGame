using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
    public Text storyBox;
    public Button but;
    public Button but2;
    public Button but3;
    public Button but4;

    public int changeLine = 0;
    public int bullyScore;
    public int popularity; 

    public string[][] storyoneArray = new string[][]
    {
        new string[]{"Charlie: Hey man, did you see Stacy's new post on buzznet? Doesn't she look so stupid!?", "Yeah Man How Ugly!", "Don't Really Care Man!", "Ehhhhh", "Nah She Looks Nice"},
        new string[]{"Charlie: Doesn't matter what you think anyway, what should I comment on it with?", "Delete This, You're So Ugly!", "Don't Like!", "Cool", "You Look Nice"},
        new string[]{"Charlie: Hey Stacy, I think you smell very bad! (At You) You agree don't you?", "Yeah So Stinky", "Smelt Worse", "Not Close Enough To Tell", "Nope Smells Like Roses"},
        new string[]{"Jemma: Hey, I'm Stacy's friend Jemma, do you even like Charlie he's so mean!", "Yeah Hes The Best!", "Hes Alright", "Ehhhhh", "Nah I Hate Him"},
        new string[]{"Charlie: You hear Stacy didn't come into school today!? God isn't she pathetic!?", "Yeah Man So Pathetic!", "What An Attention Seeker!", "I Don't Care", "Man Leave Her Alone"},
        new string[]{"Charlie: But anyway! You think we should go round hers later and bully her some more?", "Yeah Man Of Course!", "If I'm Not Busy!", "Maybe", "That's Too Far"},
        new string[]{"Teacher: Hey dude, it's Jack, Stacy's tutor, do you know who 'bully101' is on buzznet?", "Leave Me Alone", "Yeah But Not Telling You!", "Whats The 'Internet'?", "Yeah It's Charlie"},
        new string[]{"Teacher: I understand, will YOU please be kind to Stacy?", "No!", "If Charlies Not Around!", "Maybe", "Of Course"},
        new string[]{"Charlie: Hey, Stacy, I'm sorry, (At You) He kinda forced me to do it", "Sure Did, Deal With It!", "I Don't Care!", "No I Didn't", "Charlie Did It! Not Me!"},
        new string[]{"Jemma: (At You) I don't care if this was you or not, I think you shouldn't freinds with him!", "Go Away! You Loser!", "I Disagree", "Maybe You're Right", "I Agree, Charlie Can Go Away!"},
    };

    // Start is called before the first frame update
    void Start()
    {
        buttonText();
    }

    public void buttonText()
    {
        StreamReader reader = new StreamReader("Assets/lineCounter.txt"); 
        changeLine = int.Parse(reader.ReadToEnd());
        reader.Close();

        storyBox.text = storyoneArray[changeLine][0];
        but.GetComponentInChildren<Text>().text = storyoneArray[changeLine][1];
        but2.GetComponentInChildren<Text>().text = storyoneArray[changeLine][2];
        but3.GetComponentInChildren<Text>().text = storyoneArray[changeLine][3];
        but4.GetComponentInChildren<Text>().text = storyoneArray[changeLine][4];
    }  

    public void clicked(int num)
    {
        changeLine++;
        //Add changeline to file
        StreamWriter writer = new StreamWriter("Assets/lineCounter.txt", false);
        writer.WriteLine(changeLine.ToString());
        writer.Close();

        StreamReader readerTwo = new StreamReader("Assets/bullyScore.txt"); 
        bullyScore = int.Parse(readerTwo.ReadToEnd());
        readerTwo.Close();

        StreamReader readerThree = new StreamReader("Assets/popularity.txt"); 
        popularity = int.Parse(readerThree.ReadToEnd());
        readerThree.Close();

        if(num == 0)
        {
            bullyScore = bullyScore + 100;
            popularity = popularity + 10;
        }
        else if(num == 1)
        {
            bullyScore = bullyScore + 50;
            popularity = popularity + 1;
        }
        else if(num == 2)
        {
            bullyScore = bullyScore + 10;
        }
        else if(num == 3)
        {
            bullyScore = bullyScore - 25;
            popularity = popularity - 50;
        }

        StreamWriter writerTwo = new StreamWriter("Assets/bullyScore.txt", false);
        writerTwo.WriteLine(bullyScore.ToString());
        writerTwo.Close();
        
        StreamWriter writerThree = new StreamWriter("Assets/popularity.txt", false);
        writerThree.WriteLine(popularity.ToString());
        writerThree.Close();

        if(changeLine == 2 || changeLine == 4 || changeLine == 6 || changeLine == 8 || changeLine == 10)
        {
            SceneManager.LoadScene("LoadingPage");
        }
        else
        {
            SceneManager.LoadScene("Mainpage");
        }
    }
}