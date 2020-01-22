using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Stats : MonoBehaviour
{
    public int collectedArtifacts = 0;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text notificationText = GameObject.Find("Notification_Text").GetComponent<Text>();
        if (OVRInput.GetDown(OVRInput.Button.Any) && notificationText.text != "")
        {
            notificationText.text = "";
        }
    }

    public void CollectArtifact(GameObject artifact)
    {
        collectedArtifacts++;
        Debug.LogWarning("collected artifacts: " + collectedArtifacts);
        Artifact artifactScript = artifact.GetComponent<Artifact>();
        //TODO: show message to player!
        Text notificationText = GameObject.Find("Notification_Text").GetComponent<Text>();
        notificationText.text = "Artifact send to Mothership (press any button)";
        //show player thought process!
        artifactScript.ShowData();
        //destory artifact
        artifactScript.Destory();
    }
}
