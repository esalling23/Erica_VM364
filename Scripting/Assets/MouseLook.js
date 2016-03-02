#pragma strict

  
 function Update () {
     if (Input.GetKey("right")) {
     	if (Camera.main.transform.position.x < 20) {
         Camera.main.transform.position.x += .2;
         }
     }
     if (Input.GetKey("left")) {
     	if (Camera.main.transform.position.x > -20) {
         Camera.main.transform.position.x -= .2;
         }
     }
     if (Input.GetKey("up")) {
     	if (Camera.main.transform.position.y < 10) {
         Camera.main.transform.position.y += .2;
         }
     }
     if (Input.GetKey("down")) {
     	if (Camera.main.transform.position.y > -10) {
         Camera.main.transform.position.y -= .2;
         }
     }
 }