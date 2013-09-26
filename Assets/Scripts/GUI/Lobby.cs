using UnityEngine;
using System.Collections;

/// <summary>
/// Lobby.
/// 
/// This script accesses the NetworkManager script.
/// </summary>
public class Lobby : MonoBehaviour
{
	#region Public Variables
	
	//This is an exposed variable used to assign the desired GUISkin.
	public GUISkin mySkin;
	
	public int left;
	public int top;
	public int width;
	public int height;
	
	#endregion
	
	#region Private Variables
	
	private bool _justLoaded = true;
	
	//Test rect...
	private Rect _testRect;
	
	#endregion
	
	#region Getters & Setters
	
	
	
	#endregion
	
	#region System Methods
	
	private void Start()
	{
		
	}
	
	private void Update()
	{
		//Used for positioning GUI elements...
		_testRect = new Rect(Screen.width / left, Screen.height / top, Screen.width / width, Screen.height / height);
		
	}
	
	private void OnGUI()
	{
		//This line will style the GUI with the peramiters defined in the assigned GUISkin.
		GUI.skin = mySkin;
		
		DisplayMainMenue();
	}
	
	#endregion
	
	#region Calculation Methods
	
	private void DisplayMainMenue()
	{
		if(_justLoaded == true)
		{
			
			
			GUI.Box(_testRect, "Main Menu");
		}
	}
	
	#endregion
}