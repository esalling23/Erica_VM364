#pragma strict

var cubeCreate = true;
var cube : GameObject;

var projectile : Rigidbody;

var cubes : GameObject[];

function Start () {
	if (cubeCreate == true){
		for (var i : int = -5;i < 5; i++) {
	    	    Instantiate (cube, Vector3(i * 4.0, 0, 0), Quaternion.identity);
	    	    cube.tag = "Box";
		}
	   cubeCreate = false;
	}
	cubes = GameObject.FindGameObjectsWithTag("Box");
	Debug.Log (cubes.Length);

}


function Update () {
    // Ctrl was pressed, launch a projectile
    cubes = GameObject.FindGameObjectsWithTag("Box");

    if (Input.GetButtonDown("Fire1")) {

         var mousePos = Input.mousePosition;
         mousePos.z = 1.0;       
         var objectPos = Camera.main.ScreenToWorldPoint(mousePos);

        // Instantiate the projectile at the position and rotation of this transform
        var clone : Rigidbody;

        clone = Instantiate(projectile, objectPos, transform.rotation);
        
        // Give the cloned object an initial velocity along the current 
        // object's Z axis
        clone.velocity = transform.TransformDirection (Vector3.forward * 10);

        Debug.Log(cubes.Length);
    }

    if (cubes.Length == 0) {
    	Debug.Log ("level complete");
    }


}

