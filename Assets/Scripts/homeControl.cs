using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class homeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StreamWriter writer = new StreamWriter("Assets/lineCounter.txt", false);
        writer.WriteLine("0");
        writer.Close();

        StreamWriter writerTwo = new StreamWriter("Assets/bullyScore.txt", false);
        writerTwo.WriteLine("0");
        writerTwo.Close();
        
        StreamWriter writerThree = new StreamWriter("Assets/popularity.txt", false);
        writerThree.WriteLine("500");
        writerThree.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
