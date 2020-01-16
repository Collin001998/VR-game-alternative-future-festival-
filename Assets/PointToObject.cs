using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToObject : MonoBehaviour
{
	public Transform transformObject;
	public string Tag = "selectable";
	public Material HighLightMaterial;
	public Shader highlightShader;
	public LineRenderer LineRenderer;
	public Transform handAnchor;

	private Shader defaultShader;
	private GameObject selectedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		UpdateLine();
		RaycastHit hit = CreateHit();
		if (hit.collider.gameObject.tag == Tag)
		{
			SetDefaultShader(hit.collider.gameObject);
			selectedObject = hit.collider.gameObject;
			ChangeShader(hit.collider.gameObject, highlightShader);
		} else if (selectedObject != null)
		{
			ChangeShader(selectedObject, defaultShader);
			selectedObject = null;
		}
	}
	private void UpdateLine()
	{
		RaycastHit hit = CreateHit();
		Vector3 endPosition = transformObject.position + (handAnchor.forward * 5.0f);

		if (hit.collider != null)
		{
			endPosition = hit.point;
		}

		LineRenderer.SetPosition(0, transformObject.position);
		LineRenderer.SetPosition(1, endPosition);
	}
	private RaycastHit CreateHit()
	{
		RaycastHit hit;
		Ray ray = new Ray(transformObject.position, handAnchor.forward);
		Physics.Raycast(ray, out hit);

		return hit;
	}
	private void SetDefaultShader(GameObject target)
	{
		if (target.GetComponent<Renderer>().material.shader != highlightShader)
		{
			defaultShader = target.GetComponent<Renderer>().material.shader;
			Debug.Log("changed default" + defaultShader.name);
		}
	}
	private void ChangeShader(GameObject target, Shader shader)
	{
		target.GetComponent<Renderer>().material.shader = shader;
	}
}
