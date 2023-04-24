using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


 [RequireComponent(typeof(Text))]
public class HealthDisplay : MonoBehaviour
{

    Text HealthValueDisplay;

    PlayerHealth player;



    // Start is called before the first frame update
    void Start()
    {
        HealthValueDisplay = GetComponent<Text>();


        player = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {

        //get current health of player from getHealth function
        //convert number to text using ToString()
        //on health value text component, set text to number we got

        HealthValueDisplay.text = player.getHealth().ToString();
    }
}
