using UnityEngine;
using System.Collections;

public class LayerChanger : MonoBehaviour {

	public GameObject[] layers;				//array with the level layers
	public int currentLayer = 0;			//index of current layer
	public GameObject mainCamera;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButton("ChangeLayer") ){
			if(currentLayer == 0){
				player.transform.position = new Vector3(player.transform.position.x,
				                                 layers[1].transform.position.y,
				                                 layers[1].transform.position.z);
				currentLayer = 1;
			}else{
				player.transform.position = new Vector3(player.transform.position.x,
				                                 layers[0].transform.position.y,
				                                 layers[0].transform.position.z);
				currentLayer = 0;
			}

			/*mainCamera.transform.position = new Vector3(player.transform.position.x,
			                                   layers[1].transform.position.y,
			                                            mainCamera.transform.position.z);
 */
		}
	}
}
