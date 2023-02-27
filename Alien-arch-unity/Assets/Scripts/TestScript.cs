using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{



    public string[] messages;

    public string startMessage;

    public string updateMessage;

    public string message1, message2, message3;

    public int messageChoice;

    // Start is called before the first frame update
    void Start()
    {


        

        if (messageChoice < messages.Length && messageChoice >=0)
        {
            Debug.Log(messages[messageChoice]);

        }

        else
        {
            Debug.Log("invalid choice");
        }
        
        
        
        //Debug.Log(startMessage);

        //MessageChoice = Random.Range(1, 4);

        /*
        if (MessageChoice == 1)
        {

            Debug.Log(messages[0]);

        }
        else if (MessageChoice == 2)
        {
            Debug.Log(messages[1]);
        }
        else if (MessageChoice == 3)
        {
            Debug.Log(messages[2]);
        }
        else
        {
            Debug.Log("invalid number");
        }

        */
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateMessage);
    }
}
