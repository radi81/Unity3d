using UnityEngine;
using System.Collections;

public class FollowScriptSphere : MonoBehaviour 
{
	public Transform cube;
	public float followSpeed;
	public float minDistance;

	// Update is called once per frame
	void LateUpdate () 
	{
		if (cube != null) 
		{
			this.transform.LookAt (cube);

			if (Vector3.Distance (this.transform.position, cube.position) > minDistance)
			{
				this.transform.Translate (0f, 0f, followSpeed * Time.deltaTime);
			}
		}	
	}
}
