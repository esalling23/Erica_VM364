#pragma strict

function OnGUI() {

	if (GUI.Button(Rect(10,70,50,30),"Start")){
	    BeginGame();
	}
}
// the function OnGUI is now depreciated
// we will use it only for the lessons today
// when we go over Unity's new GUI 
// please stop using it

function Start () {

}

function Update () {

}

function BeginGame(){
   Application.LoadLevel("Level1");
   // You can change "Level 1" to 1
}