using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class jsonReader : MonoBehaviour
{
    //Getting all of the gameobjects
    public Text speechBox;
    public Button optionOne;
    public Button optionTwo;
    public Button optionThree;
    public Button optionFour;

    //The selected story and the changer thats a counter
    //public int selectedGame = variables.selectedGame;
    public int changer = 0;

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

    void start()
    {
        textFiller();
    }

    public void textFiller()
    {
        if(Controller.currentDay < 5){

            string speech, one, two, three, four;
            speech = storyoneArray[changer][0];
            one = storyoneArray[changer][1];
            two = storyoneArray[changer][2];
            three = storyoneArray[changer][3];
            four = storyoneArray[changer][4];

            speechBox.text = speech;
            optionOne.GetComponentInChildren<Text>().text = one;
            optionTwo.GetComponentInChildren<Text>().text = two;
            optionThree.GetComponentInChildren<Text>().text = three;
            optionFour.GetComponentInChildren<Text>().text = four;

            changer = changer + 1;
        }
        else
        {
            //Send to results page

        }
    }
}