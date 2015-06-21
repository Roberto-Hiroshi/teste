using UnityEngine;
using System.Collections;

public class rot : MonoBehaviour {
	private Vector3 direcao = Vector3.zero;
	private Vector3 mousePos; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		direcao=new Vector3(Mathf.Abs(mousePos.x), mousePos.y, 0);
		print (direcao);
		Quaternion lookDir = Quaternion.LookRotation (direcao-new Vector3(transform.position.x,transform.position.y,0f).normalized, transform.up);
		lookDir.x =0f;
		lookDir.y = 0f;
		if(transform.rotation.eulerAngles.z>=270f||transform.rotation.eulerAngles.z<90f)
		{
			transform.rotation = lookDir;
			//right
		}
		else
		{
			transform.rotation = Quaternion.Euler(0f,0f,0f);
			Debug.LogError("erro");
			//Left
		}
	}
}
