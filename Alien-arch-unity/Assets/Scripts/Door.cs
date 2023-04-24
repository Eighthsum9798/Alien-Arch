using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public string targetScene = "";


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag("Player"))
        {
            ChangeScene();

        }

        
    }

     void ChangeScene()
    {

        SceneManager.LoadScene(targetScene);


    }

}
