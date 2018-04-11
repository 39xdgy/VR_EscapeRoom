using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ControllerButtonPusher : MonoBehaviour {
	// three sound for open the door, wrong code, and hit the button
	public AudioSource hit;
	public AudioSource wrong;
	public AudioSource right;
	// the boolean is to chack the door is open or not
    public bool open;
	// text on the top of the keypad
    public Text CodeNum;
	// code is user input, rightcode is the correct number
    private string code;
    private string rightCode;
	private Rigidbody rb;
	//calling from a script from another object
    Tutoral_animation script;

	//function to add the number after the string of code
    private void setText(int num)
    {
        CodeNum.text += num.ToString() + " ";
    }


	//setup when the game started
	void Start ()
	{
		//find the door object and pass the script into the script valuable 
        GameObject door = GameObject.Find("Door");
        script = door.GetComponent<Tutoral_animation>();
		//use the value insdie the other script to this script
        code = script.code;
        rightCode = script.rightcode;
        CodeNum.text = "Password: ";
    }

	//when the object collide with the botton
    private void OnTriggerEnter(Collider other)
    {
		//check which number is pressed, and 1. add the number 2. play the sound 3. add the text on the top of the keypad
        if (other.gameObject.CompareTag("Zero"))
        {
            code += "0";
            hit.Play();
            setText(0);
        }
		else if (other.gameObject.CompareTag("One"))
        {
            code += "1";
            hit.Play();
            setText(1);
        }
		else if (other.gameObject.CompareTag("Two"))
        {
            code += "2";
            hit.Play();
            setText(2);
        }
		else if (other.gameObject.CompareTag("Three"))
        {
            code += "3";
            hit.Play();
            setText(3);
        }
		else if (other.gameObject.CompareTag("Four"))
        {
            code += "4";
            hit.Play();
            setText(4);
        }
		else if (other.gameObject.CompareTag("Five"))
        {
            code += "5";
            hit.Play();
            setText(5);
        }
		else if (other.gameObject.CompareTag("Six"))
        {
            code += "6";
            hit.Play();
            setText(6);
        }
		else if (other.gameObject.CompareTag("Seven"))
        {
            code += "7";
            hit.Play();
            setText(7);
        }
		else if (other.gameObject.CompareTag("Eight"))
        {
            code += "8";
            hit.Play();
            setText(8);
        }
		else if (other.gameObject.CompareTag("Nine"))
        {
            code += "9";
            hit.Play();
            setText(9);
        }
		//if the player hit the green key, which they think they got it right
		else if (other.gameObject.CompareTag("Green"))
		{
			//if the code is actually correct, play the right sound, should correct, and open the door
            if(code == rightCode)
             {
                    right.Play();
                    CodeNum.text += "correct";
                    open = true;
             }
			// this else mean they got it wrong, play the wrong sound and reset the code and the text on the top
			else
			{
				wrong.Play();
				code = "";
                CodeNum.text = "Password: ";
			}
		}
		//if the player hit the red key, which they want to clean the code
		else if (other.gameObject.CompareTag("Red"))
		{
			//play the sound, reset the code and the text on the top
			hit.Play();
			code = "";
            CodeNum.text = "Password: ";
		}
    }
}
