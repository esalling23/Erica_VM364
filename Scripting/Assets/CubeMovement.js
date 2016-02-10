#pragma strict

var cubeUp = false;

function Start () {

}

function Update () {
		//transform.Translate(Vector3.up * Time.deltaTime, Space.World);

		if (gameObject.transform.position.y >5) {
		cubeUp = false;
		}

		if (gameObject.transform.position.y <-5) {
		cubeUp = true;
		}



		if (cubeUp == false) {
		transform.Translate(Vector3.down * Time.deltaTime, Space.World);
		}

		if (cubeUp == true) {
		transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		}

}