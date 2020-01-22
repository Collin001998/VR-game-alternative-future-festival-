using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowData()
    {
        this.gameObject.transform.parent.gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }
    public void Destory()
    {
        this.gameObject.SetActive(false);
    }
}
