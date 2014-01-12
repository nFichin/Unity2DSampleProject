using UnityEngine;
using System.Collections;

public class LayerChanger : MonoBehaviour {

	public GameObject[] layers;				//array with the level layers
	public int currentLayerIndex = 0;			//index of current layer
	public GameObject currentLayer;
	public GameObject mainCamera;
	public GameObject player;

	protected float layerDifferenceInXPosition;
	protected float layerDifferenceInYPosition;
	protected float layerDifferenceInZPosition;

	// Use this for initialization
	void Start () {
		layers = GameObject.FindGameObjectsWithTag("Layer");
		//Find the index in the layer's array of the player's starting layer
		for(int i = 0; i < layers.Length ; i++){
			if( layers[i].Equals(currentLayer) ){
				currentLayerIndex = i;
				break;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetButton("ChangeLayer") ){
			if(currentLayerIndex < (layers.Length-1) ){
				currentLayerIndex++;
			}else{
				currentLayerIndex = 0;
			}

			layerDifferenceInXPosition = currentLayer.transform.position.x - layers[currentLayerIndex].transform.position.x;
			layerDifferenceInYPosition = currentLayer.transform.position.y - layers[currentLayerIndex].transform.position.y;
			layerDifferenceInZPosition = currentLayer.transform.position.z - layers[currentLayerIndex].transform.position.z;

			player.transform.position = new Vector3(player.transform.position.x + layerDifferenceInXPosition,
			                                        player.transform.position.y - layerDifferenceInYPosition,
			                                        player.transform.position.z + layerDifferenceInZPosition);
		}
	}
}
