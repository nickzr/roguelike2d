using UnityEngine;
using System.Collections;

public class GameBoard : MonoBehaviour {
	public int rows;
	public int columns;

	public GameObject[] groundTiles;
	public GameObject[] wallTiles;

	private Transform boardHolder;

	// Use this for initialization
	void Awake () {
		boardSetup ();
	}

	void boardSetup(){
		boardHolder = new GameObject ("Board").transform;

		for (int i = -1; i <= rows; i++) {
			for (int j = -1; j <= columns; j++) {
				GameObject toInstantiate;
			}
		}
	}
}
