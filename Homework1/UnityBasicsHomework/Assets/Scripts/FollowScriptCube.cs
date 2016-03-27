using UnityEngine;
using System.Collections;

public class FollowScriptCube : MonoBehaviour 
{ 
	public Transform cylinder;
	public float followSpeed;
	public float minDistance;

	// Update is called once per frame
	void LateUpdate () 
	{
		if (cylinder != null) 
		{
			this.transform.LookAt (cylinder);

			if (Vector3.Distance (this.transform.position, cylinder.position) > minDistance)
			{
				this.transform.Translate (0f, 0f, followSpeed * Time.deltaTime);
			}
		}	
	}
}
