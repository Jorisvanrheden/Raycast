using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pathfinder : MonoBehaviour {

	private Vector3 start = new Vector3(0,0,0);
	private Vector3 end = new Vector3 (0, 0, 100);

	public GameObject light;
	private List<float> times = new List<float>();

	//every waypoint will have a list of hits to look from
	private List<Node> waypoints = new List<Node>();

	public int rayCount = 45;
	public bool techniqueEnabled = true;



	void Start(){

		//set the first waypoint
		waypoints.Add (new Node (start, end, rayCount, techniqueEnabled));

	}

	void Update(){


		waypoints [0] = new Node (light.transform.position, end, rayCount, techniqueEnabled);

		light.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));

		/* calculating average FPS
		times.Add (1 / Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.Space)) {
			float t = 0;
			foreach(float time in times){
				t+=time;
			}
			Debug.Log("Average FPS: " + t/times.Count);
		}
		*/
	
	}
}