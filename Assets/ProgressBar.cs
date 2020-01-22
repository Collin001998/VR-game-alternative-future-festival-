using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "0/5";
        this.gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Player_Stats player_Stats = GameObject.Find("Player_Stats").GetComponent<Player_Stats>();
        this.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = player_Stats.collectedArtifacts + "/5";
        if(player_Stats.collectedArtifacts == 1)
        {
            this.gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = 0.2f;
        } else if (player_Stats.collectedArtifacts == 2)
        {
            this.gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = 0.4f;
        }
        else if (player_Stats.collectedArtifacts == 3)
        {
            this.gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = 0.6f;
        }
        else if (player_Stats.collectedArtifacts == 4)
        {
            this.gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = 0.8f;
        }
        else if (player_Stats.collectedArtifacts == 5)
        {
            this.gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = 1;
        }
        else
        {
            this.gameObject.transform.GetChild(1).gameObject.GetComponent<Slider>().value = 0;
        }
        
    }
}
