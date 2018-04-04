using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ControllerButtonPusher : MonoBehaviour {

	public AudioSource hit;
	public AudioSource wrong;
	public AudioSource right;
    public bool open;
    public Text CodeNum;
    private string code;
    private string rightCode;
	private Rigidbody rb;

    Tutoral_animation script;


    private void setText(int num)
    {
        CodeNum.text += num.ToString() + " ";
    }



	void Start ()
	{
        GameObject door = GameObject.Find("Door");
        script = door.GetComponent<Tutoral_animation>();
        code = script.code;
        rightCode = script.rightcode;
        CodeNum.text = "Password: ";
    }

	void FixedUpdate ()
	{
		
	}

    private void OnTriggerEnter(Collider other)
    {
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
		else if (other.gameObject.CompareTag("Green"))
		{
            if(code == rightCode)
             {
                    right.Play();
                    CodeNum.text += "correct";
                    open = true;
             }
			else
			{
				wrong.Play();
				code = "";
                CodeNum.text = "Password: ";
			}
		}
		else if (other.gameObject.CompareTag("Red"))
		{
			hit.Play();
			code = "";
            CodeNum.text = "Password: ";
		}




        //System.Threading.Thread.Sleep(2000);
    }
}
