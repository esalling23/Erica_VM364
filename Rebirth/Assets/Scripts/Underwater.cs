﻿using UnityEngine;
using System.Collections;

public class Underwater : MonoBehaviour {

	//This script enables underwater effects. Attach to main camera.

	//Define variable
	public int underwaterLevel = 0;
	public Color color;

	//The scene's default fog settings
	private bool defaultFog;
	private Color defaultFogColor;
	private float defaultFogDensity;
	private Material defaultSkybox;
	private Material noSkybox;

	void Start () {
		//Set the background color
		//Camera.main.backgroundColor = new Color(0, 0.4f, 0.7f, 1);
		defaultFog = RenderSettings.fog;
		defaultFogColor = RenderSettings.fogColor;
		defaultFogDensity = RenderSettings.fogDensity;
		defaultSkybox = RenderSettings.skybox;
	}

	void Update () {
		if (transform.position.y < underwaterLevel)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = color;
			RenderSettings.fogDensity = 0.3f;
			RenderSettings.skybox = noSkybox;
		}
		else
		{
			RenderSettings.fog = defaultFog;
			RenderSettings.fogColor = defaultFogColor;
			RenderSettings.fogDensity = defaultFogDensity;
			RenderSettings.skybox = defaultSkybox;
		}
	}
}