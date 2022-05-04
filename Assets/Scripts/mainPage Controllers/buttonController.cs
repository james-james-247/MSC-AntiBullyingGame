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
    public GameObject background;

    public Sprite g1One, g1Two, g1Three, g1Four, g1Five;
    public Sprite g2One, g2Two, g2Three, g2Four, g2Five;
    public Sprite g3One, g3Two, g3Three, g3Four, g3Five;

    Dictionary<string, Sprite> backgroundDict = new Dictionary<string, Sprite>();

    public GameObject bully, girlOne, girlTwo, teacher;

    public int changeLine = 0;
    public int bullyScore;
    public int popularity; 
    public string storyChosen;

    public string[][] storyoneArray = new string[][]
    {
        new string[]{"Charlie: Hey man, did you see Stacy's new post on buzznet? Doesn't she look so stupid!?", "Yeah Man How Ugly!", "Don't Really Care Man!", "Ehhhhh", "Nah She Looks Nice", "1"},
        new string[]{"Charlie: Doesn't matter what you think anyway, what should I comment on it with?", "Delete This, You're So Ugly!", "Don't Like!", "Cool", "You Look Nice", "1"},
        new string[]{"Charlie: Hey Stacy, I think you smell very bad! (At You) You agree don't you?", "Yeah So Stinky", "Smelt Worse", "Not Close Enough To Tell", "Nope Smells Like Roses", "12"},
        new string[]{"Jemma: Hey, I'm Stacy's friend Jemma, do you even like Charlie he's so mean!", "Yeah Hes The Best!", "Hes Alright", "Ehhhhh", "Nah I Hate Him", "3"},
        new string[]{"Charlie: You hear Stacy didn't come into school today!? God isn't she pathetic!?", "Yeah Man So Pathetic!", "What An Attention Seeker!", "I Don't Care", "Man Leave Her Alone", "1"},
        new string[]{"Charlie: But anyway! You think we should go round hers later and bully her some more?", "Yeah Man Of Course!", "If I'm Not Busy!", "Maybe", "That's Too Far", "1"},
        new string[]{"Teacher: Hey dude, it's Jack, Stacy's tutor, do you know who 'bully101' is on buzznet?", "Leave Me Alone", "Yeah But Not Telling You!", "Whats The 'Internet'?", "Yeah It's Charlie", "4"},
        new string[]{"Teacher: I understand, will YOU please be kind to Stacy?", "No!", "If Charlies Not Around!", "Maybe", "Of Course", "4"},
        new string[]{"Charlie: Hey, Stacy, I'm sorry, (At You) He kinda forced me to do it", "Sure Did, Deal With It!", "I Don't Care!", "No I Didn't", "Charlie Did It! Not Me!", "12"},
        new string[]{"Jemma: (At You) I don't care if this was you or not, I think you shouldn't freinds with him!", "Go Away! You Loser!", "I Disagree", "Maybe You're Right", "I Agree, Charlie Can Go Away!", "3"},
    };

    public string[][] storytwoArray = new string[][]
    {
        new string[]{"Jess: D'you hear Chris just called Katy an idiot!!", "I Did! He's right though!", "I did! Mad innit!", "Nah", "Nah, Thats Not Okay!", "2"},
        new string[]{"Jess: We Should Go Tell Her Right!", "Nah, But I'll Come With!", "Maybe!", "Fine!", "Of Course Lets Go", "2"},
        new string[]{"Katy: He Said WHAT!? Did You Hear It? (At You)", "Nope! She's Probably Lying", "Nope", "Nah, But It Does Sound Like Him", "(Lie) Yes", "23"},
        new string[]{"Chris: You Heard What I Said?", "Yeah Very Funny", "Yeah It Was Cool", "(Lie) Nah What?", "Yeah And It Was Bang Out Of Order", "1"},
        new string[]{"Jess: We're Looking For Chris, You Seen Him?", "(Lie) Nope", "(Lie) Not Sure", "Yeah But Can't Tell You", "Yeah He's Over There", "23"},
        new string[]{"Katy: You Dont Agree With What He Said Do You!", "Yep I Do", "HAHA Maybe", "Nope", "No Of Course Not", "23"},
        new string[]{"Teacher: People Have Told Me Chris Called Jess an Idiot! Is It True?", "(Lie) No", "(Lie) Dont Know", "Leave Me Out Of It", "Yeah He Did", "4"},
        new string[]{"Teacher: Either Way I Need You To Help Me Find Katy, Apperantly Shes Off Crying!", "Fine", "If I Have To", "Where Is She?", "Lets Go!", "4"},
        new string[]{"Katy: Leave Me ALONE!!!", "HAHA Cant Take A Joke!", "Shut Up", "We're Sorry", "Chris Is Horrible Ignore Him!", "34"},
        new string[]{"Katy: Thank God You're Here Jess, I'm So Sad!", "Haha Two Losers Togehter", "Can We Go Now?", "Must Be Happier Now?", "See All You Need To Care About Is Your Friends!", "234"},
    };

    public string[][] storythreeArray = new string[][]
    {
        new string[]{"Jeffery: ", "Yeah Man How Ugly!", "Don't Really Care Man!", "Ehhhhh", "Nah She Looks Nice", "1"},
        new string[]{"Jeffery: ", "Delete This, You're So Ugly!", "Don't Like!", "Cool", "You Look Nice", "1"},
        new string[]{"Sarah: ", "Yeah So Stinky", "Smelt Worse", "Not Close Enough To Tell", "Nope Smells Like Roses", "12"},
        new string[]{"Sarah: ", "Yeah Hes The Best!", "Hes Alright", "Ehhhhh", "Nah I Hate Him", "3"},
        new string[]{"Sarah: ", "Yeah Man So Pathetic!", "What An Attention Seeker!", "I Don't Care", "Man Leave Her Alone", "1"},
        new string[]{"Zach: ", "Yeah Man Of Course!", "If I'm Not Busy!", "Maybe", "That's Too Far", "1"},
        new string[]{"Zach: ", "Leave Me Alone", "Yeah But Not Telling You!", "Whats The 'Internet'?", "Yeah It's Charlie", "4"},
        new string[]{"Teacher: ", "No!", "If Charlies Not Around!", "Maybe", "Of Course", "4"},
        new string[]{"Teacher: ", "Sure Did, Deal With It!", "I Don't Care!", "No I Didn't", "Charlie Did It! Not Me!", "12"},
        new string[]{"Jeffery: ", "Go Away! You Loser!", "I Disagree", "Maybe You're Right", "I Agree, Charlie Can Go Away!", "3"},
    };

    // Start is called before the first frame update
    void Start()
    {
        backgroundDict.Add("1One", g1One);
        backgroundDict.Add("1Two", g1Two);
        backgroundDict.Add("1Three", g1Three);
        backgroundDict.Add("1Four", g1Four);
        backgroundDict.Add("1Five", g1Five);
        backgroundDict.Add("2One", g2One);
        backgroundDict.Add("2Two", g2Two);
        backgroundDict.Add("2Three", g2Three);
        backgroundDict.Add("2Four", g2Four);
        backgroundDict.Add("2Five", g2Five);
        backgroundDict.Add("3One", g3One);
        backgroundDict.Add("3Two", g3Two);
        backgroundDict.Add("3Three", g3Three);
        backgroundDict.Add("3Four", g3Four);
        backgroundDict.Add("3Five", g3Five);

        buttonText();
    }

    public void buttonText()
    {
        StreamReader reader = new StreamReader("Assets/lineCounter.txt"); 
        changeLine = int.Parse(reader.ReadToEnd());
        reader.Close();

        StreamReader readerTwo = new StreamReader("Assets/story.txt"); 
        storyChosen = readerTwo.ReadToEnd().Trim();
        readerTwo.Close();

        string[] values = multiStory();

        storyBox.text = values[0];
        but.GetComponentInChildren<Text>().text = values[1];
        but2.GetComponentInChildren<Text>().text = values[2];
        but3.GetComponentInChildren<Text>().text = values[3];
        but4.GetComponentInChildren<Text>().text = values[4];

        char[] storyPeople = values[5].ToCharArray();

        foreach(char i in storyPeople){
            if(i.ToString() == "1"){
                bully.SetActive(true);
            }
            else if(i.ToString() == "2"){
                girlOne.SetActive(true);
            }
            else if(i.ToString() == "3"){
                girlTwo.SetActive(true);
            }
            else if(i.ToString() == "4"){
                teacher.SetActive(true);
            }
        }

        string retVal = backgroundClass(storyChosen);

        if(changeLine == 0 || changeLine == 1){
            background.GetComponent<Image>().sprite = backgroundDict[retVal + "One"];
        }
        else if(changeLine == 2 || changeLine == 3){
            background.GetComponent<Image>().sprite = backgroundDict[retVal + "Two"];;
        }
        else if(changeLine == 4 || changeLine == 5){
            background.GetComponent<Image>().sprite = backgroundDict[retVal + "Three"];;
        }
        else if(changeLine == 6 || changeLine == 7){
            background.GetComponent<Image>().sprite = backgroundDict[retVal + "Four"];;
        }
        else if(changeLine == 8 || changeLine == 9){
            background.GetComponent<Image>().sprite = backgroundDict[retVal + "Five"];;
        }
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

        if(num == 0){
            bullyScore = bullyScore + 100;
            popularity = popularity + 10;
        }
        else if(num == 1){
            bullyScore = bullyScore + 50;
            popularity = popularity + 1;
        }
        else if(num == 2){
            bullyScore = bullyScore + 10;
        }
        else if(num == 3){
            bullyScore = bullyScore - 25;
            popularity = popularity - 50;
        }

        StreamWriter writerTwo = new StreamWriter("Assets/bullyScore.txt", false);
        writerTwo.WriteLine(bullyScore.ToString());
        writerTwo.Close();
        
        StreamWriter writerThree = new StreamWriter("Assets/popularity.txt", false);
        writerThree.WriteLine(popularity.ToString());
        writerThree.Close();

        if(changeLine == 2 || changeLine == 4 || changeLine == 6 || changeLine == 8){
            SceneManager.LoadScene("LoadingPage");
        }
        else if(changeLine == 10){
            SceneManager.LoadScene("Results");
        }
        else{
            SceneManager.LoadScene("Mainpage");
        }
    }

    public string[] multiStory()
    {
        if(storyChosen == "storyoneArray"){
            return storyoneArray[changeLine];
        }
        else if(storyChosen == "storytwoArray"){
            return storytwoArray[changeLine];
        }
        else{
            return storythreeArray[changeLine];
        }
    }

    public string backgroundClass(string story)
    {
        if(story == "storyoneArray"){
            return "1";
        }   
        else if(story == "storytwoArray"){
            return "2";
        }
        else{
            return "3";
        }
    }
}