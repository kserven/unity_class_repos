using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, bed_0, lock_0, bed_1, cell_mirror,
						lock_1, corridor_0, stairs_0, floor, closet_door, stairs_1,
						corridor_1, in_closet, stairs_2, corridor_2, corridor_3,
						courtyard}
	private States myState;
						
	// Use this for initialization
	void Start () {
		myState = States.cell;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		print (myState);
		
		if 		(myState == States.cell) 			{ cell(); }
		else if (myState == States.bed_0) 			{ bed_0(); }
		else if (myState == States.mirror) 			{ mirror(); }
		else if (myState == States.lock_0) 			{ lock_0(); }
		else if (myState == States.bed_1) 			{ bed_1(); }
		else if (myState == States.cell_mirror)		{ cell_mirror(); }
		else if (myState == States.lock_1) 			{ lock_1(); }
		else if (myState == States.corridor_0) 		{ corridor_0(); }
		else if (myState == States.stairs_0) 		{ stairs_0(); }
		else if (myState == States.floor) 			{ floor(); }
		else if (myState == States.closet_door)		{ closet_door(); }
		else if (myState == States.stairs_1) 		{ stairs_1(); }
		else if (myState == States.corridor_1) 		{ corridor_1(); }
		else if (myState == States.in_closet) 		{ in_closet(); }
		else if (myState == States.stairs_2) 		{ stairs_2(); }
		else if (myState == States.corridor_2) 		{ corridor_2(); }
		else if (myState == States.corridor_3) 		{ corridor_3(); }
		else if (myState == States.courtyard) 		{ courtyard(); }
	}
		
	#region State handler methods
	
	void cell () {
		
		text.text = "You were accused of espionage and placed in a Gulag cell.  " + 
					"You find yourself in a dank cell that has a bed and a mirror.  " + 
					"There are some very solid looking steel bars with a door that " + 
					"has a keyhole on the outside." +
					"\n\n" +
					"Press (B) view the bed, (M) view Mirror, (L) view Lock";
		
		if 		(Input.GetKeyDown (KeyCode.B))  	{ myState = States.bed_0; }
		else if (Input.GetKeyDown (KeyCode.M))  	{ myState = States.mirror; }
		else if (Input.GetKeyDown (KeyCode.L))  	{ myState = States.lock_0; }
	}
	void bed_0 () {
		
		text.text = "You see a slab that has very filthy sheets and a stained flat pillow.  " + 
					"Do they call this 'bed'?" + 
					"\n\n" +
					"Press (R) to Return";
					
		if 		(Input.GetKeyDown (KeyCode.R))  	{ myState = States.cell; }
	}
	void mirror () {
		
		text.text = "You take a small oval mirror with a poorly made wooden frame.  " + 
					"You can barely see yourself through the dust and grim on the glass.  " + 
					"When you remove the mirror, a small nail falls out of the wooden frame." +
					"\n\n" +
					"Press (R) to Return";
		
		if 		(Input.GetKeyDown (KeyCode.R))  	{ myState = States.cell_mirror; }
	}
	void lock_0 () {
		
		text.text = "You see a door with a very stout lock that has a keyhole on the outside." + 
					"\n\n" +
					"Press (R) to Return";
		
		if 		(Input.GetKeyDown (KeyCode.R))  	{ myState = States.cell; }
	}
	void bed_1 () {
		
		text.text = "The makeshift bed does not look any better in the mirror." + 
					"\n\n" +
					"Press (R) to Return";
		
		if 		(Input.GetKeyDown (KeyCode.R))  	{ myState = States.cell_mirror; }
	}
	void cell_mirror () {
		
		text.text = "You are still in a dank cell; Other than the mirror being in " + 
					"your hand instead of on the wall, the cell is the same as it was.  " + 
					"You have a small nail in your other hand." + 
					"\n\n" +
					"Press (B) view the bed, (L) view lock.";
		
		if 		(Input.GetKeyDown (KeyCode.B))  	{ myState = States.bed_1; }
		else if	(Input.GetKeyDown (KeyCode.L))  	{ myState = States.lock_1; }
	}
	void lock_1 () {
		
		text.text = "You reach out to the outside of the lock with the nail and pick the " + 
					"lock.  You are successful in picking the lock." + 
					"\n\n" +
					"Press (O) to open cell door.";
		
		if 		(Input.GetKeyDown (KeyCode.O))  	{ myState = States.corridor_0; }
	}
	void corridor_0 () {
		
		text.text = "You open the cell door and walk out into a corridor.  There are a closet " + 
					"door and stairs going up here." + 
					"\n\n" +
					"Press (S) go up stairs, (F) examine floor, (C) look at closet door.";
		
		if 		(Input.GetKeyDown (KeyCode.S))  	{ myState = States.stairs_0; }
		else if	(Input.GetKeyDown (KeyCode.F))  	{ myState = States.floor; }
		else if	(Input.GetKeyDown (KeyCode.C))  	{ myState = States.closet_door; }
	}
	void stairs_0 () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (R) to return.";
		
		if 		(Input.GetKeyDown (KeyCode.R))  	{ myState = States.corridor_0; }
	}
	void floor () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (H) pickup hairpin, (R) to return.";
		
		if 		(Input.GetKeyDown (KeyCode.H))  	{ myState = States.corridor_1; }
		else if (Input.GetKeyDown (KeyCode.R))  	{ myState = States.corridor_0; }
	}
	void closet_door () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (R) to return.";
		
		if 		(Input.GetKeyDown (KeyCode.R))  	{ myState = States.corridor_0; }
	}
	void corridor_1 () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (S) climb stairs, (P) pick and open closet door.";
		
		if 		(Input.GetKeyDown (KeyCode.S))  	{ myState = States.stairs_1; }
		else if (Input.GetKeyDown (KeyCode.P))  	{ myState = States.in_closet; }
	}
	void stairs_1 () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (R) to return.";
		
		if 		(Input.GetKeyDown (KeyCode.R))  	{ myState = States.corridor_1; }
	}
	void in_closet () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (D) dress in uniform, (B) to corridor.";
		
		if 		(Input.GetKeyDown (KeyCode.B))  	{ myState = States.in_closet; }
		else if	(Input.GetKeyDown (KeyCode.D))  	{ myState = States.corridor_3; }
	}
	void corridor_2 () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (B) to go back into closet, (S) climb stairs.";
		
		if 		(Input.GetKeyDown (KeyCode.B))  	{ myState = States.in_closet; }
		else if	(Input.GetKeyDown (KeyCode.S))  	{ myState = States.stairs_2; }
	}
	void stairs_2 () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (R) to return.";
		
		if 		(Input.GetKeyDown (KeyCode.R))  	{ myState = States.corridor_2; }
	}
	void corridor_3 () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (U) to undress, (S) climb stairs.";
		
		if 		(Input.GetKeyDown (KeyCode.U))  	{ myState = States.in_closet; }
		else if	(Input.GetKeyDown (KeyCode.S))  	{ myState = States.courtyard; }
	}
	void courtyard () {
		
		text.text = "You have been accused of  . " +
			"There are some dirty sheets on the bed, a mirror on " +
				"the wall, and the door is locked from the outside.\n\n" +
				"Press (P) to play again.";
		
		if 		(Input.GetKeyDown (KeyCode.P))  	{ myState = States.cell; }
	}
	#endregion
	
}
