using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSettings : MonoBehaviour
{
	public bool visable = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		this.gameObject.SetActive(visable);
    }
}
