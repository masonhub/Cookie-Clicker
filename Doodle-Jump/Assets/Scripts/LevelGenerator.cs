using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject platformPrefab;
    public GameObject springPlatform;

	public int numberOfPlatforms = 200;
	public float levelWidth = 3f;
	public float minY = 7.2f;
	public float maxY = 15.5f;

	// Use this for initialization
	void Start () {

		Vector3 spawnPosition = new Vector3();
        Vector3 springPostion = new Vector3();

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            springPostion.y += Random.Range(1, 30);
            springPostion.x = Random.Range(-1, 5);
			Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            Instantiate(springPlatform, springPostion, Quaternion.identity);
		}
	}
}
